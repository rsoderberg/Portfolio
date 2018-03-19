// Rachel Soderberg
// Hacker Rank Algorithms - Diagonal Difference
// March 8th, 2018

// Description: Given a square matrix, calculate the absolute difference between the sums of its diagonals.

#include "Header.h"

int main() {
	int n;
	std::cin >> n;
	std::vector<std::vector<int>> a(n, std::vector<int>(n));
	for (int a_i = 0; a_i < n; a_i++) {
		for (int a_j = 0; a_j < n; a_j++) {
			std::cin >> a[a_i][a_j];
		}
	}

	int result = diagonalDifference(a);
	std::cout << result << "\n";

	system("pause");
	return 0;
}
