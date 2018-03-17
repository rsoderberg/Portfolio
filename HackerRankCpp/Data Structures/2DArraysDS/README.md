# Arrays-DS
https://www.hackerrank.com/challenges/2d-array/problem  
        
###### Problem:  
Calculate the hourglass sum for every hourglass in A, then print the maximum hourglass sum.  
  
###### Input/Output:  
There are 6 lines of input, where each line contains 6 space-separated integers describing 2D Array A; every value in A will be in the inclusive range of -9 to 9.  

###### Constraints:  
	-9 <= A[i][j] <= 9  
	0 <= i,j <= 5  
  
###### Output Format:  
Print the largest (maximum) hourglass sum found in A.  
  
Sample Input:  
	1 1 1 0 0 0  
	0 1 0 0 0 0  
	1 1 1 0 0 0  
	0 0 2 4 4 0  
	0 0 0 2 0 0  
	0 0 1 2 4 0  
Sample Output:  
	19  
  
##### Explanation:  
A contains the following hourglasses:  
	1 1 1   1 1 0   1 0 0   0 0 0
	  1       0       0       0
	1 1 1   1 1 0   1 0 0   0 0 0

	0 1 0   1 0 0   0 0 0   0 0 0
	  1       1       0       0
	0 0 2   0 2 4   2 4 4   4 4 0

	1 1 1   1 1 0   1 0 0   0 0 0
	  0       2       4       4
	0 0 0   0 0 2   0 2 0   2 0 0

	0 0 2   0 2 4   2 4 4   4 4 0
	  0       0       2       0
	0 0 1   0 1 2   1 2 4   2 4 0
  
The hourglass with the maximum sum (19) is:  
	2 4 4  
	  2  
	1 2 4  
  
###### Method:  
	- Take in 2D array using a vector of vectors.  
	- Push each hourglass sum to a second vector using the array coordinates to add up each "hourglass shape."  
	- Print the max_element of the vector, comparing each sum from the beginning to the end. Note: Dereference the max_element as it returns an iterator and we want the value.  