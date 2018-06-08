// Left button: Cycle forward through each LED with colors
// Right button: Cycle backwards through each LED
// Colors: Red - Green - Blue - Cyan - Yellow - Magenta - White

#include <Adafruit_CircuitPlayground.h>

// Button States
uint32_t rightButtonState = 0; // Current reading from input button
uint32_t leftButtonState = 0;
uint8_t ledPos = 0;

void setup() {
  // put your setup code here, to run once:
  CircuitPlayground.begin();
  
  pinMode(19, INPUT); // Right button, go forward
  pinMode(4, INPUT); // Left button, go backward
}

void loop() {
  // put your main code here, to run repeatedly:
  uint32_t digReadRight = digitalRead(19);
  uint32_t digReadLeft = digitalRead(4);
    
  if (digReadRight != rightButtonState) // If right button state has changed
  {
    rightButtonState = digReadRight;

    if (digitalRead(19) == HIGH)
    {
      CircuitPlayground.setPixelColor(ledPos, 255, 0, 0); // red
        
      ledPos++;

      if (ledPos < 0)
      {
        ledPos++;
      }

      if (ledPos > 9 && ledPos < 20)
      {
        CircuitPlayground.setPixelColor(ledPos - 10, 0, 255, 0); // green
      }

      if (ledPos > 19 && ledPos < 30)
      {
        CircuitPlayground.setPixelColor(ledPos - 20, 0, 0, 255); // blue
      }

      if (ledPos > 29 && ledPos < 40)
      {
        CircuitPlayground.setPixelColor(ledPos - 30, 0, 255, 255); // cyan
      }

      if (ledPos > 39 && ledPos < 50)
      {
        CircuitPlayground.setPixelColor(ledPos - 40, 255, 255, 0); // yellow
      }

      if (ledPos > 49 && ledPos < 60)
      {
        CircuitPlayground.setPixelColor(ledPos - 50, 255, 0, 255); // magenta
      }

      if (ledPos > 59 && ledPos < 70)
      {
        CircuitPlayground.setPixelColor(ledPos - 60, 255, 255, 255); // white
      }
      if (ledPos >= 70)
      {
        ledPos--;
      }
    }
  }

  if (digReadLeft != leftButtonState) // If left button state has changed
  {
    leftButtonState = digReadLeft;

    if (digitalRead(4) == HIGH)
    {
      CircuitPlayground.setPixelColor(ledPos - 1, 0, 0, 0); // red > blank
      ledPos--;

      if (ledPos < 0)
      {
        ledPos++;
      }
  
      if (ledPos >= 9 && ledPos <= 20)
      {
        CircuitPlayground.setPixelColor(ledPos - 9, 255, 0, 0); // green > red
      }
  
      if (ledPos >= 19 && ledPos <= 30)
      {
        CircuitPlayground.setPixelColor(ledPos - 19, 0, 255, 0); // blue > green
      }
  
      if (ledPos >= 29 && ledPos <= 40)
      {
        CircuitPlayground.setPixelColor(ledPos - 29, 0, 0, 255); // cyan > blue
      }
  
      if (ledPos >= 39 && ledPos <= 50)
      {
        CircuitPlayground.setPixelColor(ledPos - 39, 0, 255, 255); // yellow > cyan
      }
  
      if (ledPos >= 49 && ledPos <= 60)
      {
        CircuitPlayground.setPixelColor(ledPos - 49, 255, 255, 0); // magenta > yellow
      }
  
      if (ledPos >= 59 && ledPos < 70)
      {
        CircuitPlayground.setPixelColor(ledPos - 59, 255, 0, 255); // white > magenta
      }

      if (ledPos > 70)
      {
        ledPos++;
      }
    }
  }
}

