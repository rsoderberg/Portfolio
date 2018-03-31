# Vector-Sort
https://www.hackerrank.com/challenges/vector-sort/problem  
    
###### Problem:  
You are given N integers. Sort the N integers and print the sorted order.  
Store the N integers in a vector.  
  
###### Constraints:  
	1 <= N <= 10^5  
	1 <= Vi <= 10^9, where Vi is the ith integer in the vector  
 
###### Input/Output:  
The first line of the input contains N where N is the number of integers. The next line contains N integers.  
Print the integers in the sorted order one by one in a single line followed by a space.  
  
Sample Input:  
	5  
	1 6 10 8 4  
Sample Output:  
	1 4 6 8 10  
  
###### Method:  
	- Take in n.  
	- Until n is reached, take in integers and add to the vector.  
	- Sort vector from begin() to end().  
	- Print contents of vector.  