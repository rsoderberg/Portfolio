#pragma once
// Program: ClassPractice
// Author: Rachel Soderberg
// Date Created: January 18, 2018
// Latest Edit: January 18, 2018

// Description: Person class

#include <iostream>

class Person {
	std::string firstName, lastName = " ";
	int age = 0;
	char gender = ' ';
public:
	const std::string get_name() { return firstName + " " + lastName; }
	const int get_age() { return age; }
	const char get_gender() { return gender; }
	void set_values(std::string, std::string, int, char);
	void set_name(std::string, std::string);
	void set_age(int);
	void set_gender(char);
};