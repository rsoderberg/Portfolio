// Rachel Soderberg
// Hacker Rank Classes - Class
// March 1st, 2018

// Description: Create a class named Student representing the student's details and store the data of the student.
//				Create getter and setter functions for each element.  
//				Create another method to return the string consisting of all class elements separated by a comma.

#include "Header.h"

int main() {
	int age, standard;
	std::string first_name, last_name;

	std::cin >> age >> first_name >> last_name >> standard;

	Student st;
	st.set_age(age);
	st.set_standard(standard);
	st.set_first_name(first_name);
	st.set_last_name(last_name);

	std::cout << st.get_age() << "\n";
	std::cout << st.get_last_name() << ", " << st.get_first_name() << "\n";
	std::cout << st.get_standard() << "\n";
	std::cout << "\n";
	std::cout << st.to_string();

	std::cout << "\n";

	system("pause");
	return 0;
}
