#include "EchoHandler.h"

bool EchoHandler::Process(Command comm)
{
	if (comm.operation == 48) {
		char* msg = new char[comm.dataLength];
		memcpy(msg, comm.parameters, comm.dataLength);
		Serial.print("ECHO: ");
		Serial.println(msg);

		delete msg;
		delete comm.parameters;
		comm.dataLength = 0;

		return true;
	}
	return false;
}
