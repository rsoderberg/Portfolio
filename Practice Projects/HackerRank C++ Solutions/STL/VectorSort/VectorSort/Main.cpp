// Rachel Soderberg
// Hacker Rank STL - Vector-Sort
// March 30th, 2018

// Description: Sort n integers and print the result

#include "Header.h"

int main() {
	int n = 0;
	std::cin >> n;

	std::vector<int> nums(n);

	for (int i = 0; i < n; i++) {
		int temp;
		std::cin >> temp;
		//nums.push_back(temp); // Grow vector from 0
		nums[i] = temp; // Insert to vector size n
	}

	sort(nums.begin(), nums.end());

	for (int x : nums)
		std::cout << x << " ";

	std::cout << "\n";

	system("pause");
	return 0;
}
