// Rachel Soderberg
// Hacker Rank Introduction - Simple Array Sum
// March 3rd, 2018

// Description: Given an array of integers, find the sum of its elements.

#include "Header.h"

int main() {
	// For each pair of i and j values, print a single integer denoting the element located at index j of the array referenced by a[i].
	// There should be a total of q lines of output.

	// Perform the following two (q = 2) queries:
	// - Find the array located at index i = 0 which corresponds to a[0] = [1, 5, 4]. Print the value at index j = 1 of this array (j[1] = 5).
	// - Find the array located at index i = 1 which corresponds to a[1] = [1, 2, 8, 9, 3]. Print the value at index j = 3 of this array (j[3] = 9).
	int n = 0; // # of vectors
	int q = 0; // # of queries

	// First line of input: Two space-separated integers denoting the respective values of n and q.
	std::cin >> n >> q; // Take in first line of input

	// Second set of lines of input: Each line i of the n subsequent lines contains a space-separated sequence in the format
	// k a[i]0 a[i]1 … a[i]k-1 describing the k-element array located at a[i]. 
	// Create vector of n vectors
	std::vector<std::vector<int>> a(n);
	for (int i = 0; i < n; i++) {
		int k; // Array element k

		std::cin >> k; // Take in second set of inputs

		for (int j = 0; j < k; j++) {
			int data;
			std::cin >> data;
			a[i].push_back(data);
		}
	}

	// Third set of lines of input: Each of the q subsequent lines contains two space-separated integers describing the
	// respective values of i (an index in array a) and j(an index in the array referenced by a[i]) for a query.    
	for (int i = 0; i < q; i++) {
		int x, y; // "Coordinates" of queries in the array

		std::cin >> x >> y;
		std::cout << a[x][y] << "\n";
	}

	system("pause");
	return 0;
}
