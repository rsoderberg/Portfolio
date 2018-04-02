# Vector-Erase  
https://www.hackerrank.com/challenges/vector-erase/problem  
      
###### Problem:  
You are given N integers, then two queries. For the first query, you are provided one integer denoting a position in the vector. The value at this position needs to be erased.  
The next query consists of two integers denoting a range of the positions in the vector. The elements falling under that range should be removed. The second query is performed on the updated vector after the first query has been performed.  
  
###### Constraints:  
	1 <= N <= 10^5  
	1 <= x <= N  
	1 <= a < b <= N  
 
###### Input/Output:  
The first line of the input contains an integer N.  
The second line contains N space-separated integers.  
The third line contains a single integer x, denoting the position of an element that should be removed from the vector.  
The fourth line contains two integers a and b denoting the range that should be erased from the vector inclusive of a and exclusive of b.  
Print the size of the vector in the first line and the elements of the vector after the two erase operations in the second line separated by a space.  
  
Sample Input:  
	6  
	1 4 6 2 8 9  
	2  
	2 4  
Sample Output:  
	3  
	1 8 9  
  
###### Explanation:  
The first query is to erase the second element in the vector, which is 4. Our modified vector is {1,6,2,8,9}. Next we want to remove the range 2 - 4, which is the second and third elements. 6 and 2 are removed from the modified vector and we finally get {1,8,9}.  
  
###### Method:  
	- Take in n.  
	- Until n is reached, take in integers and add to the vector.  
	- Take in third line for position to delete and remove that value from the vector.  
	- Take in the fourth line for the range to be deleted and remove those values from the vector.  
	- Print the resulting vector after all operations.  