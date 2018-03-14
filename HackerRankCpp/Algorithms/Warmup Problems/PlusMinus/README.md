# Plus-Minus
https://www.hackerrank.com/challenges/plus-minus/problem  
      
###### Problem:  
Given an array of integers, calculate the fractions of its elements that are positive, negative, and zero.  
Print the decimal value of each fraction on a new line.  
Note: Test cases are scaled to six decimal places, though answers with absolute error of up to 10^-4 are acceptable.  
  
###### Input/Output:  
The first line contains an integer n, denoting the size of the array.  
The second line contains n space-separated integers describing an array of numbers arr(a0, a1, a2,..., an-1).
  
###### Output Format:  
Three lines must be printed:  
	1. A decimal representing the fraction of positive numbers in the array compared to its size.
	2. A decimal representing the fraction of negative numbers in the array compared to its size.  
	3. A decimal representing the fraction of negative numbers in the array compared to its size.  
  
Sample Input:  
	6  
	-4 3 -9 0 4 1    
Sample Output:  
	0.500000  
	0.333333  
	0.166667  
  
##### Explanation:  
There are three positive numbers, two negative numbers, and 1 zero in the test input array.  
The proportions of occurrence are positive: 3/6 = 0.500000, negative: 2/6 = 0.33333, and zeros: 1/6 = 0.166667.
  
###### Method:  
	- Take in n size of array from user.  
	- Create vector of size n and store input values from user.  
	- Parse through vector and compare to find positive, negative, and zero values.  
	- Set output precision to 6 for six decimal place scaling.  
	- Convert each positive, negative, and zero value to double and divide by n total values for decimal representation of the fraction of occurrence of each.  