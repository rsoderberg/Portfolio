#include <Adafruit_CircuitPlayground.h>
#include <Adafruit_Circuit_Playground.h>

// Guitar Tuner Using Circuit Playground
// Integrated with a C# Windows Form

// Rachel Soderberg
// June 2017

// Std Guitar Frequencies
// ----------------------
// 1 (e)   329.63 Hz   E4
// 2 (B)   246.94 Hz   B3
// 3 (G)   196.00 Hz   G3
// 4 (D)   146.83 Hz   D3
// 5 (A)   110.00 Hz   A2
// 6 (E)   82.41 Hz    E2

// Microphone Definitions
#define NOTE_E4 330
#define NOTE_B3 247
#define NOTE_G3 196
#define NOTE_D3 147
#define NOTE_A2 110
#define NOTE_E2 82

// FFT Definitions
#define BINS 32  // Number of FFT frequency bins
#define FRAMES 4 // This many FFT cycles are averaged

// Color Definitions
#define RED 0x00FF0000
#define GREEN 0x0000FF00

// Sound Constants
uint32_t microphone = 0; // Microphone level found by on-board mic

uint8_t placeholder = 0; // Increment/Decrement for on-board by-ear tuning cycle

void setup() {
  Serial.begin(9600);
  CircuitPlayground.begin();
  CircuitPlayground.setBrightness(50);
  CircuitPlayground.clearPixels();

  pinMode(4, INPUT);
  pinMode(19, INPUT);
}

void loop() {
  // Get sound data from onboard speaker
  uint16_t microphone = analogRead(A7);

  playTones();
  //attemptingFFT();

  if (digitalRead(21) == LOW) // If slide switch is off...
  {
    Serial.println(analogRead(microphone));
    delay(1000);

    // If the microphone is in e range
    if (microphone >= 320 && microphone <= 340)
    {
       if (microphone == 320)
       {
          CircuitPlayground.clearPixels();
          CircuitPlayground.setPixelColor(0, RED);
          CircuitPlayground.setPixelColor(1, RED);
          CircuitPlayground.setPixelColor(2, RED);
          CircuitPlayground.setPixelColor(3, RED);
          CircuitPlayground.setPixelColor(4, RED);
          Serial.println("Registered e, too low");
          
       }
       if (microphone > 320 && microphone <= 322)
       {
          CircuitPlayground.clearPixels();
          CircuitPlayground.setPixelColor(0, RED);
          CircuitPlayground.setPixelColor(1, RED);
          CircuitPlayground.setPixelColor(2, RED);
          CircuitPlayground.setPixelColor(3, RED);
          Serial.println("Registered e, too low");
          
       }
       if (microphone > 322 && microphone <= 324)
       {
          CircuitPlayground.clearPixels();
          CircuitPlayground.setPixelColor(0, RED);
          CircuitPlayground.setPixelColor(1, RED);
          CircuitPlayground.setPixelColor(2, RED);
          Serial.println("Registered e, too low");
          
       }
       if (microphone > 324 && microphone <= 326)
       {
          CircuitPlayground.clearPixels();
          CircuitPlayground.setPixelColor(0, RED);
          CircuitPlayground.setPixelColor(1, RED);
          Serial.println("Registered e, too low");
          
       }
       if (microphone > 326 && microphone <= 328)
       {
          CircuitPlayground.clearPixels();
          CircuitPlayground.setPixelColor(0, RED);
          Serial.println("Registered e, too low");
          
       }
       if (microphone > 328 && microphone < 332) // Match e
       {
          CircuitPlayground.clearPixels();
          CircuitPlayground.setPixelColor(0, GREEN);
          CircuitPlayground.setPixelColor(9, GREEN);
          Serial.println("Registered e, in pitch!");
          
       }
       if (microphone >= 332 && microphone < 334)
       {
          CircuitPlayground.clearPixels();
          CircuitPlayground.setPixelColor(9, RED);
          Serial.println("Registered e, too high");
          
       }
       if (microphone >= 334 && microphone < 336)
       {
          CircuitPlayground.clearPixels();
          CircuitPlayground.setPixelColor(9, RED);
          CircuitPlayground.setPixelColor(8, RED);
          Serial.println("Registered e, too high");
          
       }
       if (microphone >= 336 && microphone < 338)
       {
          CircuitPlayground.clearPixels();
          CircuitPlayground.setPixelColor(9, RED);
          CircuitPlayground.setPixelColor(8, RED);
          CircuitPlayground.setPixelColor(7, RED);
          Serial.println("Registered e, too high");
          
       }
       if (microphone >= 338 && microphone < 340)
       {
          CircuitPlayground.clearPixels();
          CircuitPlayground.setPixelColor(9, RED);
          CircuitPlayground.setPixelColor(8, RED);
          CircuitPlayground.setPixelColor(7, RED);
          CircuitPlayground.setPixelColor(6, RED);
          Serial.println("Registered e, too high");
          
       }
       if (microphone == 340)
       {
          CircuitPlayground.clearPixels();
          CircuitPlayground.setPixelColor(9, RED);
          CircuitPlayground.setPixelColor(8, RED);
          CircuitPlayground.setPixelColor(7, RED);
          CircuitPlayground.setPixelColor(6, RED);
          CircuitPlayground.setPixelColor(5, RED);
          Serial.println("Registered e, too high");
          
       }
    }
      // If the microphone is in B range
    if (microphone >= 237 && microphone <= 257)
    {
       if (microphone == 237)
       {
          CircuitPlayground.clearPixels();
          CircuitPlayground.setPixelColor(0, RED);
          CircuitPlayground.setPixelColor(1, RED);
          CircuitPlayground.setPixelColor(2, RED);
          CircuitPlayground.setPixelColor(3, RED);
          CircuitPlayground.setPixelColor(4, RED);
          Serial.println("Registered B, too low");
          
       }
       if (microphone > 237 && microphone <= 239)
       {
          CircuitPlayground.clearPixels();
          CircuitPlayground.setPixelColor(0, RED);
          CircuitPlayground.setPixelColor(1, RED);
          CircuitPlayground.setPixelColor(2, RED);
          CircuitPlayground.setPixelColor(3, RED);
          Serial.println("Registered B, too low");
          
       }
       if (microphone > 239 && microphone <= 241)
       {
          CircuitPlayground.clearPixels();
          CircuitPlayground.setPixelColor(0, RED);
          CircuitPlayground.setPixelColor(1, RED);
          CircuitPlayground.setPixelColor(2, RED);
          Serial.println("Registered B, too low");
          
       }
       if (microphone > 241 && microphone <= 243)
       {
          CircuitPlayground.clearPixels();
          CircuitPlayground.setPixelColor(0, RED);
          CircuitPlayground.setPixelColor(1, RED);
          Serial.println("Registered B, too low");
          
       }
       if (microphone > 243 && microphone <= 245)
       {
          CircuitPlayground.clearPixels();
          CircuitPlayground.setPixelColor(0, RED);
          Serial.println("Registered B, too low");
          
       }
       if (microphone > 245 && microphone < 249) // Match B
       {
          CircuitPlayground.clearPixels();
          CircuitPlayground.setPixelColor(0, GREEN);
          CircuitPlayground.setPixelColor(9, GREEN);
          Serial.println("Registered B, in pitch!");
          
       }
       if (microphone >= 249 && microphone < 251)
       {
          CircuitPlayground.clearPixels();
          CircuitPlayground.setPixelColor(9, RED);
          Serial.println("Registered B, too high");
          
       }
       if (microphone >= 251 && microphone < 253)
       {
          CircuitPlayground.clearPixels();
          CircuitPlayground.setPixelColor(9, RED);
          CircuitPlayground.setPixelColor(8, RED);
          Serial.println("Registered B, too high");
          
       }
       if (microphone >= 253 && microphone < 255)
       {
          CircuitPlayground.clearPixels();
          CircuitPlayground.setPixelColor(9, RED);
          CircuitPlayground.setPixelColor(8, RED);
          CircuitPlayground.setPixelColor(7, RED);
          Serial.println("Registered B, too high");
          
       }
       if (microphone >= 255 && microphone < 257)
       {
          CircuitPlayground.clearPixels();
          CircuitPlayground.setPixelColor(9, RED);
          CircuitPlayground.setPixelColor(8, RED);
          CircuitPlayground.setPixelColor(7, RED);
          CircuitPlayground.setPixelColor(6, RED);
          Serial.println("Registered B, too high");
          
       }
       if (microphone == 257)
       {
          CircuitPlayground.clearPixels();
          CircuitPlayground.setPixelColor(9, RED);
          CircuitPlayground.setPixelColor(8, RED);
          CircuitPlayground.setPixelColor(7, RED);
          CircuitPlayground.setPixelColor(6, RED);
          CircuitPlayground.setPixelColor(5, RED);
          Serial.println("Registered B, too high");
          
       }
    }
  
    // If the microphone is in G range
    if (microphone >= 186 && microphone <= 206)
    {
       if (microphone == 186)
       {
          CircuitPlayground.clearPixels();
          CircuitPlayground.setPixelColor(0, RED);
          CircuitPlayground.setPixelColor(1, RED);
          CircuitPlayground.setPixelColor(2, RED);
          CircuitPlayground.setPixelColor(3, RED);
          CircuitPlayground.setPixelColor(4, RED);
          Serial.println("Registered G, too low");
          
       }
       if (microphone > 186 && microphone <= 188)
       {
          CircuitPlayground.clearPixels();
          CircuitPlayground.setPixelColor(0, RED);
          CircuitPlayground.setPixelColor(1, RED);
          CircuitPlayground.setPixelColor(2, RED);
          CircuitPlayground.setPixelColor(3, RED);
          Serial.println("Registered G, too low");
          
       }
       if (microphone > 188 && microphone <= 190)
       {
          CircuitPlayground.clearPixels();
          CircuitPlayground.setPixelColor(0, RED);
          CircuitPlayground.setPixelColor(1, RED);
          CircuitPlayground.setPixelColor(2, RED);
          Serial.println("Registered G, too low");
          
       }
       if (microphone > 190 && microphone <= 192)
       {
          CircuitPlayground.clearPixels();
          CircuitPlayground.setPixelColor(0, RED);
          CircuitPlayground.setPixelColor(1, RED);
          Serial.println("Registered G, too low");
          
       }
       if (microphone > 192 && microphone <= 194)
       {
          CircuitPlayground.clearPixels();
          CircuitPlayground.setPixelColor(0, RED);
          Serial.println("Registered G, too low");
          
       }
       if (microphone > 194 && microphone < 198) // Match G
       {
          CircuitPlayground.clearPixels();
          CircuitPlayground.setPixelColor(0, GREEN);
          CircuitPlayground.setPixelColor(9, GREEN);
          Serial.println("Registered G, in pitch!");
          
       }
       if (microphone >= 198 && microphone < 200)
       {
          CircuitPlayground.clearPixels();
          CircuitPlayground.setPixelColor(9, RED);
          Serial.println("Registered G, too high");
          
       }
       if (microphone >= 200 && microphone < 202)
       {
          CircuitPlayground.clearPixels();
          CircuitPlayground.setPixelColor(9, RED);
          CircuitPlayground.setPixelColor(8, RED);
          Serial.println("Registered G, too high");
          
       }
       if (microphone >= 202 && microphone < 204)
       {
          CircuitPlayground.clearPixels();
          CircuitPlayground.setPixelColor(9, RED);
          CircuitPlayground.setPixelColor(8, RED);
          CircuitPlayground.setPixelColor(7, RED);
          Serial.println("Registered G, too high");
          
       }
       if (microphone >= 204 && microphone < 206)
       {
          CircuitPlayground.clearPixels();
          CircuitPlayground.setPixelColor(9, RED);
          CircuitPlayground.setPixelColor(8, RED);
          CircuitPlayground.setPixelColor(7, RED);
          CircuitPlayground.setPixelColor(6, RED);
          Serial.println("Registered G, too high");
          
       }
       if (microphone == 206)
       {
          CircuitPlayground.clearPixels();
          CircuitPlayground.setPixelColor(9, RED);
          CircuitPlayground.setPixelColor(8, RED);
          CircuitPlayground.setPixelColor(7, RED);
          CircuitPlayground.setPixelColor(6, RED);
          CircuitPlayground.setPixelColor(5, RED);
          Serial.println("Registered G, too high");
          
       }
    }
  
    // If the microphone is in D range
    if (microphone >= 137 && microphone <= 157)
    {
       if (microphone == 137)
       {
          CircuitPlayground.clearPixels();
          CircuitPlayground.setPixelColor(0, RED);
          CircuitPlayground.setPixelColor(1, RED);
          CircuitPlayground.setPixelColor(2, RED);
          CircuitPlayground.setPixelColor(3, RED);
          CircuitPlayground.setPixelColor(4, RED);
          Serial.println("Registered D, too low");
          
       }
       if (microphone > 137 && microphone <= 139)
       {
          CircuitPlayground.clearPixels();
          CircuitPlayground.setPixelColor(0, RED);
          CircuitPlayground.setPixelColor(1, RED);
          CircuitPlayground.setPixelColor(2, RED);
          CircuitPlayground.setPixelColor(3, RED);
          Serial.println("Registered D, too low");
          
       }
       if (microphone > 139 && microphone <= 141)
       {
          CircuitPlayground.clearPixels();
          CircuitPlayground.setPixelColor(0, RED);
          CircuitPlayground.setPixelColor(1, RED);
          CircuitPlayground.setPixelColor(2, RED);
          Serial.println("Registered D, too low");
          
       }
       if (microphone > 141 && microphone <= 143)
       {
          CircuitPlayground.clearPixels();
          CircuitPlayground.setPixelColor(0, RED);
          CircuitPlayground.setPixelColor(1, RED);
          Serial.println("Registered D, too low");
          
       }
       if (microphone > 143 && microphone <= 145)
       {
          CircuitPlayground.clearPixels();
          CircuitPlayground.setPixelColor(0, RED);
          Serial.println("Registered D, too low");
          
       }
       if (microphone > 145 && microphone < 149) // Match e
       {
          CircuitPlayground.clearPixels();
          CircuitPlayground.setPixelColor(0, GREEN);
          CircuitPlayground.setPixelColor(9, GREEN);
          Serial.println("Registered D, in pitch!");
          
       }
       if (microphone >= 149 && microphone < 151)
       {
          CircuitPlayground.clearPixels();
          CircuitPlayground.setPixelColor(9, RED);
          Serial.println("Registered D, too high");
          
       }
       if (microphone >= 151 && microphone < 153)
       {
          CircuitPlayground.clearPixels();
          CircuitPlayground.setPixelColor(9, RED);
          CircuitPlayground.setPixelColor(8, RED);
          Serial.println("Registered D, too high");
          
       }
       if (microphone >= 153 && microphone < 155)
       {
          CircuitPlayground.clearPixels();
          CircuitPlayground.setPixelColor(9, RED);
          CircuitPlayground.setPixelColor(8, RED);
          CircuitPlayground.setPixelColor(7, RED);
          Serial.println("Registered D, too high");
          
       }
       if (microphone >= 155 && microphone < 157)
       {
          CircuitPlayground.clearPixels();
          CircuitPlayground.setPixelColor(9, RED);
          CircuitPlayground.setPixelColor(8, RED);
          CircuitPlayground.setPixelColor(7, RED);
          CircuitPlayground.setPixelColor(6, RED);
          Serial.println("Registered D, too high");
          
       }
       if (microphone == 157)
       {
          CircuitPlayground.clearPixels();
          CircuitPlayground.setPixelColor(9, RED);
          CircuitPlayground.setPixelColor(8, RED);
          CircuitPlayground.setPixelColor(7, RED);
          CircuitPlayground.setPixelColor(6, RED);
          CircuitPlayground.setPixelColor(5, RED);
          Serial.println("Registered D, too high");
          
       }
    }
  
    // If the microphone is in A range
    if (microphone >= 100 && microphone <= 120)
    {
       if (microphone == 100)
       {
          CircuitPlayground.clearPixels();
          CircuitPlayground.setPixelColor(0, RED);
          CircuitPlayground.setPixelColor(1, RED);
          CircuitPlayground.setPixelColor(2, RED);
          CircuitPlayground.setPixelColor(3, RED);
          CircuitPlayground.setPixelColor(4, RED);
          Serial.println("Registered A, too low");
          
       }
       if (microphone > 100 && microphone <= 102)
       {
          CircuitPlayground.clearPixels();
          CircuitPlayground.setPixelColor(0, RED);
          CircuitPlayground.setPixelColor(1, RED);
          CircuitPlayground.setPixelColor(2, RED);
          CircuitPlayground.setPixelColor(3, RED);
          Serial.println("Registered A, too low");
          
       }
       if (microphone > 102 && microphone <= 104)
       {
          CircuitPlayground.clearPixels();
          CircuitPlayground.setPixelColor(0, RED);
          CircuitPlayground.setPixelColor(1, RED);
          CircuitPlayground.setPixelColor(2, RED);
          Serial.println("Registered A, too low");
          
       }
       if (microphone > 104 && microphone <= 106)
       {
          CircuitPlayground.clearPixels();
          CircuitPlayground.setPixelColor(0, RED);
          CircuitPlayground.setPixelColor(1, RED);
          Serial.println("Registered A, too low");
          
       }
       if (microphone > 106 && microphone <= 108)
       {
          CircuitPlayground.clearPixels();
          CircuitPlayground.setPixelColor(0, RED);
          Serial.println("Registered A, too low");
          
       }
       if (microphone > 108 && microphone < 112) // Match e
       {
          CircuitPlayground.clearPixels();
          CircuitPlayground.setPixelColor(0, GREEN);
          CircuitPlayground.setPixelColor(9, GREEN);
          Serial.println("Registered A, in pitch!");
          
       }
       if (microphone >= 112 && microphone < 114)
       {
          CircuitPlayground.clearPixels();
          CircuitPlayground.setPixelColor(9, RED);
          Serial.println("Registered A, too high");
          
       }
       if (microphone >= 114 && microphone < 116)
       {
          CircuitPlayground.clearPixels();
          CircuitPlayground.setPixelColor(9, RED);
          CircuitPlayground.setPixelColor(8, RED);
          Serial.println("Registered A, too high");
          
       }
       if (microphone >= 116 && microphone < 118)
       {
          CircuitPlayground.clearPixels();
          CircuitPlayground.setPixelColor(9, RED);
          CircuitPlayground.setPixelColor(8, RED);
          CircuitPlayground.setPixelColor(7, RED);
          Serial.println("Registered A, too high");
          
       }
       if (microphone >= 118 && microphone < 120)
       {
          CircuitPlayground.clearPixels();
          CircuitPlayground.setPixelColor(9, RED);
          CircuitPlayground.setPixelColor(8, RED);
          CircuitPlayground.setPixelColor(7, RED);
          CircuitPlayground.setPixelColor(6, RED);
          Serial.println("Registered A, too high");
          
       }
       if (microphone == 120)
       {
          CircuitPlayground.clearPixels();
          CircuitPlayground.setPixelColor(9, RED);
          CircuitPlayground.setPixelColor(8, RED);
          CircuitPlayground.setPixelColor(7, RED);
          CircuitPlayground.setPixelColor(6, RED);
          CircuitPlayground.setPixelColor(5, RED);
          Serial.println("Registered A, too high");
          
       }
    }
  
    // If the microphone is in E range
    if (microphone >= 72 && microphone <= 92)
    {
       if (microphone == 72)
       {
          CircuitPlayground.clearPixels();
          CircuitPlayground.setPixelColor(0, RED);
          CircuitPlayground.setPixelColor(1, RED);
          CircuitPlayground.setPixelColor(2, RED);
          CircuitPlayground.setPixelColor(3, RED);
          CircuitPlayground.setPixelColor(4, RED);
          Serial.println("Registered E, too low");
          
       }
       if (microphone > 72 && microphone <= 74)
       {
          CircuitPlayground.clearPixels();
          CircuitPlayground.setPixelColor(0, RED);
          CircuitPlayground.setPixelColor(1, RED);
          CircuitPlayground.setPixelColor(2, RED);
          CircuitPlayground.setPixelColor(3, RED);
          Serial.println("Registered E, too low");
          
       }
       if (microphone > 74 && microphone <= 76)
       {
          CircuitPlayground.clearPixels();
          CircuitPlayground.setPixelColor(0, RED);
          CircuitPlayground.setPixelColor(1, RED);
          CircuitPlayground.setPixelColor(2, RED);
          Serial.println("Registered E, too low");
          
       }
       if (microphone > 76 && microphone <= 78)
       {
          CircuitPlayground.clearPixels();
          CircuitPlayground.setPixelColor(0, RED);
          CircuitPlayground.setPixelColor(1, RED);
          Serial.println("Registered E, too low");
          
       }
       if (microphone > 78 && microphone <= 80)
       {
          CircuitPlayground.clearPixels();
          CircuitPlayground.setPixelColor(0, RED);
          Serial.println("Registered E, too low");
          
       }
       if (microphone > 80 && microphone < 84) // Match e
       {
          CircuitPlayground.clearPixels();
          CircuitPlayground.setPixelColor(0, GREEN);
          CircuitPlayground.setPixelColor(9, GREEN);
          Serial.println("Registered E, in pitch!");
          
       }
       if (microphone >= 84 && microphone < 86)
       {
          CircuitPlayground.clearPixels();
          CircuitPlayground.setPixelColor(9, RED);
          Serial.println("Registered E, too high");
          
       }
       if (microphone >= 86 && microphone < 88)
       {
          CircuitPlayground.clearPixels();
          CircuitPlayground.setPixelColor(9, RED);
          CircuitPlayground.setPixelColor(8, RED);
          Serial.println("Registered E, too high");
          
       }
       if (microphone >= 88 && microphone < 90)
       {
          CircuitPlayground.clearPixels();
          CircuitPlayground.setPixelColor(9, RED);
          CircuitPlayground.setPixelColor(8, RED);
          CircuitPlayground.setPixelColor(7, RED);
          Serial.println("Registered E, too high");
          
       }
       if (microphone >= 90 && microphone < 92)
       {
          CircuitPlayground.clearPixels();
          CircuitPlayground.setPixelColor(9, RED);
          CircuitPlayground.setPixelColor(8, RED);
          CircuitPlayground.setPixelColor(7, RED);
          CircuitPlayground.setPixelColor(6, RED);
          Serial.println("Registered E, too high");
          
       }
       if (microphone == 92)
       {
          CircuitPlayground.clearPixels();
          CircuitPlayground.setPixelColor(9, RED);
          CircuitPlayground.setPixelColor(8, RED);
          CircuitPlayground.setPixelColor(7, RED);
          CircuitPlayground.setPixelColor(6, RED);
          CircuitPlayground.setPixelColor(5, RED);
          Serial.println("Registered E, too high");
          
       }
    }
  }  

  if (digitalRead(21) == HIGH) // If slide switch is on...
  {
    CircuitPlayground.clearPixels(); // Clear LEDs for by-ear tuning
    if (Serial.available() > 2)
    {
      byte command = Serial.read();
  
      switch(command)
      {
        case 0xAA:
        {
          uint16_t note, timing;

          note = Serial.read() << 8;
          note += Serial.read();
          timing = Serial.read() << 8;
          timing += Serial.read();

          CircuitPlayground.playTone(note, timing);
        }
        break;
      }
    }
  }
}

// Play each of the six standard guitar string frequencies
// in order, up eBGDAE with the right button and down EADGBe
// with the left button
void playTones(){
  // Going up - eBGDAE
  if (digitalRead(21) == HIGH) // If slide switch is on...
  {
    CircuitPlayground.clearPixels(); // Clear LEDs for by-ear tuning
    
    if (digitalRead(19) == HIGH && placeholder == 0)
    {   
      placeholder++;
      CircuitPlayground.playTone(NOTE_E4, 1000);
      
    }

    if (digitalRead(19) == HIGH && placeholder == 1)
    {
      placeholder++;
      CircuitPlayground.playTone(NOTE_B3, 1000);
      
    }

    if (digitalRead(19) == HIGH && placeholder == 2)
    {
      placeholder++;
      CircuitPlayground.playTone(NOTE_G3, 1000);
      
    }

    if (digitalRead(19) == HIGH && placeholder == 3)
    {
      placeholder++;
      CircuitPlayground.playTone(NOTE_D3, 1000);
      
    }

    if (digitalRead(19) == HIGH && placeholder == 4)
    {
      placeholder++;
      CircuitPlayground.playTone(NOTE_A2, 1000);
      
    }

    if (digitalRead(19) == HIGH && placeholder == 5)
    {
      placeholder = 0;
      CircuitPlayground.playTone(NOTE_E2, 1000);
      
    }
// Going down - EADGBe
    if (digitalRead(4) == HIGH && placeholder == 5)
    { 
      placeholder--;
      CircuitPlayground.playTone(NOTE_D3, 1000); // A2
      
    }

    if (digitalRead(4) == HIGH && placeholder == 4)
    {
      placeholder--;
      CircuitPlayground.playTone(NOTE_G3, 1000); // D3
      
    }

    if (digitalRead(4) == HIGH && placeholder == 3)
    {
      placeholder--;
      CircuitPlayground.playTone(NOTE_B3, 1000); // G3
      
    }

    if (digitalRead(4) == HIGH && placeholder == 2)
    {
      placeholder--;
      CircuitPlayground.playTone(NOTE_E4, 1000); // B3
      
    }

    if (digitalRead(4) == HIGH && placeholder == 1)
    {
      placeholder--;
      CircuitPlayground.playTone(NOTE_E2, 1000); // E4
      
    }
    
    if (digitalRead(4) == HIGH && placeholder == 0)
    {
      placeholder = 5;
      CircuitPlayground.playTone(NOTE_A2, 1000); // E2
      
    }
  }
}

//////////////////////////////////////////////////////

// My attempt at using FFT, if I have time I will need to go back
// and see if I can troubleshoot this into working
void attemptingFFT() {
  uint8_t i,j;
  uint16_t spectrum[BINS];     // FFT spectrum output buffer
  uint16_t avg[BINS];          // The average of FRAME "listens"
 
  for(j=1; j <= FRAMES; j++) {             // We gather data FRAMES times and average it
     CircuitPlayground.mic.fft(spectrum);  // Here is the CP listen and FFT the data routine
     for(i=0; i < BINS; i++) {             // Add for an average
       if(spectrum[i] > 255) spectrum[i] = 255; // limit outlier data
       if(i == 0)
         avg[i] = spectrum[i];
       else
         avg[i] = avg[i] + spectrum[i];
     }
  } 
  for(i=0; i < BINS; i++) {               // For each output bin average
     avg[i] = avg[i] / FRAMES;            //  divide about the number of values averaged
  }
  int maxVal = 0, maxIndex = 0;
  for(i=0; i < BINS; i++) {               // For each output bin average
     if(avg[i] >= maxVal) {               //  find the peak value
       maxVal = avg[i];
       maxIndex = i;                      //  and the bin that max value is in
     }
  }
  for(j=0; j < 32; j++) {           // print spectrum 32 bins
     Serial.print(avg[j]);
     Serial.print(" ");
  }
  Serial.println("");              // and print the highest value and the bin it is in
  Serial.print("Max Value = "); Serial.print(maxVal * 4);
  Serial.print(", Index of Max Value = "); Serial.println(maxIndex);

  // If the maxVal is in e range
  if (maxVal >= 320 && maxVal <= 340)
  {
     if (maxVal == 320)
     {
        CircuitPlayground.clearPixels();
        CircuitPlayground.setPixelColor(0, RED);
        CircuitPlayground.setPixelColor(1, RED);
        CircuitPlayground.setPixelColor(2, RED);
        CircuitPlayground.setPixelColor(3, RED);
        CircuitPlayground.setPixelColor(4, RED);
        Serial.println("Registered e, too low");
        
     }
     if (maxVal > 320 && maxVal <= 322)
     {
        CircuitPlayground.clearPixels();
        CircuitPlayground.setPixelColor(0, RED);
        CircuitPlayground.setPixelColor(1, RED);
        CircuitPlayground.setPixelColor(2, RED);
        CircuitPlayground.setPixelColor(3, RED);
        Serial.println("Registered e, too low");
        
     }
     if (maxVal > 322 && maxVal <= 324)
     {
        CircuitPlayground.clearPixels();
        CircuitPlayground.setPixelColor(0, RED);
        CircuitPlayground.setPixelColor(1, RED);
        CircuitPlayground.setPixelColor(2, RED);
        Serial.println("Registered e, too low");
        
     }
     if (maxVal > 324 && maxVal <= 326)
     {
        CircuitPlayground.clearPixels();
        CircuitPlayground.setPixelColor(0, RED);
        CircuitPlayground.setPixelColor(1, RED);
        Serial.println("Registered e, too low");
        
     }
     if (maxVal > 326 && maxVal <= 328)
     {
        CircuitPlayground.clearPixels();
        CircuitPlayground.setPixelColor(0, RED);
        Serial.println("Registered e, too low");
        
     }
     if (maxVal > 328 && maxVal < 332) // Match e
     {
        CircuitPlayground.clearPixels();
        CircuitPlayground.setPixelColor(0, GREEN);
        CircuitPlayground.setPixelColor(9, GREEN);
        Serial.println("Registered e, in pitch!");
        
     }
     if (maxVal >= 332 && maxVal < 334)
     {
        CircuitPlayground.clearPixels();
        CircuitPlayground.setPixelColor(9, RED);
        Serial.println("Registered e, too high");
        
     }
     if (maxVal >= 334 && maxVal < 336)
     {
        CircuitPlayground.clearPixels();
        CircuitPlayground.setPixelColor(9, RED);
        CircuitPlayground.setPixelColor(8, RED);
        Serial.println("Registered e, too high");
        
     }
     if (maxVal >= 336 && maxVal < 338)
     {
        CircuitPlayground.clearPixels();
        CircuitPlayground.setPixelColor(9, RED);
        CircuitPlayground.setPixelColor(8, RED);
        CircuitPlayground.setPixelColor(7, RED);
        Serial.println("Registered e, too high");
        
     }
     if (maxVal >= 338 && maxVal < 340)
     {
        CircuitPlayground.clearPixels();
        CircuitPlayground.setPixelColor(9, RED);
        CircuitPlayground.setPixelColor(8, RED);
        CircuitPlayground.setPixelColor(7, RED);
        CircuitPlayground.setPixelColor(6, RED);
        Serial.println("Registered e, too high");
        
     }
     if (maxVal == 340)
     {
        CircuitPlayground.clearPixels();
        CircuitPlayground.setPixelColor(9, RED);
        CircuitPlayground.setPixelColor(8, RED);
        CircuitPlayground.setPixelColor(7, RED);
        CircuitPlayground.setPixelColor(6, RED);
        CircuitPlayground.setPixelColor(5, RED);
        Serial.println("Registered e, too high");
        
     }
  }
}
