# Class
https://www.hackerrank.com/challenges/c-tutorial-class/problem  
    
###### Problem:  
Create a class named Student representing the student's details and store the data of the student. Create getter and setter functions for each element.  
Create another method to return the string consisting of all class elements separated by a comma.  
  
###### Input/Output:  
Input consists of four lines:  
	The first line contains an integer representing age.  
	The second line contains a string consisting of lowercase Latin characters ('a'-'z') representing the first name of a student.  
	The third line contains a string consisting of lowercase Latin characters ('a'-'z') representing the last name of a student.  
	The fourth line contains an integer representing the standard of the student.  
Output is a single line consisting of age, first name, last name, and standard. Each is separated by one space. Assume I/O will be automatically handled.  
  
###### Constraints:  
1 <= firstname <= 50  
1 <= lastname <= 50  
  
Sample Input:  
	15  
	john  
	carmack  
	10  
Sample Output:  
	15  
	carmack, john  
	10   
	
	15,john,carmack,10  
  
###### Method:  
	- Create Student class and take in the lines of data.  
	- Output the data from the class, printing age in the first line, lastname, firstname in the second line, and standard in the third.  
	- Print another line of output as follows: age,firstname,lastname,standard.  