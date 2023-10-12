// Cycle red, pulse cyan, blink red - green - blue - cyan - yellow - magenta - white
// Cycle green, pulse cyan, blink red - green - blue - cyan - yellow - magenta - white
// Cycle blue, pulse cyan, blink red - green - blue - cyan - yellow - magenta - white

#include <Adafruit_CircuitPlayground.h>

uint32_t color = 0x00FF0000;

uint8_t counter = 0;
uint8_t cyanCounter = 0;

void setup() {
  CircuitPlayground.begin();
}

void loop() {
  cycleColors();

  counter = 0; // Start entire sequence over
}

void cycleColors() {
  while (counter < 3)
  {
    for (uint8_t i = 0; i < 10; i++)
    {
    CircuitPlayground.setPixelColor(i, color);
    delay(250);
    }
    CircuitPlayground.clearPixels();

    color >>= 8;

    if (color == 0)
    color = 0x00FF0000;

    cyanFade();
    cyanCounter = 0; // Reset counter to start loop over
    flashColors();
    
    counter++;
  }
}

void cyanFade() {
  while (cyanCounter < 1)
  {
  for (uint8_t i = 0; i < 255; i += 5)
  {
    for (uint8_t j = 0; j < 10; j++)
    {
      CircuitPlayground.setPixelColor(j, 0, i, i);
      delay(2);
    }
  }

  for (uint8_t i = 255; i > 0; i -= 5)
  {
    for (uint8_t j = 0; j < 10; j++)
    {
      CircuitPlayground.setPixelColor(j, 0, i, i);
      delay(3);
    }
  }
    cyanCounter++;
  }
}

void flashColors() {
// red
  for (uint8_t i = 0; i < 10; i++)
  {
    CircuitPlayground.setPixelColor(i, 0x00FF0000);
  }
  delay(250);

  CircuitPlayground.clearPixels();

  delay(250);
// green
  for (uint8_t i = 0; i < 10; i++)
  {
    CircuitPlayground.setPixelColor(i, 0x0000FF00);
  }
  delay(250);

  CircuitPlayground.clearPixels();

  delay(250);
// blue
  for (uint8_t i = 0; i < 10; i++)
  {
    CircuitPlayground.setPixelColor(i, 0x000000FF);
  }
  delay(250);

  CircuitPlayground.clearPixels();

  delay(250);
//cyan
  for (uint8_t i = 0; i < 10; i++)
  {
    CircuitPlayground.setPixelColor(i, 0x0000FFFF);
  }
  delay(250);

  CircuitPlayground.clearPixels();

  delay(250);
// yellow
  for (uint8_t i = 0; i < 10; i++)
  {
    CircuitPlayground.setPixelColor(i, 0x00FFFF00);
  }
  delay(250);

  CircuitPlayground.clearPixels();

  delay(250);
// magenta
  for (uint8_t i = 0; i < 10; i++)
  {
    CircuitPlayground.setPixelColor(i, 0x00FF00FF);
  }
  delay(250);

  CircuitPlayground.clearPixels();

  delay(250);
// white
  for (uint8_t i = 0; i < 10; i++)
  {
    CircuitPlayground.setPixelColor(i, 0x00FFFFFF);
  }
  delay(250);

  CircuitPlayground.clearPixels();

  delay(250);
}

