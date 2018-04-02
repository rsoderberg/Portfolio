# Compare the Triplets
https://www.hackerrank.com/challenges/compare-the-triplets/problem  
    
###### Problem:  
Alice and Bob each created one problem for HackerRank. A reviewer rates the two challenges, awarding points on a scale from 1 to 100 for three categories: problem clarity, originality, and difficulty.  
We define the rating for Alice's challenge to be the triplet A = (a0, a1, a2), and the rating for Bob's challenge to be the triplet B = (b0, b1, b2).
Find their comparison points by comparing a0 with b0, a1 with b1, and a2 with b2.  
	- If ai > bi, Alice is awarded 1 point.  
	- If ai < bi, Bob is awarded 1 point.  
	- If ai == bi, neither person receives a point.  
Comparison points is the total points a person earned.
  
Given A and B, compare the two challenges and print their respective comparison points.  
  
###### Input/Output:  
The first line contains 3 space-separated integers, a0, a1, and a2, describing the respective values in triplet A.  
The second line contains 3 space-separated integers, b0, b1, and b2, describing the respective values in triplet B.  
  
###### Constraints:  
	1 <= ai <= 100  
	1 <= bi <= 100  
  
Sample Input:  
	5 6 7  
	3 6 10  
Sample Output:  
	1 1  
  
##### Explanation:  
In this example:
	- A = (a0, a1, a2) = (5, 6, 7)  
	- B = (b0, b1, b2) = (3, 6, 10)  
Now let's compare each individual score:  
	- a0 > b0, so Alice receives 1 point.  
	- a1 == b1, so nobody receives a point.  
	- a2 < b2, so Bob receives 1 point.  
Alice's comparison score is 1 and Bob's comparison score is 1. Thus, we print 1 1 (Alice's comparison score followed by Bob's comparison score) on a single line.  
  
###### Method:  
	- Create two vectors, one for Alice's points and one for Bob's points.  
	- Take the first three numbers and add them to Alice's vector. Add the second three numbers to Bob's vector.  
	- Compare the vectors item by item, giving points to Alice or Bob (or neither) when the conditions are met.  