// Rachel Soderberg
// Hacker Rank Data Structures - 2D Arrays-DS
// March 16th, 2018

// Description: Print the maximum hourglass sum found in A

#include "Header.h"

// 6x6 array, print largest (maximum) hourglass sum found in A.
// i, j will not be less than 0 or greater than 5
// Each value in A will be in the inclusive range of -9 to 9.
// There will be 4 hourglasses per row and 4 per column for a total of 8.

int main() {
	int max = -64;

	std::vector<int> sums;
	sums.reserve(18);

	std::vector<std::vector<int>> arr(6, std::vector<int>(6));

	for (int i = 0; i < 6; i++) {
		for (int j = 0; j < 6; j++) {
			std::cin >> arr[i][j];
		}
	}

	// Push hourglasses to sums vector
	for (int j = 0; j < 4; j++) { // 4 per column
		for (int i = 0; i < 4; i++) { // 4 per row
			sums.push_back(arr[i][j] + arr[i][j + 1] + arr[i][j + 2] +
				arr[i + 1][j + 1] +
				arr[i + 2][j] + arr[i + 2][j + 1] + arr[i + 2][j + 2]);
		}
	}

	/*
	for (int x : sums){
		if (x > max)
			max = x;
	}
	cout << max;
	*/

	std::cout << *max_element(sums.begin(), sums.end()) << "\n"; // Dereference max_element to obtain the value of the max element

	return 0;
}
