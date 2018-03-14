// Rachel Soderberg
// Hacker Rank Algorithms - Simple Array Sum
// March 1st, 2018

// Description: Given an array of integers, find the sum of its elements.

#include "Header.h"

int main() {
	int n; // Size of array
	std::cin >> n;
	std::vector<int> ar(n);

	for (int ar_i = 0; ar_i < n; ar_i++) {
		std::cin >> ar[ar_i];
	}

	int result = simpleArraySum(n, ar);
	std::cout << result << "\n";

	system("pause");
	return 0;
}
