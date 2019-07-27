#include <Adafruit_CircuitPlayground.h>
#include <Adafruit_Circuit_Playground.h>

void setup() {
  Serial.begin(9600);
  CircuitPlayground.begin();

}

void loop() {
  Serial.println(CircuitPlayground.temperatureF());

}
