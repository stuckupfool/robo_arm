#pragma once
#include "CommandHandler.h"
#include <Servo.h>

class ServoHandler :
	public CommandHandler
{
private:
	Servo* servos;
	byte num_servos;
public:
	ServoHandler(byte num_servos);
	~ServoHandler();

	bool Process(Command* command);
	bool RegisterServo(byte servo_num, int pin);
	bool PositionServo(byte servo_num, int position);
};

