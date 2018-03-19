// Rachel Soderberg
// Hacker Rank Algorithms - A Very Big Sum
// March 4th, 2018

// Description: Calculate and print the sum of the elements in an array, keeping in mind that some of those integers may be quite large.

#include "Header.h"

int main() {
	int n;
		std::cin >> n;

		std::vector<long long> ar(n);

		for (int ar_i = 0; ar_i < n; ar_i++) {
			std::cin >> ar[ar_i];
		}

	long long result = aVeryBigSum(n, ar);
	std::cout << result << "\n";

	system("pause");
	return 0;
}
