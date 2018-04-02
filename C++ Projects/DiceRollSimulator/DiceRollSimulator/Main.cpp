// Program: Dice Roll Simulator
// Author: Rachel Soderberg
// Date Created: April 2, 2018
// Latest Edit: April 2, 2018

// Description: Simulate one or more dice however many times the user decides. Record the outcomes and count the number of each side rolled.

#include "Prototypes.h"

int main() {
	srand((unsigned)time(NULL));

	gamePlay();

	system("pause");
	return 0;
}