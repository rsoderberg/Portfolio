// Rachel Soderberg
// Hacker Rank Strings - StringStream
// March 14th, 2018

#include "Header.h"

std::vector<int> parseInts(std::string str) {
	char ch;
	int val;

	std::vector<int> results;
	std::stringstream ss(str);

	while (ss >> val) {
		results.push_back(val); // Integer values
		ss >> ch; // Dump the comma delimiters
	}

	return results;
}

// Alternative solution
/*
stringstream ss(str);int a;vector<int> vec;
while (ss >> a){vec.push_back(a);
if (ss.peek() == ','){ // Peek at the top of the stream and ignore it if a comma is foundss.ignore();}}
return vec;
*/