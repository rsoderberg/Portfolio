// Program: String Comparison
// Author: Rachel Soderberg
// Date Created: April 5, 2018
// Latest Edit: April 6, 2018

// Description: Compare two strings without using any standard libraries

#include <iostream> // Used only for test outputs

void stringComp(char *stringOne, char *stringTwo) {
	char arrayOne[100];
	char arrayTwo[100];

	if (strlen(stringOne) == strlen(stringTwo)) { // Strings must be the same size to match
		for (int i = 0; i < strlen(stringOne); i++) {
			arrayOne[i] = *(stringOne + i); // Add chars to arrays
			arrayTwo[i] = *(stringTwo + i);

			if (arrayOne[i] == arrayTwo[i]) {
				// Intentially left blank, the strings match
			}
			else {
				std::cout << "No match\n";
			}
		}
		std::cout << "Match\n";
	}
	else {
		std::cout << "No match\n";
	}
}


int main() {
	char wordOne[6] = { 'w', 'h', 'e', 'r', 'e', '\0' };
	char wordTwo[6] = { 'w', 'h', 'e', 'r', 'e', '\0' };
	char wordThree[5] = { 'w', 'h', 'e', 'n', '\0' };
	char wordFour[9] = { 'w', 'h', 'e', 'n', 'e', 'v', 'e', 'r', '\o' };
	char wordFive[5] = { 'w', 'h', 'e', 'n', '\0' };

	stringComp(wordOne, wordTwo); // Match
	stringComp(wordTwo, wordThree); // No Match
	stringComp(wordThree, wordFour); // No Match
	stringComp(wordThree, wordFive); // Match

	system("pause");
	return 0;
}