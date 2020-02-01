#include "ServoHandler.h"

ServoHandler::ServoHandler(byte num_servos) {
	servos = new Servo[num_servos];
	this->num_servos = num_servos;
}

ServoHandler::~ServoHandler() {
	delete servos;
}

bool ServoHandler::Process(Command* comm) {
	//1st byte is servo number
	//2nd byte is position 0-255
	if (comm->dataLength == 2) {
		return this->PositionServo(comm->parameters[0], (int)comm->parameters[1]);
	}
	return false;
}

bool ServoHandler::RegisterServo(byte servo_num, int pin) {
	if (servo_num < num_servos) {
		servos[servo_num].attach(pin);
		return true;
	}
	return false;
}

bool ServoHandler::PositionServo(byte servo_num, int position) {
	if (servo_num < num_servos) {
		servos[servo_num].write(position);
		return true;
	}
	return false;
}