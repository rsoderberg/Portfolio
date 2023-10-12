// Rachel Soderberg
// Hacker Rank Data Structures - Arrays-DS
// March 6th, 2018

// Description: Print each element in reverse order as a single line of space-separated integers.

#include "Header.h"

int main() {
	int n;
	std::cin >> n;
	std::vector<int> arr(n);
	for (int arr_i = 0; arr_i < n; arr_i++) {
		std::cin >> arr[arr_i];
	}

	for (int i = n - 1; i >= 0; i--)
		std::cout << arr[i] << " ";

	system("pause");
	return 0;
}

