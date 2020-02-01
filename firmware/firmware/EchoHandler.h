#pragma once
#include "Common.h"
#include "CommandHandler.h"

class EchoHandler :
	public CommandHandler
{
private:
public:
	bool Process(Command *comm);
};

