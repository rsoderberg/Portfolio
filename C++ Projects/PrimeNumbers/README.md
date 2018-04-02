# Prime Numbers 
###### From "Programming: Principles and Practice Using C++" by Bjarne Stroustrup (2nd Edition)  
#### Chapter 4: Question 11 & 12
###### Create a program to find all the prime numbers between 1 and an input value max. Write a loop that goes from 1 to max, checks each number to see if it is a prime, and stores each prime found in a vector. Write another loop that lists the primes you found. Consider 2 the first prime.
---
#### Method
##### Solution Notes:
Check if a number can be divided by a prime number smaller than itself using a vector of primes. For example: primes[0]==2, primes[1]==3, primes[2]==5, etc.

##### Libraries:  
iostream - handle input/output  
vector - to utilize the vector data structure

##### Data Structure:  
Vector of prime numbers, growing as far as needed to store all prime numbers up to max. A counter is used to keep track of position in vector as increment begins at 3.

##### Testing:  
Compared output to a list of prime numbers to verify all were present and correct.

##### Error Handling:  
Prints an error if user enters a max of 0 or 1, as 2 is the assumed first prime number.
In progress - Gracefully handle invalid inputs such as letters and symbols. At this time the program gets stuck in a loop if improper input is entered.