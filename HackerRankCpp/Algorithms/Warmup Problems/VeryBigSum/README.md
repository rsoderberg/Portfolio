# A Very Big Sum   
https://www.hackerrank.com/challenges/a-very-big-sum/problem  
    
###### Problem:  
Calculate and print the sum of the elements in an array, keeping in mind that some of those integers may be quite large.    
  
###### Input/Output:  
The first line contains an integer n.  
The second line contains n space-separated integers for the array.
  
Sample Input:  
	5  
	1000000001 1000000002 1000000003 1000000004 1000000005  
Sample Output:  
	5000000015  
  
##### Explanation:  
The range of the 32-bit integer is (-2^31) to (2^31 - 1) or [-2147483648, 2147483647].  
When we add several integer values, the resulting sum might exceed the above range. Long long int may need to be used to store such sums.  
  
###### Method:  
	- Take in n size of array from user.  
	- Create long long vector of size n and store input values from user.  
	- Parse through vector and add each value to find the sum.  