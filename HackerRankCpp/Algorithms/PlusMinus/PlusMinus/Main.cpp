// Rachel Soderberg
// Hacker Rank Algorithms - Plus-Minus
// March 1st, 2018

// Description: Given an array of integers, calculate the fractions of its elements that are positive, negative, and zero.  
//				Print the decimal value of each fraction on a new line.

#include "Header.h"

// Input (2 lines):
// - Size n of the array
// - N number of space-separated integers describing the array of numbers arr(a0, a1, ..., an).

// Output (3 lines):
// - A decimal representing of the fraction of positive numbers in the array compared to its size.
// - A decimal representing of the fraction of negative numbers in the array compared to its size.
// - A decimal representing of the fraction of zeros in the array compared to its size.

int main() {
	int n = 0;
	int posCount = 0, negCount = 0, zeroCount = 0; // Count of zeros, positive numbers, and negative numbers in the array  
	double posFract = 0, negFract = 0, zeroFract = 0; // Decimal representation of zero, positive, and negative numbers in array

	std::cin >> n;

	std::vector<int> arr(n);
	for (int i = 0; i < n; i++) {
		std::cin >> arr[i];

		// Get each type count
		if (arr[i] > 0)
			++posCount;
		else if (arr[i] < 0)
			++negCount;
		else if (arr[i] == 0)
			++zeroCount;
		else
			std::cout << "Error!" << "\n";
	}

	// Find decimal representations and cast to double (count / n)
	posFract = ((double)posCount / n);
	negFract = ((double)negCount / n);
	zeroFract = ((double)zeroCount / n);

	std::cout << std::setprecision(6) << posFract << '\n';
	std::cout << std::setprecision(6) << negFract << '\n';
	std::cout << std::setprecision(6) << zeroFract << '\n';

	system("pause");
	return 0;
}
