#pragma once

// Program: The Grocery Store
// Author: Rachel Soderberg
// Date Created: April 14, 2018
// Latest Edit: April 14, 2018

// Description: Product class
// Product class must include: Name, Unit of Measure, Qty, Price

class Product {
	std::string Name;
	std::string Measure;
	double Price = 0.00;
	double Quantity = 0.00;

public:
	void set_values(std::string, std::string, double, double);
	void set_name(std::string);
	void set_measure(std::string);
	std::string get_name() { return Name; }
	std::string get_measure() { return Measure; }
	double get_price() { return Price; }
	double get_quantity() { return Quantity; }
};