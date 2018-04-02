# Quadratic Equation Calculator
###### From "Programming: Principles and Practice Using C++" by Bjarne Stroustrup (2nd Edition)  
#### Chapter 5: Question 7
###### Quadratic equations are of the form:  
######          a * x^2 + b * x + c = 0
###### To solve these, one uses the quadratic formula:
######          x = (-b +/- sqrt(b^2 - 4ac)) / 2a
###### Write a program that can calculate x for a quadratic equation, given a, b, and c.
---
#### Method
##### Solution Notes:  


##### Libraries:  
iostream - handle input/output  

##### Testing:  
Used online resources to compare and determine whether the results given by the program was accurate.  
Printed test outputs at critical intervals to ensure calculations were executing in the proper order.

##### Error Handling:  
Catches and outputs warning for divide by zero error.
In progress - Gracefully handle invalid inputs such as letters and symbols. At this time the program simply exits.