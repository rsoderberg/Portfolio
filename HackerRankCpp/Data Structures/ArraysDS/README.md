# Arrays-DS
https://www.hackerrank.com/challenges/arrays-ds/problem  
        
###### Problem:  
Given an array, A, of N integers, print each element in reverse order as a single line of space-separated integers.  
  
###### Input/Output:  
The first line contains an integer N, the number of integers in A.  
The second line contains N space-separated integers describing A.  

###### Constraints:  
	1 <= N <= 10^3  
	1 <= Ai <= 10^4, where A is the ith integer in A.  
  
###### Output Format:  
Print all N integers in A in reverse order as a single line of space-separated integers.  
  
Sample Input:  
	4  
	1 4 3 2  
Sample Output:  
	2 3 4 1  
  
##### Explanation:  
An array is a type of data structure that stores elements of the same type in a contiguous block of memory. In an array A of size N, each memory location has some unique index, i (where 0 <= i < N), that can be referenced as A[i].  
  
###### Method:  
	- Take in n size of array from user.  
	- Create vector of size n and store input values from user.  
	- Parse through vector and compare to find positive, negative, and zero values.  
	- Set output precision to 6 for six decimal place scaling.  
	- Convert each positive, negative, and zero value to double and divide by n total values for decimal representation of the fraction of occurrence of each.  