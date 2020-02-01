//typedef uint8_t byte
/*
 * Command Stuff
 */
/*#include <power_mgt.h>
#include <platforms.h>
#include <pixeltypes.h>
#include <pixelset.h>
#include <noise.h>
#include <lib8tion.h>
#include <led_sysdefs.h>
#include <hsv2rgb.h>
#include <fastspi_types.h>
#include <fastspi_ref.h>
#include <fastspi_nop.h>
#include <fastspi_dma.h>
#include <fastspi_bitbang.h>
#include <fastspi.h>
#include <fastpin.h>
#include <fastled_progmem.h>
#include <fastled_delay.h>
#include <fastled_config.h>
#include <FastLED.h>
#include <dmx.h>
#include <cpp_compat.h>
#include <controller.h>
#include <colorutils.h>
#include <colorpalettes.h>
#include <color.h>
#include <chipsets.h>
#include <bitswap.h>*/
#include <arduino.h>
#include <Servo.h>
#include "Common.h"
#include "CommandReceiver.h"
#include "EchoHandler.h"
#include "ServoHandler.h"
#include "IcoHandler.h"

const long BAUD_RATE = 9600;
//TODO: Switch to pre-allocated when we know how many commands there will be
CommandReceiver comRec = CommandReceiver(); 
//EchoHandler *echoHandle = new EchoHandler();
//ServoHandler* servoHandle = new ServoHandler(2);
IcoHandler* icoHandle = new IcoHandler();


void setup() {
    Serial.begin(BAUD_RATE);
    
    /*servoHandle->RegisterServo(0, 6);
    servoHandle->RegisterServo(1, 10);

    comRec.registerCommandHandler(48, echoHandle);
    comRec.registerCommandHandler(49, servoHandle);*/
    comRec.registerCommandHandler(50, icoHandle); // On/Off
    comRec.registerCommandHandler(51, icoHandle); // Mode & Palette
    comRec.registerCommandHandler(52, icoHandle); // Mode & Custom Palette
}

void loop() {
    comRec.receiveAndParse();

    icoHandle->Tick();
}
