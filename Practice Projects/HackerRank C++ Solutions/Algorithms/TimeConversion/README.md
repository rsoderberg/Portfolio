# Time Conversion  
https://www.hackerrank.com/challenges/time-conversion/problem  
    
###### Problem:  
Given a time in 12-hour AM/PM format, convert it to military (24-hour) time.  
Note: Midnight is 12:00:00AM on a 12-hour clock, and 00:00:00 on a 24-hour clock. Noon is 12:00:00PM on a 12-hour clock, and 12:00:00 on a 24-hour clock.  
  
###### Function Description:  
Complete the function which is described by the below function signature:  
string timeConversion(string s) {  
	// Return the 24-hour format time  
}  
s: String which contains the time  
  
###### Input/Output:  
A single string s containing a time in 12-hour clock format (i.e.: hh:mm:ssAM or hh:mm:ssPM), where 01 <= hh <= 12 and 00 <= mm, ss <= 59.  
  
Sample Input:  
	07:05:45PM  
Sample Output:  
	19:05:45  
  
###### Method:  
	- Parse input, separating hours, minutes, seconds, and am/pm to their own variables and removing the colons.  
	- Determine whether the time is am or pm and convert the time accordingly - adding 12 to the hours after midnight for 24-hour format.
	- Output, after adding back the colons and formatting nicely.  