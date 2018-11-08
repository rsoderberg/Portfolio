#include <Adafruit_CircuitPlayground.h>
#include <Adafruit_Circuit_Playground.h>

// Analog LED Clock with Alarm using Circuit Playground
// Integrated with a C# .NET Windows Form Application

// Rachel Soderberg
// November 2018

// - One color to indicate hour, fill minutes around
//      LED ring using another color.
// - Small LED to indicate am/pm

uint32_t hourColor = 0xff9b04; // orange
uint32_t minuteColor = 0x049bff; // blue
uint32_t otherColor = 0x049bff; // salmon

uint8_t hourCounter = 9;
uint8_t minuteCounter = 0; // 1000ms = 1s, 60000ms = 1m, 3600000ms = 1h

void setup() {
  // put your setup code here, to run once:
  CircuitPlayground.begin();
}

void loop() {
  // put your main code here, to run repeatedly:
  hoursClock();
}

void hoursClock(){
  // Need to handle the fact there are 12 hours and only 10 LEDs
  while (hourCounter >= 0){
    CircuitPlayground.setPixelColor(hourCounter, hourColor);
    hourCounter--;
    delay(60000); // 60 seconds
    CircuitPlayground.clearPixels();
    if (hourCounter == 0){
      hourCounter = 9;
    }
  }
}

void minutesClock(){

}
