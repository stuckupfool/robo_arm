#pragma once
#include "Common.h"
#include "CommandHandler.h"


class CommandReceiver
{
private:
    bool isReceivingCommand = false;
    uint8_t commandBuffer[1024];
    int commandBufferPos = 0;
    int opCodePos = 0;
    int handlerCount = 0;
    Command *inFlightCommand;

    // Initially we'll have space for 2
    int handlerCapacity;
    CommandHandlerKVP** handlerMap;

    bool isRegisterdOpCode(byte code);
    int opCodeStartPos(byte data[], int length);
    bool parseCommand(Command *comm);
    void serialPrintCommandBuffer(byte buffer[], int length);
    void expandHandlerMap(int newCapacity);
public:
    CommandReceiver();
    CommandReceiver(int init_capacity);
    ~CommandReceiver();

    void printCommandSpec(Command *comm);
    void receiveAndParse();

    bool registerCommandHandler(byte opCode, CommandHandler *comm);
};
