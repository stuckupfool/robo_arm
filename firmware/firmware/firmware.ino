//typedef uint8_t byte
/*
 * Command Stuff
 */
#include <arduino.h>
#include <Servo.h>
#include "Common.h"
#include "CommandReceiver.h"
#include "EchoHandler.h"

byte t = 1;

/*
 * Servo Stuff
 */
Servo servos[2];

CommandReceiver *comRec = new CommandReceiver();
EchoHandler* echoHandle = new EchoHandler();


void setup() {
    // put your setup code here, to run once
    servos[0].attach(6);
    servos[1].attach(10);

    comRec->registerCommandHandler(48, echoHandle);
}

void loop() {
    comRec->receiveAndParse();
}
