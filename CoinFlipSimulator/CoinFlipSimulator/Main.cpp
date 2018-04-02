// Program: Coin Flip Simulator
// Author: Rachel Soderberg
// Date Created: April 1, 2018
// Latest Edit: April 1, 2018

// Description: Simulate flipping a single coin however many times the user decides. Record the outcomes and count the number of tails and heads.

#include "Prototypes.h"

int main() {
	srand((unsigned)time(NULL));

	coinFlip();

	system("pause");
	return 0;
}