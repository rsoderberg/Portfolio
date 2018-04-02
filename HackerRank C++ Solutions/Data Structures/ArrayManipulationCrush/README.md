# Array Manipulation (Crush)
https://www.hackerrank.com/challenges/crush/problem  
  
*Please note that this solution is not yet 100% complete, very large sets of very large numbers cause timeout errors.*  
    
###### Problem:  
You are given a 1-indexed list of size n, initialized with zeros. You must perform m operations on the list and output the maximum of final values of all the n elements in the list. For every operation, you are given three integers, a, b, and k, and you must add value k to all elements ranging from index a to b (inclusive).  
For example, consider list a of size 3: The initial list would be a = [0,0,0] and after performing the update 0(a,b,k) = (2,3,30), the new list would be a = [0,30,30]. Here we've added value 30 to elements between indexes 2 and 3. NOte the index of the list starts at 1.  
  
###### Constraints:  
3 <= n <= 10^7  
1 <= m <= 2 * 10^5  
1 <= a <= b <= n  
0 <= k <= 10^9  
 
###### Input/Output:  
The first line contains two space-separated integers denoting the respective values of n and m.  
The next m lines contain three space-separated integers a, b, and k.  
Numbers in the list are numbered from 1 to n.  
  
Sample Input:  
	5 3  
	1 2 100  
	2 5 100  
	3 4 100  
Sample Output:  
	200  
  
##### Explanation:  
After the first update, the list will be   100 100  0   0   0.  
After the second update, the list will be  100 200 100 100 100.  
After the third update, the list will be   100 200 200 200 100.  
So the required answer will be 200.  
  
###### Method:  
	- Read n and m values.  
	- Loop until m is reached, reading in a, b, and k values to a dynamic array of size n.  
	- As each set of three values is read in, determine whether each position in the array needs to be updated (provided by a and b).  
	- Add value k to positions denoted in a through b, keep all other positions the same.  
	- Output the max value from the final version of the array.  