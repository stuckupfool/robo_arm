#pragma once
#include <arduino.h>

#define PROG_STRING PROGMEM const char

/*PROG_STRING LEDS_ON[] = "LEDs: On";
PROG_STRING LEDS_OFF[] = "LEDs: Off";


PROG_STRING NOT_IMPL[] = "+=Not-implemented Command Received, Operation: ";
PROG_STRING DATA_SIZE[] = ", Data Size: ";
PROG_STRING PARAMETERS[] = ", Parameter: ";
PROG_STRING END[] = " =+";*/

enum OpCodes {
    ECHO = 48,
    SERVO = 49,
    ACK = 50,
};
typedef enum OpCodes OpCode;

/*
 * Message format
 * op code [1 byte] - Enumerated value describing operation to execute on arduino
 * data length [2 bytes] - Number of bytes to follow for parameter data
 * parameters [n bytes] - Optional data payload, parameters of the operation.
 *                        Data format and expected length dependent on the op code
 *                        being executed. Length of this segment, in bytes, must
 *                        equal the data length segment which preceedes.
 */
struct CommandSpec {
    byte operation;
    int dataLength;
    byte* parameters;
};
typedef struct CommandSpec Command;
