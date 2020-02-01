#pragma once
#include "Common.h"
class CommandHandler
{
public:
	virtual bool Process(Command *command) = 0;
};

struct CommandHandlerKVPSpec {
	byte operation;
	CommandHandler* handler;
};
typedef CommandHandlerKVPSpec CommandHandlerKVP;
