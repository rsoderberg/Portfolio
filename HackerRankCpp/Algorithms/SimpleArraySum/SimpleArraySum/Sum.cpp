// Rachel Soderberg
// Hacker Rank Algorithms - Simple Array Sum
// March 1st, 2018

#include "Header.h"

int simpleArraySum(int n, std::vector <int> ar) {
	int sum = 0;
	for (int i = 0; i < ar.size(); i++) {
		sum = sum + ar[i];
	}
	return sum;
}