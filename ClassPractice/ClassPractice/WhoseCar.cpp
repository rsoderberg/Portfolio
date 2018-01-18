// Program: ClassPractice
// Author: Rachel Soderberg
// Date Created: January 18, 2018
// Latest Edit: January 18, 2018

// Description: Combine Person and Car classes

#include "Prototypes.h"
#include "Person.h"
#include "Car.h"

void createPersonCar() {
	Person person1;
	Person person2;
	Person person3;

	Car car1;
	Car car2;
	Car car3;

	person1.set_values("Cliff", "Cliffton", 40, 'm');
	person2.set_values("Bob", "Ross", 53, 'm');
	person3.set_values("Jill", "Jilly", 11, 'f');

	car1.set_values("Toyota", "Camry", 2009, 12000, "black");
	car2.set_values("Ford", "Mustang", 1972, 27500, "red");
	car3.set_values("Dodge", "Ram", 2018, 800, "silver");

	std::cout << person1.get_name() << ", age " << person1.get_age() << ", has the " << car1.get_color() << " " << car1.get_year() << " "
		<< car1.get_make_model() << ". It currently has " << car1.get_mileage() << " miles on it.\n";
	std::cout << person2.get_name() << ", age " << person2.get_age() << ", has the " << car3.get_color() << " " << car3.get_year() << " "
		<< car3.get_make_model() << ". It currently has " << car3.get_mileage() << " miles on it.\n";
	std::cout << person3.get_name() << ", age " << person3.get_age() << ", has the " << car2.get_color() << " " << car2.get_year() << " "
		<< car2.get_make_model() << ". It currently has " << car2.get_mileage() << " miles on it.\n\n";

}