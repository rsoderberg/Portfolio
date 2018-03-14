# Simple Array Sum  
https://www.hackerrank.com/challenges/variable-sized-arrays/problem  
    
###### Problem:  
Consider an n-element array, a, where each index i in the array contains a reference to an array of ki integers, where the value of ki varies from array to array.  
Given a, provide q queries. Each query is in the format i j, where i denotes an index in array a and j denotes an index in the array located at a[i]. For each query, find and print the value of element j in the array at location a[i] on a new line.  
  
###### Input/Output:  
The first line contains two space-separated integers denoting the respective values of n (the number of variable-length arrays) and q (the number of queries).  
Each line i of the n subsequent lines contains a space-separated sequence in the format k a[i]0 a[i]1 ... a[i]k-1 describing k-element array located at a[i].  
Each of the q subsequent lines contains two space-separated integers describing the respective values of i (an index in array a) and j (an index in the array referenced by a[i]) for a query.  
  
###### Constraints:  
	All indexes in this challenge are zero-based.  
	All the given numbers are non-negative and are not greater than 10^6.  
  
Sample Input:  
	2 2  
	3 1 5 4  
	5 1 2 8 9 3  
	0 1  
	1 3  
Sample Output:  
	5  
	9  
  
##### Explanation:  
The diagram below depicts the Sample Input:
	(n = 2)  
	0 -> 1 5 4 (k = 3)  
	1 -> 1 2 8 9 3 (k = 5)  
We perform the following q = 2 queries:  
	1. Find the array located at index i = 0, which corresponds to a[0] = [1,5,4]. We must print the value at index j = 1 of this array which, as you can see, is 5.  
	2. Find the array located at index i = 1, which corresponds to a[1] = [1,2,8,9,3]. We must print the value at index j = 3 of this array which, as you can see, is 9.  
  
###### Method:  
	- Take in the first line of input, n number of vectors and q number of queries.  
	- Create vector of n vectors and take in second set of lines of input, pushing them to the vector.  
	- Take in third set of lines of input for the coordinates within the vector of vectors to output q number of queries.  