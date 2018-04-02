// Rachel Soderberg
// Hacker Rank 30 Days of Code - Day 3: Introduction to Conditional Statements
// November 3rd, 2017

// Description: If N is even and in the inclusive range 2-5 print "Not Weird,"
//				if N is even and greater than 20 print "Not Weird,"
//				if N is even and in the inclusive range 6-20 print "Weird."

#include "Header.h"

int main() {
	int N;
	std::cin >> N;

	//If N is even and in the inclusive range of 2 to 5, print Not Weird
	//If N is even and greater than 20, print Not Weird
	//If N is even and in the inclusive range of 6 to 20, print Weird
	if (N % 2 == 0) {
		if (N >= 2 && N <= 5 || N > 20)
			std::cout << "Not Weird" << "\n";
		else if (N >= 6 && N <= 20)
			std::cout << "Weird" << "\n";
	}
	//If N is odd, print Weird
	else
		std::cout << "Weird" << "\n";

	system("pause");
	return 0;
}