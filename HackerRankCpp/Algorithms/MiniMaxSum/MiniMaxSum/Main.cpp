// Rachel Soderberg
// Hacker Rank Algorithms - Mini-Max Sum
// March 8th, 2018

// Description: Given five positive integers, find the minimum and maximum values that
//				can be calculated by summing exactly four of the five integers. Print
//				the respective minimum and maximum values as a single line of two
//				space-separated long integers.

#include "Header.h"

int main() {
	std::vector<unsigned long int> nums(5);
	unsigned long int minSum = ULONG_MAX; // Maximum value for an object of type unsigned long long int
	unsigned long int maxSum = 0;
	unsigned long int totalSum = 0;

	// Input to vector
	for (int i = 0; i < 5; i++) {
		std::cin >> nums[i];

		totalSum += nums[i];
		// Find min and max sums
		minSum = std::min(minSum, nums[i]);
		maxSum = std::max(maxSum, nums[i]);
	}

	std::cout << totalSum - maxSum << " " << totalSum - minSum << "\n"; // Output: minSum maxSum

	system("pause");
	return 0;
}
