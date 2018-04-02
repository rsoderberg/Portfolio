// Program: Coin Flip Simulator
// Author: Rachel Soderberg
// Date Created: April 1, 2018
// Latest Edit: April 1, 2018

#include "Prototypes.h"
#include "Coin.h"

void coinFlip() {
	int flip = 0; // Randomly generated flip. 0 = H, 1 = T
	int h = 0, t = 0; // Heads and tails incrementers
	char input = 'y'; // User input to continue flipping

	Coin newCoin;

	while (input == 'y') {
		flip = rand() % 2; // randomly generate heads/tails

		if (flip == 0) {
			++h;
			std::cout << "Heads!\n";
		}
		else if (flip == 1) {
			++t;
			std::cout << "Tails!\n";
		}
		else
			std::cout << "Error\n";

		if (h > t)
			newCoin.set_values(h, t, "Heads");
		else if (t > h)
			newCoin.set_values(h, t, "Tails");

		std::cout << "Would you like to flip another coin? (y/n): ";
		std::cin >> input;
	}

	if (input == 'n') {
		std::cout << "Heads: " << newCoin.get_heads() << ", Tails: " << newCoin.get_tails() << ", Result: " << newCoin.get_result() << "\n";
	}
	else if (input != 'y' && input != 'n') {
		std::cout << "Invalid input. Starting a fresh game...\n\n";
		coinFlip();
	}
}

void Coin::set_values(int tempHeads, int tempTails, std::string tempResult) {
	heads = tempHeads;
	tails = tempTails;
	result = tempResult;
}