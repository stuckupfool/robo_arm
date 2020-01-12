#pragma once
class CommandHandler
{
public:
	virtual bool Process(Command command) = 0;
};

