#include "EchoHandler.h"

bool EchoHandler::Process(Command *comm)
{
	Serial.print("ECHO(");
	Serial.print(comm->operation);
	Serial.print("): ");
	for (int i = 0; i < comm->dataLength; i++) {
		Serial.print((char)comm->parameters[i]);
	}
	Serial.print("\r\n");
	Serial.flush();
	return true;
}
