#pragma once
#include <arduino.h>

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
    OpCode operation;
    int dataLength;
    byte* parameters;
};
typedef struct CommandSpec Command;
