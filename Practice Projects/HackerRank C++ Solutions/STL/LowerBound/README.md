# Lower Bound-STL
https://www.hackerrank.com/challenges/cpp-lower-bound/problem  
      
###### Problem:  
You are given n integers in sorted order, then you are given q queries. In each query you will be given an integer and you must tell whether the integer is present in the array. If present, you must tell which index it is present in and if not present, you must tell the index at which the smallest integer that is just greater than the given number is present.  
Note: You must use lower bound.  
  
###### Constraints:  
	1 <= N <= 10^5  
	1 <= Xi <= 10^9, where xi is the ith element in the array    
	1 <= Q <= 10^5  
	1 <= Y <= 10^9  
 
###### Input/Output:  
The first line of input contains the number of integers n. The next line contains n integers in sorted order.
The third line contains q, the number of queries. The next q lines follow, each containing a single integer y.  
If the same number is present multiple times, print the first index at which it occurs. The input is such that you always have an answer for each query.  
For each query, print "Yes" if the number is present and at which index (1-based) it is present in, separated by a space.  
If the number is not present, print "No" followed by the index of the next smallest number just greater than that number.  
Output each query in a new line.  
  
Sample Input:  
	8  
	1 1 2 2 6 9 9 15  
	4  
	1  
	4  
	9  
	15  
Sample Output:  
	Yes 1  
	No 5  
	Yes 6  
	Yes 8  
    
###### Method:  
	- Take in n.  
	- Until n is reached, take in integers and add to the vector.  
	- Sort vector (likely unnecessary, but good habit).  
	- Take in q.  
	- While the number of queries is less than q, use lower bound to determine whether the value is found in the array and output yes or no accordingly along with the corresponding position in the vector.  