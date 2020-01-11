/*
 * Command Stuff
 */
const long BAUD_RATE = 9600;
enum OpCodes {
  ECHO = 48,
  SERVO = 49,
  ACK = 50,
};
typedef enum OpCodes OpCode;
OpCode ValidOpCodes[] = { ECHO,SERVO,ACK };
const int OpCodeCount = 2;

struct CommandSpec {
  OpCode operation;
  int dataLength;
  byte *parameters;
};
typedef struct CommandSpec Command;

bool isReceivingCommand = false;
byte commandBuffer[1024];
int commandBufferPos = 0;
int opCodePos = 0;
Command inFlightCommand;
bool isValidOpCode(byte data);
int opCodeStartPos(byte data[]);
bool parseCommand(Command comm);
void serialPrintCommandBuffer(byte buffer[],int length);
void printCommandSpec(Command comm);

/*
 * Servo Stuff
 */
 #include <Servo.h>
 Servo servos[2];


void setup() {
  // put your setup code here, to run once:
  Serial.begin(BAUD_RATE);

  servos[0].attach(6);
  servos[1].attach(10);
}

bool isValidOpCode(byte data) {
  for(int i = 0; i < OpCodeCount; i++) {
    if((int)data == ValidOpCodes[i]) { return true; }
  }
  return false;
}

int opCodeStartPos(byte data[],int length) {
  for(int i = 0; i < length; i++) {
    if(isValidOpCode(data[i])) { return i; }
  }
  return -1;
}

bool parseCommand(Command comm) {
  switch(comm.operation) {
    case ECHO:
      Serial.print("ECHO: ");
      for(int i = 0; i < comm.dataLength; i++) {
        Serial.print((char)comm.parameters[i]);
      }
      Serial.print("\r\n");
      break;
    case SERVO:
      {
        byte servoNum = comm.parameters[0];
        byte pos = comm.parameters[1];
        if(servoNum >= 0 && servoNum < 2) {
          if(pos >= 0 && pos <= 180) {
            servos[servoNum].write(pos);
            Serial.println(servoNum);
            Serial.println(pos);
          }
        }
      }
      break;
    default:
      printCommandSpec(comm); 
  }
  return true; //TODO: Fill out
}

void serialPrintCommandBuffer(byte buffer[],int length) {
  for(int i = 0; i < length; i++) {
    Serial.print((char)buffer[i]);
  }
  Serial.println("");
}

void printCommandSpec(Command comm) {
  Serial.print("+=Not-implemented Command Received, Operation: ");
  Serial.print(comm.operation);
  Serial.print(", Data Size: ");
  Serial.print(comm.dataLength);
  Serial.print(", Parameter: ");
  Serial.write(comm.parameters,comm.dataLength);
  Serial.println(" =+");
}

void loop() {
  
  int availableBytes = Serial.available();
  if(availableBytes > 0) {
    //Serial.println("==LOOP START==");
    //Data to receive
    byte receiveBuffer[availableBytes];
    int readAmountBytes = Serial.readBytes(receiveBuffer,availableBytes);
    if(readAmountBytes != availableBytes) {
      //We encountered something unexpected, but we can account for it
    }
    
    if(readAmountBytes > 0) {
      memcpy(commandBuffer + commandBufferPos,receiveBuffer,readAmountBytes);
      commandBufferPos += readAmountBytes;

      if(!isReceivingCommand) { //Make sure recently read chunk doesn't contain the start of a command
        opCodePos = opCodeStartPos(receiveBuffer, readAmountBytes); //Position is relative to read buffer
        if(opCodePos >= 0) { 
          isReceivingCommand = true; 
          opCodePos = commandBufferPos - readAmountBytes + opCodePos; //Position now relative to command buffer
          inFlightCommand.operation = (OpCode)commandBuffer[opCodePos];
        }
      }

      if(isReceivingCommand) {
        //We have some amount of a command in the buffer, see if we have the whole thing
        int commandBytes = commandBufferPos - opCodePos;
        if(commandBytes >= 3) { //1 byte op code, + 2 bytes data length
          int dataLength = ((int)commandBuffer[opCodePos + 1] << 8) + commandBuffer[opCodePos + 2];
          inFlightCommand.dataLength = dataLength;

          if(commandBytes >= (3 + dataLength)) {
            inFlightCommand.parameters = new byte[dataLength];
            memcpy(inFlightCommand.parameters,commandBuffer + 3,dataLength);
            isReceivingCommand = false; //End of parsing ops
            opCodePos = -1; //Reset

            //Dispatch parsing
            parseCommand(inFlightCommand);

            //Account for any extra data in the command buffer, it may be the start of a new command
            int remainingDataPos = opCodePos + 3 + dataLength + 1;
            int remainingDataLength = commandBufferPos - remainingDataPos;
            if(remainingDataLength > 0) {
              memcpy(commandBuffer, commandBuffer + remainingDataPos, remainingDataLength);

              //TODO: We need to parse the remaining data enough to check that we don't have a full command waiting since we won't parse again till more data is sent
            }
            commandBufferPos = remainingDataLength;
          }
        }
      }
    }
  }
}

/*
 * Message format
 * op code [1 byte] - Enumerated value describing operation to execute on arduino
 * data length [2 bytes] - Number of bytes to follow for parameter data
 * parameters [n bytes] - Optional data payload, parameters of the operation. 
 *                        Data format and expected length dependent on the op code
 *                        being executed. Length of this segment, in bytes, must
 *                        equal the data length segment which preceedes.
 */
