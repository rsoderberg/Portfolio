# Day 3: Introduction to Conditional Statements
https://www.hackerrank.com/challenges/30-conditional-statements/problem  
      
###### Problem:  
Given an integer n, perform the following conditional actions:  
 - If n is odd, print "Weird"
 - If n is even and in the inclusive range of 2 to 5, print "Not Weird"  
 - If n is even and in the inclusive range of 6 to 20, print "Weird"  
 - If n is even and greater than 20, print "Not Weird"  
  
###### Constraints:  
	1 <= n <= 100  
   
###### Input/Output:  
A single line containing a positive integer, n.  
Print "Weird" if the number is weird, otherwise print "Not Weird."  
  
Sample Input:  
	3  
	24  
Sample Output:  
	Weird  
	Not Weird  
  
###### Explanation:  
n = 3: n is odd and odd numbers are weird, print "Weird."  
n = 24: n is greater than 20 and even, so it isn't weird. Print "Not Weird."  
    
###### Method:  
	- Take in integer n.  
	- Determine whether n is even or odd. If odd, print "Weird."  
	- If even, determine which range n lies within and print whether it is weird or not weird accordingly.  