// Rachel Soderberg
// Hacker Rank Algorithms - Kangaroo
// March 21st, 2018

// Description: Given the starting locations and jump distances for each kangaroo,
//				determine if and when they will land at the same location at the same time. 

#include "Header.h"

int main() {
	int x1, v1, x2, v2;

	std::cin >> x1 >> v1 >> x2 >> v2;

	std::string result = kangaroo(x1, v1, x2, v2);
	std::cout << result << "\n";

	system("pause");
	return 0;
}
