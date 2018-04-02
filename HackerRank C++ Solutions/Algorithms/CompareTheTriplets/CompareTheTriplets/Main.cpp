// Rachel Soderberg
// Hacker Rank Algorithms - Compare the Triplets
// March 1st, 2018

// Description: Print the respective comparison points earned by Alice and Bob

#include "Header.h"

int main() {
	// Print two space-separated integers denoting the respective comparison points earned by Alice and Bob
	// Comparison points are the total points a person earned
	// If Ai > Bi, Alice receives 1 pt
	// If Ai < Bi, Bob receives 1 pt
	// If Ai == Bi, nobody receives a point
	std::vector <int> aliceComp(3);
	std::vector <int> bobComp(3);
	int alicePoints = 0;
	int bobPoints = 0;

	for (int i = 0; i < 3; i++) {
		std::cin >> aliceComp[i];
	}
	for (int i = 0; i < 3; i++) {
		std::cin >> bobComp[i];
	}

	for (int i = 0; i < 3; i++) {
		if (aliceComp[i] > bobComp[i]) alicePoints++;
		if (aliceComp[i] < bobComp[i]) bobPoints++;
	}
	std::cout << alicePoints << " " << bobPoints << "\n";

	system("pause");
	return 0;
}