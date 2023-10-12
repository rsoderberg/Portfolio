# StringStream
https://www.hackerrank.com/challenges/c-tutorial-stringstream/problem  
    
###### Problem:  
Print a vector of integers after parsing and removing comma delimiters.  
  
###### Input/Output:  
The first and only line consists of n integers separated by commas.  
Print the integers after parsing. Assume I/O will automatically be handled.  
  
Sample Input:  
	23,4,56  
Sample Output:  
	23  
	4  
	56  
  
###### Method:  
	- Take in the values using a vector.  
	- Parse the vector, dumping comma delimiters using "dummy" variable within a stringstream.  
	- Return "cleaned up" results for output.  