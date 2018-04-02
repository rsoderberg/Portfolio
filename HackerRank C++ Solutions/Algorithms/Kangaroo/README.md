# Kangaroo
https://www.hackerrank.com/challenges/kangaroo/problem  
    
###### Problem:  
There are two kangaroos on a number line ready to jump in the positive direction (toward +inf). Each kangaroo takes the same amount of time to make a jump, regardless of distance. For example, if kangaroo 1 jumps three meters and kangaroo 2 jumps five meters, they each do it in one second.  
Given the starting locations and jump distances for each kangaroo, determine if and when they will land at the same location at the same time.    
  
###### Constraints:  
0 <= x1 < x2 <= 10,000  
1 <= v1 <= 10,000  
1 <= v2 <= 10,000  
 
###### Output:  
Print YES if they can land on the same location at the same time, otherwise print NO.  
Note: The two kangaroos must land at the same location after making the same number of jumps.  
  
Sample Input:  
	0 3 4 2  
Sample Output:  
	YES  
  
##### Explanation:  
The kangaroos jump through the following sequence of locations:  
K1 - 0 3 6 9 12...  
K2 - 4 6 8 10 12...  
Therefore, the kangaroos will meet after four jumps.
  
###### Method:  
	- Take in values.  
	- Determine whether v2 of the second kangaroo is greater than or equal to v1 of the first, and whether the starting position of the first kangaroo is not equal to the second kangaroo.  
		If this is true, result is "NO".
	- Find the difference in velocity to determine whether the kangaroos will meet later along the timeline.  