// Rachel Soderberg
// Hacker Rank Introduction - Pointer
// December 21st, 2017

// Description: Print the updated values of a and b, on separate lines.

#include "Header.h"

int main() {
	int a, b;
	int *pa = &a, *pb = &b;

	std::cin >> a >> b;
	update(pa, pb);
	std::cout << a << "\n" << b << "\n";

	return 0;
}
