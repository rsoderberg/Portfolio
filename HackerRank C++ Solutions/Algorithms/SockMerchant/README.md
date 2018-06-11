# Birthday Cake Candles
https://www.hackerrank.com/challenges/sock-merchant/problem  
    
###### Problem:  
John works at a clothing store. He has a large pile of socks that must be paired by color for sale. You will be given an array of integers representing the color of each sock in the pile. Determine how many pairs of socks with matching colors there are.  
Given n and the color of each sock, how many pairs of socks can John sell?  
  
###### Constraints:  
	1 <= n <= 100  
	1 <= ci <= 100 where 0 <= i < n    
 
###### Input/Output:  
The first line contains an integer, n, the number of socks in the pile.  
The second line contains n space-separated integers, describing the colors ci of the socks in the pile.  
Print the total number of matching pairs of socks that John can sell.  
  
Sample Input:  
	9  
	10 20 20 10 10 30 50 10 20  
Sample Output:  
	3  
  
##### Explanation:  
10 - 10, 10 - 10, 20 - 20, 20, 30, 50
John can match three pairs of socks, 10, 10, and 20.
  
###### Method:  
	- Take in n number of socks.  
	- Push each value to vector, then sort.  
	- If current vector value matches the following value, there is a match. Increment again to skip the second value in matching.  
	- Keep total number of pairs and print when vector is exhausted.  