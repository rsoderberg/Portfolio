// Rachel Soderberg
// Hacker Rank Algorithms - Diagonal Difference
// March 8th, 2018

#include "Header.h"

int diagonalDifference(std::vector<std::vector<int>> a) {
	int absDiff = 0; // Absolute difference between sums
	int rightSum = 0, leftSum = 0; // Sums in diagonally-right and left directions

	for (int i = 0; i < a.size(); i++) { // Rows
		for (int j = 0; j < a.size(); j++) { // Columns
			if (i == j) // 0,0 1,1 2,2 etc...
				rightSum += a[i][j];
			if (i + j == (a.size() - 1)) // 5,5 4,4 3,3 etc...
				leftSum += a[i][j];
		}
	}
	absDiff = abs(rightSum - leftSum);

	return absDiff;
}