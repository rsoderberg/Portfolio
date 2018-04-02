# Left Rotation  
https://www.hackerrank.com/challenges/array-left-rotation/problem  
    
###### Problem:  
Given an array of n integers and a number, d, perform d left rotations on the array. Print the updated array as a single line of space-separated integers.   
  
###### Constraints:  
1 <= n <= 10^5  
1 <= d <= n  
1 <= ai <= 10^6  
 
###### Input/Output:  
The first line contains two space-separated integers denoting the respective values of n (number of integers) and d (number of left rotations).  
The second line contains n space-separated integers describing the respective elements of the array's initial state.  
Print a single line of n space-separated integers denoting the final state of the array after performing d left rotations.  
  
Sample Input:  
	5 4  
	1 2 3 4 5  
Sample Output:  
	5 1 2 3 4  
  
##### Explanation:  
When we perform d = 4 left rotations, the array undergoes the following sequence of changes:  
	[1,2,3,4,5] -> [2,3,4,5,1] -> [3,4,5,1,2] -> [4,5,1,2,3] -> [5,1,2,3,4]  
Thus, we print the array's final state as a single line of space-separated values, which is 5 1 2 3 4.  
  
###### Method:  
	- Read n and q values, then push elements into the dynamic array in the original order.  
	- Initialize an iterator variable to d for array traversal.  
	- Push the dth element, all elements from d to n, and all elements from 0 to d into a new dynamic array.  
	- Print the new rotated dynamic array.  