// Rachel Soderberg
// Hacker Rank Algorithms - Staircase
// March 7th, 2018

// Description: Print right-aligned staircase composed of # symbols and spaces with a height and width of n

#include "Header.h"

int main() {
	int n = 0; // Height and width of staircase
	int nCount = 0, rowCount = 0; // Counts for iteration
	int w = 0; // Width of row, for formatting purposes

	std::cin >> n;
	rowCount = 1; // Output starts with one step
	w = n;

	// ncount 6, rowcount 1
	// ncount 5, rowcount 2
	// ncount 4, rowcount 3
	// ncount 3, rowcount 4
	// ncount 2, rowcount 5
	// ncount 1, rowcount 6

	while (nCount < n) { // Create rows until n is reached
		std::cout.width(w); // Format width of the staircase, decreasing as nCount increases
		for (int i = 0; i < rowCount; i++) {
			std::cout << "#";
		}
		w--;
		rowCount++;
		nCount++;
		std::cout << "\n";
	}

	system("pause");
	return 0;
}
