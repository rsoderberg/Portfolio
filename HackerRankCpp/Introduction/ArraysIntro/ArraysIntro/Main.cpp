// Rachel Soderberg
// Hacker Rank Introduction - Arrays Introduction
// March 1st, 2018

// Description: Print the array of N integers in reverse order in a single line, followed by a space.

#include "Header.h"

int main() {
	int N = 0;
	int arr[1000];

	std::cin >> N;

	for (int i = 0; i < N; i++) {
		std::cin >> arr[i];
	}

	for (int i = N - 1; i >= 0; i--) {
		std::cout << arr[i] << " \n";
	}

	system("pause");
	return 0;
}
