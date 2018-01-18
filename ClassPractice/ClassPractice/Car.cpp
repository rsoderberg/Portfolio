// Program: ClassPractice
// Author: Rachel Soderberg
// Date Created: January 18, 2018
// Latest Edit: January 18, 2018

// Description: Car class

#include "Prototypes.h"
#include "Person.h"
#include "Car.h"

void createNewCarTest() {
	Car car1;
	Car car2;
	Car car3;

	car1.set_values("Toyota", "Camry", 2009, 12000, "black");
	car2.set_values("Ford", "Mustang", 1972, 27500, "red");
	car3.set_values("Dodge", "Ram", 2018, 800, "silver");

	std::cout << "1. " << car1.get_make_model() << " " << car1.get_year() << " " << car1.get_mileage() << " " << car1.get_color() << "\n";
	std::cout << "2. " << car2.get_make_model() << " " << car2.get_year() << " " << car2.get_mileage() << " " << car2.get_color() << "\n";
	std::cout << "3. " << car3.get_make_model() << " " << car3.get_year() << " " << car3.get_mileage() << " " << car3.get_color() << "\n";
}

void Car::set_values(std::string tempMake, std::string tempModel, int tempYear, int tempMileage, std::string tempColor) {
	make = tempMake;
	model = tempModel;
	year = tempYear;
	mileage = tempMileage;
	color = tempColor;
}