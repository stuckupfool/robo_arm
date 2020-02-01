#include "CommandReceiver.h"

CommandReceiver::CommandReceiver() {
    handlerCapacity = 2;
    handlerMap = new CommandHandlerKVP*[handlerCapacity];
}

CommandReceiver::CommandReceiver(int init_capacity)
{
    handlerCapacity = init_capacity;
    handlerMap = new CommandHandlerKVP * [handlerCapacity];
}

//Free handlers and the command receiver
CommandReceiver::~CommandReceiver() {
    for (int i = 0; i < handlerCount;i++) {
        delete handlerMap[i]->handler;
    }
    delete handlerMap;
}

bool CommandReceiver::registerCommandHandler(byte opCode, CommandHandler *comm) {
    if (!isRegisterdOpCode(opCode)) {
        if (handlerCount >= handlerCapacity) {
           expandHandlerMap(handlerCapacity * 2);
        }
        CommandHandlerKVP *newHandler = new CommandHandlerKVP();
        newHandler->operation = opCode;
        newHandler->handler = comm;
        handlerMap[handlerCount++] = newHandler;
    }
}

void CommandReceiver::expandHandlerMap(int newCapacity) {
    if (newCapacity > handlerCapacity) {
        CommandHandlerKVP** tempHolder = handlerMap;
        handlerCapacity = newCapacity;

        handlerMap = new CommandHandlerKVP*[handlerCapacity];
        
        memcpy(handlerMap, tempHolder, handlerCount * sizeof(CommandHandlerKVP*));
        delete tempHolder;
    }
}

bool CommandReceiver::isRegisterdOpCode(byte code) {
    for (int i = 0; i < handlerCount; i++) {
        if (handlerMap[i]->operation == code) {
            return true;
        }
    }
    return false;
}

int CommandReceiver::opCodeStartPos(byte data[],int length) {
    for (int i = 0; i < length; i++) {
        if (isRegisterdOpCode(data[i]) > 0) { return i; }
    }
    return -1;
}

bool CommandReceiver::parseCommand(Command *comm) {
    byte opCode = comm->operation;
    for(int i = 0; i < handlerCount; i++) {
        if (handlerMap[i]->operation == comm->operation) {
            return handlerMap[i]->handler->Process(comm);
        }
    }

    //Fall through is failure case, dump what we got
    printCommandSpec(comm);
    return false;
}

void CommandReceiver::receiveAndParse() {
    const int availableBytes = Serial.available();
    if (availableBytes > 0) {
        //Data to receive
        byte *receiveBuffer = new byte[availableBytes];
        int readAmountBytes = Serial.readBytes(receiveBuffer, availableBytes);
        if (readAmountBytes != availableBytes) {
            //We encountered something unexpected, but we can account for it
        }

        if (readAmountBytes > 0) {
            memcpy(commandBuffer + commandBufferPos, receiveBuffer, readAmountBytes);
            commandBufferPos += readAmountBytes;

            if (!isReceivingCommand) { //Make sure recently read chunk doesn't contain the start of a command
                opCodePos = opCodeStartPos(receiveBuffer, readAmountBytes); //Position is relative to read buffer
                if (opCodePos >= 0) {
                    isReceivingCommand = true;
                    opCodePos = commandBufferPos - readAmountBytes + opCodePos; //Position now relative to command buffer
                    inFlightCommand = new Command();
                    inFlightCommand->operation = /*(OpCode)*/commandBuffer[opCodePos];
                }
            }

            if (isReceivingCommand) {
                //We have some amount of a command in the buffer, see if we have the whole thing
                int commandBytes = commandBufferPos - opCodePos;
                if (commandBytes >= 3) { //1 byte op code, + 2 bytes data length
                    int dataLength = ((int)commandBuffer[opCodePos + 1] << 8) + commandBuffer[opCodePos + 2];
                    inFlightCommand->dataLength = dataLength;

                    if (commandBytes >= (3 + dataLength)) {
                        //We have the rest of the command (and maybe more)
                        inFlightCommand->parameters = new byte[dataLength];
                        memcpy(inFlightCommand->parameters, commandBuffer + 3, dataLength);
                        isReceivingCommand = false; //End of parsing ops
                        opCodePos = -1; //Reset

                        //Dispatch parsing
                        parseCommand(inFlightCommand);

                        //Cleanup
                        delete inFlightCommand->parameters;
                        delete inFlightCommand;

                        //Account for any extra data in the command buffer, it may be the start of a new command
                        int remainingDataPos = opCodePos + 3 + dataLength + 1;
                        int remainingDataLength = commandBufferPos - remainingDataPos;
                        if (remainingDataLength > 0) {
                            memcpy(commandBuffer, commandBuffer + remainingDataPos, remainingDataLength);

                            //TODO: We need to parse the remaining data enough to check that we don't have a full command waiting since we won't parse again till more data is sent
                        }
                        commandBufferPos = remainingDataLength;
                    }
                }
            }
        }
        delete receiveBuffer;
    }
}

/*
    Utility functions
*/
void CommandReceiver::serialPrintCommandBuffer(byte buffer[], int length) {
    for (int i = 0; i < length; i++) {
        Serial.print((char)buffer[i]);
    }
    Serial.println("");
}

void CommandReceiver::printCommandSpec(Command *comm) {
    Serial.print("+=Not-implemented Command Received, Operation: ");
    //Serial.print(comm->operation);
    Serial.print(", Data Size: ");
    //Serial.print(comm.dataLength);
    Serial.print(", Parameter: ");
    //Serial.write(comm.parameters, comm.dataLength);
    Serial.println(" =+");
}
