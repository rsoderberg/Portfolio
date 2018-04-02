// Program: Dice Roll Simulator
// Author: Rachel Soderberg
// Date Created: April 2, 2018
// Latest Edit: April 2, 2018

// Description: Welcome message for program

#include "Prototypes.h"

int gamePlay() {
	int numDice = 0;

	std::cout << "Welcome to the Dice Rolling Simulator!";
	std::cout << "\n--------------------------------------\n\n";
	std::cout << "How many dice would you like to play with?: ";
	std::cin >> numDice;

	diceRoll(numDice);

	return numDice;
}



