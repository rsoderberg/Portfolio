# Grading Students
https://www.hackerrank.com/challenges/grading/problem  
    
###### Problem:  
At HackerLand University, a passing grade is any grade 40 points or higher on a 100 point scale. Sam is a professor at the university and likes to round each student's grade according to the following rules:  
	- If the difference between the grade and the next higher multiple of 5 is less than 3, round to the next higher multiple of 5.  
	- If the grade is less than 38, don't bother as it's still a failing grade.  
Automate the rounding process then round a list of grades and print the results.  
  
###### Constraints:  
	1 <= n <= 60
	0 <= gradei <= 100 
 
###### Input/Output:  
For each grade i of the n grades, print the rounded grade on a new line.  
  
Sample Input:  
	4  
	73  
	67  
	38  
	33  
Sample Output:  
	75  
	67  
	40  
	33  
  
##### Explanation:  
The first grade, 73, is 2 below the next multiple of 5, so it rounds to 75.  
67 is 3 points less than the next higher multiple of 5, so it doesn't round.  
38, like 73, rounds up to the next higher multiple of 5, or 40 in this case.  
33 is less than 38, so it does not round.  
  
###### Method:  
	- Take in n and ignore.  
	- Add each score to a vector.  
	- Create a second vector to store grades after processing.  
	- Handle scores between 38 and 100, determining the closest greater multiple of five and comparing whether the difference is less than three.  
	- Round score if difference is less than three, otherwise keep original score for output.  