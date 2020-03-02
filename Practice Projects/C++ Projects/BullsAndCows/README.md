# Bulls And Cows  
###### From "Programming: Principles and Practice Using C++" by Bjarne Stroustrup (2nd Edition)  
#### Chapter 5: Question 12 & 13
###### Implement a little guessing game called "Bulls and Cows." The program has a set of four different integers in the range 0 to 9 (e.g., 1234 but not 1122) and it is the user's task to discover those numbers by repeated guesses. Say the number to be guessed is 1234 and the user guesses 1359; the response should be "1 bull and 1 cow" because the user got one digit (1) right and in the right position (a bull) and one digit (3) right but in the wrong position (a cow). The guessing continues until the user gets four bulls, that is, has the four digits correct and in the correct order.
###### Make a version of the program where the user can play repeatedly without stopping and restarting the program, and each game has a new set of four digits.
---
#### Method
##### Libraries:  
iostream - handle input/output  
time.h - seeding fresh random numbers

##### Data Structure:  
None at this time, planning to implement a vector to replace the groups of variables used for randNum and the user's guesses. 

##### Testing:  
Several test outputs were implemented within the program to show the randomly generated numbers so I could check what was being passed as guesses and ensure they were stored properly until the win state was met (and reset as expected with the playAgain() function).

##### Error Handling:  
Checks for good input from user, prints error if cin.fail().  
Ensures fully unique random numbers by checking against the other generated numbers, generates new numbers if any are repeated until all are unique. No error output printed.
Prints error message if user enters an invalid input as any of the four guessed digits.