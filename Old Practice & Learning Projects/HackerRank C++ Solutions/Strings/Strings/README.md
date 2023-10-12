# Strings
https://www.hackerrank.com/challenges/c-tutorial-strings/problem  
    
###### Problem:  
Take two strings and manipulate them for several different string outputs.  
  
###### Input/Output:  
You are given two strings, a and b, separated by a new line. Each string will consist of lowercase Latin characters.  
Take two strings and print several things using string manipulation:  
	- Print two space-separated integers, representing the length of a and b respectively.  
	- Print the string produced by concatenating a and b (a + b).  
	- Print two strings separated by a space, a' and b'. a' and b' are the same as a and b, respectively except their first characters are swapped.  
  
Sample Input:  
	abcd  
	ef  
Sample Output:  
	4 2  
	abcdef  
	ebcd af  
  
###### Explanation:  
a = "abcd"  
b = "ef"  
|a| = 4  
|b| = 2  
a + b = abcdef  
a' = "ebcd"  
b' = "af"  
  
###### Method:  
	- Take in the strings a and b.  
	- Get a count for each string's size for the first line of output.  
	- Find the sum of a and b for the second line of output.  
	- Output the first letter of the opposite string, followed by the letters of the main string for the third line of output.  