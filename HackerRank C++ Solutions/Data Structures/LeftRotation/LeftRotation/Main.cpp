// Rachel Soderberg
// Hacker Rank Data Structures - Left Rotation
// March 24th, 2018

// Description: Perform n left rotations on a dynamic array

#include "Header.h"

int main() {
	int n = 0, d = 0; // #of integers, # of rotations
	int num = 0;
	std::vector<int> elements(n); // Original array
	std::vector<int> rotated(n); // Rotated array

	std::cin >> n >> d;

	for (int i = 0; i < n; i++) {
		std::cin >> num;
		elements.push_back(num);
	}

	int iter = d; // Start iterating from d

	while (rotated.size() != elements.size()) {
		if (iter == d) {
			rotated.push_back(elements[d]); // d element
			iter++;
		}
		else if (iter > d && iter < n) {
			rotated.push_back(elements[iter]); // (d + 1) to (n - 1) elements
			iter++;
		}
		else if (iter == n) { // When iter reaches the end of the array
			iter = 0;
		}
		else if (iter >= 0 && iter < d) { // 0 to (d - 1) elements
			rotated.push_back(elements[(iter)]);
			iter++;
		}
	}

	/* Test output for original dynamic array
	for (int x : elements) {
		std::cout << x << " ";
	}
	*/

	for (int x : rotated) {
		std::cout << x << " ";
	}

	system("pause");
	return 0;
}