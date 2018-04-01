# Sets-STL
https://www.hackerrank.com/challenges/cpp-sets/problem  
      
###### Problem:  
If x = 1, add an element x to the set.  
If x = 2, delete an element x from the set. If the number x is not present in the set, do nothing.  
If x = 3, if the number is present in the set, print "Yes" else print "No."  
  
###### Constraints:  
	1 <= Q <= 10^5  
	1 <= y <= 3  
	1 <= x <= 10^9  
 
###### Input/Output:  
The first line of the input contains Q where Q is the number of queries. The next Q lines contain one query each. Each query consists of two integers, y and x, where y is the type of query and x is an integer.  
For queries of type 3, print "Yes" if the number is present in the set. IF the number is not present, print "No."  
Each query of type 3 should be printed in a new line.  
  
Sample Input:  
	8  
	1 9  
	1 6  
	1 10  
	1 4  
	3 6  
	3 14  
	2 6  
	3 6  
Sample Output:  
	Yes  
	No  
	No  
    
###### Method:  
	- Take in q.  
	- For each query, take in the type and value of the query (y and x).  
	- If y is query type 1, insert x to the set. If y is query type 2, delete x from the set (if present). If y is query type 3, find the value and print "Yes" if x is present and "No otherwise.  