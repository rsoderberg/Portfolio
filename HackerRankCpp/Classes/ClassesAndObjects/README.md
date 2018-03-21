# Classes and Objects
https://www.hackerrank.com/challenges/classes-objects/problem  
    
###### Problem:  
Kristen is a contender for valedictorian of her high school. She wants to know how many students (if any) have scored higher than her in the five exams given during this semester.  
Create a class named Student with the following specifications:  
	An instance variable named scores to hold a student's 5 exam scores.  
	A void input() function that reads 5 integers and saves them to scores.  
	An int calculateTotalScore() function that returns the sum of the student's scores.  
  
###### Input/Output:  
Read 5 scores from the input and save them to your scores instance variable.  
Return the student's total grade (sum of the values in scores).
  
###### Constraints:  
1 <= n <= 100  
1 <= examscore <= 50  
  
Sample Input:  
Note: The first line contains the number of students. The n subsequent lines contain each student's 5 exam grades for the semester.  
	3  
	30 40 45 10 10  
	40 40 40 10 10  
	50 20 30 10 10  
Sample Output:  
	1   
  
###### Explanation:  
Kristin's grades are the first line of grades. Only one student scored higher than her.  
  
###### Method:  
	- Create Student class and take in the lines of data into an array.  
	- Calculate Kristin's score, then compare to each of the following scores to determine whether her score is the highest of the totals.  
	- Print the number of students who scored a total that was higher than Kristin's.  