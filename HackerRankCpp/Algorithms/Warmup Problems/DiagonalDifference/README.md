# Diagonal Difference  
https://www.hackerrank.com/challenges/diagonal-difference/problem  
    
###### Problem:  
Given a square matrix, calculate the absolute difference between the sums of its diagonals.  
  
###### Function Description:  
integer diagonalDifference(2D_integer_array a) {  
	// Return the absolute difference between the diagonal sums  
}  
a: 2D array of elements in the matrix  
  
###### Constraints:  
-100 <= Elements in the matrix <= 100  
 
###### Input/Output:  
The first line contains a single integer, n, denoting the number of rows and columns in the matrix a.  
The next n lines denote the matrix a's rows, with each line containing n space-separated integers describing the columns.  
  
Sample Input:  
	3  
	11 2 4  
	4 5 6  
	10 8 -12  
Sample Output:  
		15  
  
##### Explanation:  
The primary diagonal is:  
   11  
	  5  
		-12  
Sum across the primary diagonal: 11 + 5 + (-12) = 4  
The secondary diagonal is:  
		4
	  5  
   10  
Sum across the secondary diagonal: 4 + 5 + 10 = 19  
Difference: |4 - 19| = 15  
  
Note: |x| is the absolute value of x.  
  
###### Method:  
	- Take in n and create 2D vector.  
	- Take in values to create a n x n matrix.  
	- Parse through the matrix, matching the coordinates corresponding to the diagonals:  
		[i] == [j] corresponds to primary diagonal [0,0], [1,1], [2,2], etc.  
		[i + j] == [a.size() - 1] corresponds to secondary diagonal [5,5], [4,4], [3,3], etc.  
	- Find the absolute difference of the primary and secondary diagonals.  