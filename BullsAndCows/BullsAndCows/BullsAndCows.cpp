// Name: Bulls and Cows Game
// Programmer: Rachel Soderberg
// Date Created: December 30, 2017
// Latest Edit: December 31, 2017

// Description: Play "Bulls and Cows," the computer will generate four different integers in
// the range of 0 to 9 (e.g., 1234 but not 1122) and it is the player's task to correctly
// determine those numbers through repeated guesses. If the numbers to guess
// are 1234 and the user guesses 1359; the response will be "1 bull and 1 cow" because
// the user got one digit correct in the correct position (a bull), and one digit correct
// but in the wrong position (a cow). The guessing continues until the user gets four bulls,
// that is, has the four digits correct and in the correct order.

#include "Header.h"

void bullsAndCows() {
	srand((unsigned)time(NULL)); // Seed
	int bulls = 0;
	int cows = 0;
	int roundsCounter = 0; // Count the number of rounds it took to guess the numbers
	int randNum1 = 0; // Store randomized numbers
	int randNum2 = 0;
	int randNum3 = 0;
	int randNum4 = 0;
	int firstNum = 0; // Store user's guessed numbers
	int secondNum = 0;
	int thirdNum = 0;
	int fourthNum = 0;
	bool num1 = false; // Check whether the numbers have been compared to avoid double counting
	bool num2 = false;
	bool num3 = false;
	bool num4 = false;

	std::cout << "Welcome to Bulls and Cows!\n"
		<< "Enter your guesses as integers in the range 0 - 9 with each number separated by a space.\n"
		<< "As a reminder: Bulls are correct numbers in the correct position and cows are correct numbers\n"
		<< "but in the wrong position. Have fun!\n\n";

	// Generate four numbers from 0 to 9
	randNum1 = rand() % 10;
	randNum2 = rand() % 10;
	randNum3 = rand() % 10;
	randNum4 = rand() % 10;

	// If the number is already taken, attempt to generate a unique new one. Loop until all numbers are unique
	while (randNum2 == randNum1 || randNum3 == randNum1 || randNum4 == randNum1 || randNum3 == randNum2 || randNum4 == randNum2 || randNum4 == randNum3) {
		if (randNum2 == randNum1) {
			randNum2 = rand() % 10;
		}
		else if (randNum3 == randNum1 || randNum3 == randNum2) {
			randNum3 = rand() % 10;
		}
		else if (randNum4 == randNum1 || randNum4 == randNum2 || randNum4 == randNum3) {
			randNum4 = rand() % 10;
		}
	}

	while (bulls != 4 && std::cin.good()) { // Win condition, four bulls required
		std::cout << "My number is four unique numbers in the range of 0 to 9... What is your guess?: ";
		std::cin >> firstNum >> secondNum >> thirdNum >> fourthNum;

		// Error handling, need to catch bad inputs like letters
		if (std::cin.fail()) {
			std::cout << "Invalid input\n";
		}
		else {

			// Check for bulls
			for (int i = 0; i < 4; i++) {
				if (firstNum == randNum1 && num1 != true) {
					num1 = true;
					++bulls;
				}
				else if (secondNum == randNum2 && num2 != true) {
					num2 = true;
					++bulls;
				}
				else if (thirdNum == randNum3 && num3 != true) {
					num3 = true;
					++bulls;
				}
				else if (fourthNum == randNum4 && num4 != true) {
					num4 = true;
					++bulls;
				}
			}
			// Check for cows
			if (firstNum == randNum2 || firstNum == randNum3 || firstNum == randNum4 && num1 != true) {
				num1 = true;
				++cows;
			}
			else if (secondNum == randNum1 || secondNum == randNum3 || secondNum == randNum4 && num2 != true) {
				num2 = true;
				++cows;
			}
			else if (thirdNum == randNum1 || thirdNum == randNum2 || thirdNum == randNum4 && num3 != true) {
				num3 = true;
				++cows;
			}
			else if (fourthNum == randNum1 || fourthNum == randNum2 || fourthNum == randNum3 && num4 != true) {
				num4 = true;
				++cows;
			}

			if (bulls != 4) { // Checking for win condition
				std::cout << "You haven't won yet, keep guessing...\n"
					<< "Bulls: " << bulls << " Cows: " << cows << "\n";

				// Reset all the checks each round
				bulls = 0;
				cows = 0;
				firstNum = 0;
				secondNum = 0;
				thirdNum = 0;
				fourthNum = 0;
				num1 = false;
				num2 = false;
				num3 = false;
				num4 = false;

				++roundsCounter;
			}
		}
		if (bulls == 4 && std::cin.good()) {
			std::cout << "\nYou won! It took you " << roundsCounter << " rounds to guess the numbers.\n";
			playAgain(); // Loop the game
		}
	}
	std::cin.clear();
	std::cin.ignore();
	std::cout << "\nPlease, only enter integer values. Try back again soon!\n\n";
}

void playAgain() {
	char choice;

	std::cout << "\nWould you like to play again? (y/n): ";
	std::cin >> choice;

	if (choice == 'y' || choice == 'Y') { // User wants to play again
		system("CLS"); // Clear the console for the next game
		bullsAndCows();
	}
	else
		exit;
}