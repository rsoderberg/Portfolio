// Rachel Soderberg
// Hacker Rank Algorithms - A Very Big Sum
// March 1st, 2018

#include "Header.h"

long long aVeryBigSum(int n, std::vector <long long> ar) {
	// Complete this function
	long long int sum = 0;

	for (int i = 0; i < n; i++)
		sum = sum + ar[i];

		return sum;
}