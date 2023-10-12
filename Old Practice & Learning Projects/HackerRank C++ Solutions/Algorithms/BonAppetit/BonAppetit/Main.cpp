// Rachel Soderberg
// Hacker Rank Algorithms - Bon Appetit
// April 15, 2018

// Description: Anna and Brian are sharing a meal at a restuarant and they agree to split the bill equally.
//				Brian wants to order something that Anna is allergic to though, and they agree that Anna
//				won't pay for that item. Brian gets the check and calculates Anna's portion. You must determine
//				whether his calculation is correct.

#include "Header.h"

int main() {
	int n = 0, k = 0; // Number of items ordered, item # Anna didn't eat (zero-start)
	int actual = 0; // Bill, minus Anna's uneaten item, divided by two
	int charged = 0, diff = 0; // Brian's calculated total, difference if not correct

	std::cin >> n >> k;

	// Take in item costs and store in array
	for (int i = 0; i < n; i++) {
		int temp = 0, discard = 0;;

		if (i == k) { // Discard value of the item Anna won't eat
			std::cin >> discard;
		}
		else { // Total the values of the rest of the items
			std::cin >> temp;
			actual += temp;
		}
	}

	actual = actual / 2; // Calculate the actual cost of the split total minus Anna's uneaten item

	std::cin >> charged;

	if (actual == charged) // Brian's calculation was correct
		std::cout << "Bon Appetit\n";
	else { // Brian overcharged Anna
		diff = charged - actual;
		std::cout << diff << "\n";
	}

	system("pause");
	return 0;
}