// Rachel Soderberg
// Hacker Rank Algorithms - Sock Merchant
// June 11th, 2018

// Description: John works at a clothing store. He has a large pile of socks that he must pair by
//              color for sale. You will be given an array of integers representing the color of
//              each sock. Determine how many pairs of socks with matching colors there are.

#include "Header.h"

// Input: First line number of socks, n. Second line socks in the pile as space-separated integers.
// Output: Print the number of matching pairs of socks that can be sold.

int main() {
	int n = 0, pairs = 0;
	std::vector<int> socks;

	std::cout << "Enter n value: ";
	std::cin >> n;

	for (int i = 0; i < n; i++) {
		int temp;
		std::cin >> temp;
		socks.push_back(temp);
	}

	sort(socks.begin(), socks.end());

	for (int i = 0; i < n - 1; i++) {
		if (socks[i] == socks[i + 1]) {
			pairs++;
			i++; // Skip next value
		}
	}
	std::cout << pairs << "\n";

	system("pause");
	return 0;
}