// Rachel Soderberg
// Hacker Rank STL - Sets-STL
// March 31st, 2018

// Description: x = 1: Add an element x to the set
//				x = 2: Delete an element x from the set (if number x is not present in the set, do nothing)
//				x = 3: If number x is present in the set, print "Yes", else print "No"

#include "Header.h"

int main() {
	int q = 0;
	std::cin >> q;

	std::set<int> queries;

	for (int i = 0; i < q; i++) {
		int y = 0, x = 0; // Type of query, integer
		std::cin >> y >> x;

		// x = 1: Add an element x to the set
		// x = 2: Delete an element x from the set (if number x is not present in the set, do nothing)
		// x = 3: If number x is present in the set, print "Yes", else print "No"

		switch (y) {
		case 1:
			queries.insert(x);
			break;
		case 2:
			queries.erase(x);
			break;
		case 3:
			std::cout << (queries.find(x) == queries.end() ? "No" : "Yes") << "\n";
			break;
		}
	}

	system("pause");
	return 0;
}