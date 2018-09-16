// Print current light and temperature values using sensor

#include <Adafruit_CircuitPlayground.h>
#include <Keyboard.h>

void setup() {
  Serial.begin(9600);
  CircuitPlayground.begin();
  Keyboard.begin();

  pinMode(19, INPUT);
}

void loop() {
  if (digitalRead(19) == HIGH) {
    delay(50);
    Temperature:
    notepadLaunch();
    delay(1000);
    deviceTemp();
    deviceLight();
  }
}

// Open Notepad to print output
void notepadLaunch() {
  Keyboard.write(KEY_LEFT_GUI);
  delay(50);
  Keyboard.print("notepad");
  delay(50);
  Keyboard.write(KEY_RETURN);
}

// Display temperature in Fahrenheit and Celsius
void deviceTemp() {
  Keyboard.print("Temperature:");
  Keyboard.write(KEY_RETURN);
  Keyboard.print(CircuitPlayground.temperatureF());
  Keyboard.print(" F");
  Keyboard.write(KEY_RETURN);
  Keyboard.print(CircuitPlayground.temperature());
  Keyboard.print(" C");
  Keyboard.write(KEY_RETURN);
}

// Display light value in lumens
void deviceLight() {
  Keyboard.print("Light:");
  Keyboard.write(KEY_RETURN);
  Keyboard.print(CircuitPlayground.lightSensor());
  Keyboard.print(" 1x");
}

