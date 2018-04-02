// Rachel Soderberg
// Hacker Rank 30 Days of Code - Day 2: Operators
// November 2nd, 2017

// Description: Print the total cost of a meal.

#include "Header.h"

int main() {
	double mealCost = 0.00;
	int tipPercent = 0;
	int taxPercent = 0;
	int totalCost = 0;

	std::cin >> mealCost >> tipPercent >> taxPercent;

	tipPercent = (round)(mealCost * (double)tipPercent / 100);
	taxPercent = (round)(mealCost * (double)taxPercent / 100);

	totalCost = mealCost + tipPercent + taxPercent;

	std::cout << "The total meal cost is " << totalCost << " dollars.\n";

	system("pause");
	return 0;
}