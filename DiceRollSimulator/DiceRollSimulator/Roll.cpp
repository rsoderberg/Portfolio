// Program: Dice Roll Simulator
// Author: Rachel Soderberg
// Date Created: April 2, 2018
// Latest Edit: April 2, 2018

#include "Prototypes.h"
#include "Dice.h"

void diceRoll(int numDice) {
	int toss = 0; // Randomly generated coin toss, values 0 - 5 for 1 - 6 on the dice
	int one = 0, two = 0, three = 0, four = 0, five = 0, six = 0; // Dice sides incrementer
	char input = 'y'; // User input to continue rolling

	Dice newDie;

	while (input == 'y') {
		std::cout << "\nYou rolled: ";

		for (int i = 0; i < numDice; i++) { // Loop for potentially several dice
			toss = rand() % 6; // randomly generate a side for one die

			switch (toss) {
			case 0 :
				++one;
				std::cout << "One ";
				break;
			case 1 :
				++two;
				std::cout << "Two ";
				break;
			case 2 :
				++three;
				std::cout << "Three ";
				break;
			case 3 :
				++four;
				std::cout << "Four ";
				break;
			case 4 :
				++five;
				std::cout << "Five ";
				break;
			case 5 :
				++six;
				std::cout << "Six ";
				break;
			default:
				std::cout << "Error\n";
				break;
			}
			
			// Determine which side has been rolled the most
			if (one > two && one > three && one > four && one > five && one > six)
				newDie.set_values(one, two, three, four, five, six, "One");
			else if (two > one && two > three && two > four && two > five && two > six)
				newDie.set_values(one, two, three, four, five, six, "Two");
			else if (three > one && three > two && three > four && three > five && three > six)
				newDie.set_values(one, two, three, four, five, six, "Three");
			else if (four > one && four > two && four > three && four > five && four > six)
				newDie.set_values(one, two, three, four, five, six, "Four");
			else if (five > one && five > two && five > three && five > four && five > six)
				newDie.set_values(one, two, three, four, five, six, "Five");
			else if (six > one && six > two && six > three && six > four && six > five)
				newDie.set_values(one, two, three, four, five, six, "Six");

		}
		std::cout << "\n\nWould you like to roll the dice again? (y/n): ";
		std::cin >> input;

		if (input == 'n') {
			std::cout << "1s: " << newDie.get_ones() << "\n";
			std::cout << "2s: " << newDie.get_twos() << "\n";
			std::cout << "3s: " << newDie.get_threes() << "\n";
			std::cout << "4s: " << newDie.get_fours() << "\n";
			std::cout << "5s: " << newDie.get_fives() << "\n";
			std::cout << "6s: " << newDie.get_sixes() << "\n";
			std::cout << "The side rolled most was: " << newDie.get_result() << "\n";

			std::cout << "\nThank you for playing!\n\n";
		}
	}
}

void Dice::set_values(int tempOnes, int tempTwos, int tempThrees, int tempFours, int tempFives, int tempSixes, std::string tempResult) {
	ones = tempOnes;
	twos = tempTwos;
	threes = tempThrees;
	fours = tempFours;
	fives = tempFives;
	sixes = tempSixes;
	result = tempResult;
}