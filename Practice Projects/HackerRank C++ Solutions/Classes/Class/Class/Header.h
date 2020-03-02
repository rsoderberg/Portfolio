#pragma once

#include <iostream>
#include <string>
#include <sstream>

class Student {
private:
	int age = 0;
	std::string first_name = "";
	std::string last_name = "";
	int standard = 0;
public:
	int get_age() {
		return age;
	}
	std::string get_first_name() { return first_name; }
	std::string get_last_name() { return last_name; }
	int get_standard() { return standard; }
	void set_age(int getAge) { age = getAge; }
	void set_first_name(std::string getFirst_name) { first_name = getFirst_name; }
	void set_last_name(std::string getLast_name) { last_name = getLast_name; }
	void set_standard(int getStandard) { standard = getStandard; }

	// Return the string consisting of the class elements, separated by a comma(,)
	std::string to_string() {
		std::stringstream ss;
		char c = ',';
		ss << age << c << first_name << c << last_name << c << standard;
		return ss.str();
	}
};