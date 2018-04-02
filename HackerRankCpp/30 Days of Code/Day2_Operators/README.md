# Day 2: Operators 
https://www.hackerrank.com/challenges/30-operators/problem  
      
###### Problem:  
Given the meal price, tip percent, and tax percent for a meal, find and print the meal's total cost.  
Note: Be sure to use precise values to avoid incorrectly rounded results
   
###### Input/Output:  
The first line has a double, mealCost.  
The second line has an integer, tipPercent.  
The third has an integer, taxPercent.  
Print "the total meal cost is " totalCost " dollars." where totalCost is the rounded integer result of the entire bill.  
  
Sample Input:  
	12.00  
	20  
	8  
Sample Output:  
	The total meal cost is 15 dollars.    
  
###### Explanation:  
Given:  
mealCost = 12, tipPercent = 20, taxPercent = 8

Calculations:  
tip = 12 * (20/100) = 2.4  
tax = 12 * (8/100) = 0.96  
totalCost = mealCost + tip + tax = 12 + 2.4 + 0.96 = 15.36  
round(totalCost) = 15  

We round totalCost to the nearest dollar and print our result:  
The total meal cost is 15 dollars.  
    
###### Method:  
	- Take in mealCost, tipPercent, and taxPercent.  
	- Perform calculations for tipPercent and taxPercent.  
	- Calculate totalCost.  
	- Print result.  