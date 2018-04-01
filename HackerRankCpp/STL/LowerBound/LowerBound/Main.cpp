// Rachel Soderberg
// Hacker Rank STL - Vector-Erase
// March 31st, 2018

// Description: Use lower bound to tell whether an integer is present in the array.
//				If not present, tell the index at which the smallest integer that is
//				just greater than the given number is present.

#include "Header.h"

int main() {
	int n = 0, q = 0;
	std::cin >> n;

	std::vector<int> nums(n);

	for (int i = 0; i < n; i++) { // Fill numbers vector
		int temp;
		std::cin >> temp;
		nums[i] = temp;
	}

	sort(nums.begin(), nums.end()); // Sort vector

	std::cin >> q; // Number of queries to follow

	for (int i = 0; i < q; i++) { // Query comparisons
		int query;
		std::cin >> query;

		std::vector<int>::iterator low = lower_bound(nums.begin(), nums.end(), query);

		std::cout << (*low == query ? "Yes " : "No ") << low - nums.begin() + 1 << "\n"; // More succinctly...
		/*
		if (nums[low - nums.begin()] == query)
			// Print "Yes" and index
			std::cout << "Yes " << (low - nums.begin() + 1) << "\n";
		else
			// Print "No" and index of next smallest number just greater than this number
			std::cout << "No " << (low - nums.begin() + 1) << "\n";
		*/
	}
	system("pause");
	return 0;
}