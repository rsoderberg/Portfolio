// Rachel Soderberg
// Hacker Rank STL - Vector-Erase
// March 31st, 2018

// Description: Print the size of the modified vector, then print the contents after deletion.

#include "Header.h"

int main() {
	int n = 0;
	int del = 0;
	int rangeStart = 0, rangeEnd = 0;
	std::cin >> n;

	std::vector<int> nums(n);

	for (int i = 0; i < n; i++) { // Fill vector
		int temp;
		std::cin >> temp;
		nums[i] = temp;
	}

	std::cin >> del;

	nums.erase(nums.begin() + (del - 1)); // Erase value at del position

	std::cin >> rangeStart >> rangeEnd;

	nums.erase(nums.begin() + (rangeStart - 1), nums.begin() + (rangeEnd - 1)); // Erase values in range

	std::cout << nums.size() << "\n";

	for (int x : nums)
		std::cout << x << " ";

	std::cout << "\n";

	system("pause");
	return 0;
}
