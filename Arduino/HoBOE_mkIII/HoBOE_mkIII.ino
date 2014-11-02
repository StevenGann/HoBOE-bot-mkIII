#include <Servo.h>

//==============================================
// HoBOE-bot mk.III remote control Arduino code
//----------------------------------------------
// Hardware Config:
//  - BOE-bot chassis
//  - 3 DoF claw
//  - Xbee S1
//  - Arduino Uno
//
// Designed for allowing wireless control of the
// robot from a PC. Control signal could be from
// anything with an Xbee connected, or any source
// or serial data.
//==============================================

Servo WheelLeft;
Servo WheelRight;
Servo ClawVertical;
Servo ClawTwist;
Servo ClawGrasp;

int ServoValues[5];

char inData[20]; // Allocate some space for the string
char inChar; // Where to store the character read
byte index = 0; // Index into array; where to store the character

void setup()
{
  ServoValues[0] = -1;
  ServoValues[1] = -1;
  ServoValues[2] = -1;
  ServoValues[3] = -1;
  ServoValues[4] = -1;
  
  Serial.begin(9600);
  Serial.println("Starting up.");
  
  WheelLeft.attach(9);
  WheelRight.attach(10);
  ClawVertical.attach(11);
  ClawTwist.attach(12);
  ClawGrasp.attach(13);
  
  //Resting values
  WheelLeft.write(93); //Neutral.
  WheelRight.write(93); //Neutral.
  ClawVertical.write(50); //Min. As low as possible.
  ClawTwist.write(90); //Mid. Centered twist.
  ClawGrasp.write(170); //Max. As open as possible.
}

void loop()
{
  while(Serial.available() > 0) //when there's information being received through serial go into this loop
  {
    int messageFlag = Serial.parseInt();
    switch(messageFlag)
    {
      case -1:
        ServoValues[0] = Serial.parseInt(); 
        ServoValues[1] = Serial.parseInt();
        ServoValues[2] = Serial.parseInt();
        ServoValues[3] = Serial.parseInt();
        ServoValues[4] = Serial.parseInt();
        serialFlush();
        //Serial.println("ServoValue[0] = " + String(ServoValues[0]));
        //Serial.println("ServoValue[1] = " + String(ServoValues[1]));
        //Serial.println("ServoValue[2] = " + String(ServoValues[2]));
        //Serial.println("ServoValue[3] = " + String(ServoValues[3]));
        //Serial.println("ServoValue[4] = " + String(ServoValues[4]));
        serialFlush();
        break;
      default:
        Serial.println("READ ERROR\n");
        serialFlush();
    }
  }
  
  //Serial.println(String(ServoValues[0]));
  
  //delay(500);
  //Update Servos
  updateServos();
}

void updateServos()
{
  if (ServoValues[0] > 0 && ServoValues[0] <= 180){ WheelLeft.write(ServoValues[0]); }
  if (ServoValues[1] > 0 && ServoValues[1] <= 180){ WheelRight.write(ServoValues[1]); }
  if (ServoValues[2] > 0 && ServoValues[2] <= 180){ ClawVertical.write(ServoValues[2]); }
  if (ServoValues[3] > 0 && ServoValues[3] <= 180){ ClawTwist.write(ServoValues[3]); }
  if (ServoValues[4] > 0 && ServoValues[4] <= 180){ ClawGrasp.write(ServoValues[4]); }
  /*
  Serial.println("ServoValue[0] = " + String(WheelLeft.read()));
  Serial.println("ServoValue[1] = " + String(WheelRight.read()));
  Serial.println("ServoValue[2] = " + String(ClawVertical.read()));
  Serial.println("ServoValue[3] = " + String(ClawTwist.read()));
  Serial.println("ServoValue[4] = " + String(ClawGrasp.read()));
  */
}

void serialFlush()
{
  while(Serial.available()>0) Serial.read(); 
  //Flushes any other values in the buffer received from the xbee
}
