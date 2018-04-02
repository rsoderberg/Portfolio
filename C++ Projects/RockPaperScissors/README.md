# Rock Paper Scissors 
###### From "Programming: Principles and Practice Using C++" by Bjarne Stroustrup (2nd Edition)  
#### Chapter 4: Question 10
###### Write a program that plays the game "Rock Paper Scissors." Use a switch-statement to solve this exercise. Also, the machine should give random answers.
###### <em>Real randomness is too hard to provide just now, so just build a vector with a sequence of values to be used as the "next value." If you build a vector into the program, it will always play the same game, so let the user enter some values. Try variations to make it less easy or the user to guess which move the machine will make next.</em>
---
#### Method
##### Solution Notes:  
Chose to use true randomization instead of the suggested vector, seeding and randomizing a value between 1 and 3 and comparing it to the player's move.

##### Libraries:  
iostream - handle input/output  
time.h - seeding fresh random numbers

##### Testing:  
Several test outputs were implemented within the program to show the computer's move to ensure comparison and scoring were functioning properly.

##### Error Handling:  
Checks for good input from user, ignores and prints error if playerMove is invalid. 