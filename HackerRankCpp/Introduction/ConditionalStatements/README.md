# Conditional Statements  
https://www.hackerrank.com/challenges/c-tutorial-conditional-if-else/problem  
    
###### Problem:  
Given a positive integer denoting n, do the following:  
	If 1 <= n <= 9, print the lowercase English word corresponding to the number.  
	If n > 9, print "Greater than 9".  
  
###### Input/Output:  
A single integer denoting n.
If 1 <= n <= 9, print the lowercase English word corresponding to the number, otherwise print "Greater than 9".  
  
###### Constraints:  
	1 <= n <= 10^9  
  
Sample Input:  
	5  
Sample Output:  
	five  
  
##### Explanation:  
"Five" is the English word for the number 5.  
  
###### Method:  
	- Take in value n.  
	- Determine whether the number is inclusive between 1 and 9, outputting the corresponding English word.  
		If the number is not in the range, break out and print "Greater than 9".  