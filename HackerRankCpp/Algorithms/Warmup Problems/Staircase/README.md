# Staircase  
https://www.hackerrank.com/challenges/staircase/problem  
    
###### Problem:  
Consider a staircase of size n = 4:  
(Please note, N is being used in place of '#' due to Git formatting)  
		N  
	   NN  
	  NNN  
	 NNNN  
Observe that its base and height are both equal to n, and the image is drawn using '#' symbols and spaces. The last line is not preceded by any spaces.  
Write a program that prints a staircase of size n.
  
###### Input/Output:  
A single integer, n, denoting the size of the staircase.  
Print a staircase of size n using '#' symbols and spaces.  
  
Sample Input:  
	6  
Sample Output:  
		N  
	   NN  
	  NNN  
	 NNNN  
	NNNNN  
   NNNNNN  
  
##### Explanation:  
The staircase is right-aligned, composed of '#' symbols and spaces, and has a height and width of n = 6.  
  
###### Method:  
	- Take in n size of the staircase.  
	- Store the width of the staircase to match the size (w = n).  
	- Counting up to n, format the staircase width to decrease as nCount increases and print '#' symbols corresponding to each row's count.  