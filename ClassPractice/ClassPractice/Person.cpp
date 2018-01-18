// Program: ClassPractice
// Author: Rachel Soderberg
// Date Created: January 18, 2018
// Latest Edit: January 18, 2018

// Description: Person class

#include "Prototypes.h"
#include "Person.h"

void createNewPersonTest() {
	Person person1;
	Person person2;
	Person person3;

	person1.set_values("Cliff", "Cliffton", 40, 'm');
	person2.set_values("Bob", "Ross", 53, 'm');
	person3.set_values("Jill", "Jilly", 11, 'f');
/*
	person1.set_name("Cliff", "Clifton");
	person1.set_age(40);
	person1.set_gender('m');

	person2.set_name("Bob", "Ross");
	person2.set_age(53);
	person2.set_gender('m');

	person3.set_name("Jill", "Jilly");
	person3.set_age(11);
	person3.set_gender('f');
*/

	std::cout << "1. " << person1.get_name() << " " << person1.get_age() << " " << person1.get_gender() << "\n";
	std::cout << "2. " << person2.get_name() << " " << person2.get_age() << " " << person2.get_gender() << "\n";
	std::cout << "3. " << person3.get_name() << " " << person3.get_age() << " " << person3.get_gender() << "\n";
}

void Person::set_values(std::string tempFirstName, std::string tempLastName, int tempAge, char tempGender) {
	firstName = tempFirstName;
	lastName = tempLastName;
	age = tempAge;
	gender = tempGender;
}

void Person::set_name(std::string tempFirstName, std::string tempLastName) {
	firstName = tempFirstName;
	lastName = tempLastName;
}

void Person::set_age(int tempAge) {
	age = tempAge;
}

void Person::set_gender(char tempGender) {
	gender = tempGender;
}