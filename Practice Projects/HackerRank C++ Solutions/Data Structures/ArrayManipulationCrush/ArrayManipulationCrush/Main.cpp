// Rachel Soderberg
// Hacker Rank Data Structures - Array Manipulation (Crush)
// March 25th, 2018

// Description: Print in a single line the maximum value in the updated list.

#include "Header.h"

using namespace std;

int main() {
	int n = 0, m = 0;
	std::cin >> n >> m;

	//long int list[n] = {}; // Segmentation error cases 7 - 13
	std::vector<long int> list(n); // Timeout error cases 7 - 13
	long int maxVal = 0;

	for (int i = 0; i < m; i++) {
		long int a = 0, b = 0, k = 0;
		std::cin >> a >> b >> k;
		list.push_back(a);
		list.push_back(b);
		list.push_back(k);

		for (int j = 0; j < n; j++) {
			if (j < a - 1 || j > b - 1) {
				list[j] = list[j];
			}
			else {
				list[j] += k;
			}
		}
	}

	for (int i = 0; i < n; i++) {
		maxVal = max(maxVal, list[i]);
	}

	std::cout << maxVal << "\n";

	system("pause");
	return 0;
}
