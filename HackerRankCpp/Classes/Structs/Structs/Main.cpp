// Rachel Soderberg
// Hacker Rank Classes - Structs
// March 1st, 2018

// Description: Create a struct named Student representing the student's details and store the data of the student.

#include "Header.h"

int main() {
	Student st;

	std::cin >> st.age >> st.first_name >> st.last_name >> st.standard;
	std::cout << st.age << " " << st.first_name << " " << st.last_name << " " << st.standard;

	system("pause");
	return 0;
}