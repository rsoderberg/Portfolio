# Mini-Max Sum
https://www.hackerrank.com/challenges/mini-max-sum/problem  
    
###### Problem:  
Given five positive integers, find the minimum and maximum values that can be calculated by summing exactly four of the five integers. Then print the respective minimum and maximum values as a single line of two space-separated long integers.  
  
###### Input/Output:  
A single line of five space-separated integers.  
  
Sample Input:  
	1 2 3 4 5  
Sample Output:  
		10 14  
  
##### Explanation:  
Our initial numbers are 1, 2, 3, 4, 5. We can calculate the following sums using four of the five integers:  
	1. If we sum everything except 1, our sum is 2 + 3 + 4 + 5 = 14.  
	2. If we sum everything except 2, our sum is 1 + 3 + 4 + 5 = 13.  
	3. If we sum everything except 3, our sum is 1 + 2 + 4 + 5 = 12.  
	4. If we sum everything except 4, our sum is 1 + 2 + 3 + 5 = 11.  
	5. If we sum everything except 5, our sum is 1 + 2 + 3 + 4 = 10.  
Hint: Beware of integer overflow! Use a 64-bit integer.  
  
###### Method:  
	- Create a vector of 5 and input values.  
	- Add each input together to find the total sum, then find the min and max of each "set".  
	- Print out the total sum minus the max sum (min sum) and the total sum minus the min sum (max sum).  