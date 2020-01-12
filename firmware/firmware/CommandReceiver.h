#pragma once
#include "Common.h"
#include "CommandHandler.h"


class CommandReceiver
{
private:
    const long BAUD_RATE = 9600;
    OpCode *ValidOpCodes; // = new OpCode[1]; // = { ECHO,SERVO,ACK };
    //const int OpCodeCount = 2;
    bool isReceivingCommand = false;
    uint8_t commandBuffer[1024];
    int commandBufferPos = 0;
    int opCodePos = 0;
    Command inFlightCommand;
    CommandHandler* handlerMap[256];

    bool isRegisterdOpCode(byte code);
    int opCodeStartPos(byte data[], int length);
    bool parseCommand(Command comm);
    void serialPrintCommandBuffer(byte buffer[], int length);
public:
    CommandReceiver();
    ~CommandReceiver();

    void printCommandSpec(Command comm);
    void receiveAndParse();

    bool registerCommandHandler(byte opCode, CommandHandler *comm);
};
