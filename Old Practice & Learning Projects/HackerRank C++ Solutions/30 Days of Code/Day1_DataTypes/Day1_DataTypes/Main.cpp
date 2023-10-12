 Sum the integer in the first line with i,
//				sum the integer in the second line with d,
//				and concatenate the string in the third line with s.

#include "Header.h"

int main() {
	int i = 4;
	double d = 4.0;
	std::string s = "HackerRank ";

	// Declare second integer, double, and String variables.
	int j = 0;
	double e = 0.0;
	std::string t = " ";

	int sumIJ = 0;
	double sumDE = 0.0;

	// Read and save an integer, double, and String to your variables.
	std::cin >> j >> e;
	std::cin.ignore();
	getline(std::cin, t);

	// Print the sum of both integer variables on a new line.
	sumIJ = i + j;
	std::cout.precision(1);
	std::cout << std::fixed << sumIJ << "\n";

	// Print the sum of the double variables on a new line.
	sumDE = d + e;
	std::cout << sumDE << "\n";

	// Concatenate and print the String variables on a new line
	// The 's' variable above should be printed first.
	std::cout << s + t << "\n";

	system("pause");
	return 0;
}
