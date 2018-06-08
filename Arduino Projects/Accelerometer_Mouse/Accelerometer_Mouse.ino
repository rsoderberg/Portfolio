// Use onboard accelerometer to move mouse cursor and
// left/right buttons to simulate respective mouse clicks

#include <Adafruit_CircuitPlayground.h>
#include <Mouse.h>

float X, Y;

void setup() {
  Serial.begin(9600);
  CircuitPlayground.begin();
  Mouse.begin();

  pinMode(4, INPUT);
  pinMode(19, INPUT);
}

void loop() {
  if (digitalRead(21) == HIGH) { // Switch must be on
    X = 0.0;
    Y = 0.0;

    X = CircuitPlayground.motionX();
    Y = CircuitPlayground.motionY();

    Mouse.move(X, Y);
    delay(25);

    // Mouse clicks
    if (digitalRead(4) == HIGH) {
      Mouse.click(MOUSE_LEFT);
      delay(5);
    }
    if (digitalRead(19) == HIGH) {
      Mouse.click(MOUSE_RIGHT);
      delay(5);
    }
  }
}
