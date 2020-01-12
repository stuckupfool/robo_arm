#pragma once
#include "Common.h"
#include "CommandHandler.h"

class EchoHandler :
	public CommandHandler
{
public:
	bool Process(Command comm);
};

