// Rachel Soderberg
// Hacker Rank Introduction - Functions (Max of Four)
// December 21st, 2017

// Description: Print the greatest of four integers

#include "Header.h"

int main() {
	int a, b, c, d;
	std::cin >> a >> b >> c >> d;

	int ans = max_of_four(a, b, c, d);
	std::cout << ans << "\n";

	system("pause");
	return 0;
}
