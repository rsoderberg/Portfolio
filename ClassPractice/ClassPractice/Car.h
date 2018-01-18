#pragma once
// Program: ClassPractice
// Author: Rachel Soderberg
// Date Created: January 18, 2018
// Latest Edit: January 18, 2018

// Description: Car class

#include <iostream>

class Car {
	std::string make, model, color = " ";
	int year, mileage = 0;

public:
	void set_values(std::string, std::string, int, int, std::string);
	const std::string get_make_model() { return make + " " + model; }
	const int get_year() { return year; }
	const int get_mileage() { return mileage; }
	const std::string get_color() { return color; }
};