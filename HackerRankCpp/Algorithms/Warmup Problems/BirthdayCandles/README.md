# Birthday Cake Candles
https://www.hackerrank.com/challenges/birthday-cake-candles/problem  
    
###### Problem:  
Colleen is having a birthday! She will have a cake with one candle for each year of her age. When she blows out the candles, she’ll only be able to blow out the tallest ones.  
Find and print the number of candles she can successfully blow out.   
  
###### Constraints:  
	1 <= n <= 10^5  
	1 <= heighti <= 10^7  
 
###### Input/Output:  
The first line contains a single integer, n, denoting the number of candles on the cake.  
The second line contains n space-separated integers, where each integer i describes the height of candle i.  
  
Sample Input:  
	4  
	3 2 1 3  
Sample Output:  
	2  
  
##### Explanation:  
The maximum candle height is 3 and there are two candles of that height.  
  
###### Method:  
	- Take in n and ignore.  
	- Until n is reached, take in candle heights and compare each to the current stored tallest value.
		For the first value consider it the tallest and begin the counter at 1, resetting if a higher value is found.  
	- Output number of blowable candles.  