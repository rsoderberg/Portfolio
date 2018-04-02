// Rachel Soderberg
// Hacker Rank Strings - Strings
// February 28th, 2018

// Description: Take two strings and print several things using string manipulation:
//				Print two space-separated integers, representing the length of a and b respectively.
//				Print the string produced by concatenating a and b (a + b).
//				Print two strings separated by a space, a' and b'. a' and b' are the same as a and b, respectively,
//					except their first characters are swapped.

#include "Header.h"

int main() {
	std::string a, b;
	int aCount = 0, bCount = 0;
	unsigned int j = 0, k = 0;

	std::cin >> a >> b;

	for (unsigned int i = 0; i < a.size(); i++) {
		++aCount;
	}
	for (unsigned int i = 0; i < b.size(); i++) {
		++bCount;
	}

	std::cout << aCount << " " << bCount << "\n";
	std::cout << a + b << "\n";

	std::cout << b[0];
	while (j < a.size() - 1) {
		std::cout << a[j + 1];
		j++;
	}

	std::cout << " " << a[0];
	while (k < b.size() - 1) {
		std::cout << b[k + 1];
		k++;
	}

	std::cout << "\n";

	system("pause");
	return 0;
}
