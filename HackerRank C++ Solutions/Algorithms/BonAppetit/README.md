# Bon Appetit
https://www.hackerrank.com/challenges/bon-appetit/problem  
    
###### Problem:  
Anna and Brian are sharing a meal at a restaurant and they agree to split the bill equally. Brian wants to order something that Anna is allergic to, so they agree that Anna won't pay for that item. Brian gets the check and calculates Anna's portion. You must determine whether his calculation is correct.  
  
###### Constraints:  
	2 <= n <= 10^5  
	0 <= k < n  
	0 <= bill[i] <= 10^4  
	0 <= b <= sum of all bill[i]  
 
###### Input/Output:  
The first line contains two space-separated integers n and k, the number of items ordered, and the 0-based index of the item that Anna did not eat.  
The second line contains n space-separated integers bill[i], where 0 <= i < n.  
The third line contains an integer, b, the amount of money that Brian charged Anna for her share of the bill.  
If Brian did not overcharge Anna, print "Bon Appetit" on a new line; otherwise, print the difference (b charged - b actual) that Brian must refund to Anna. This will always be an integer.  
  
Sample Input:  
	4 1  
	3 10 2 9  
	12  
Sample Output:  
	5  
  
##### Explanation:  
Anna didn't eat item bill[1] = 10, but she shared the rest of the items with Brian. The total cost of the shared items is 3 + 2 + 9 = 14 and, split in half, the cost per person is b actual = 7.  
Brian charged her b charged = 12 for her portion of the bill, so we print the amount Anna was overcharged (b charged - b actual = 12 - 7 = 5) on a new line.  
  
###### Method:  
	- Take in n and k.  
	- Count to n, taking in the cost of each item ordered (ignoring k, the item Anna didn't eat) and getting the total sum of all.  
	- Divide the sum of all items (minus Anna's uneaten) by 2.  
	- Compare the divided sum with Brian's calculation and determine whether he was correct. If correct, print "Bon Appetit" and if wrong, print the amount difference that Brian owes Anna.  