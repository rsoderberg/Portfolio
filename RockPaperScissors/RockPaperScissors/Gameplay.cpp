// Name: Rock Paper Scissors Game
// Programmer: Rachel Soderberg
// Date Created: January 6th, 2018
// Latest Edit: January 6th, 2018

// Plays the game "Rock, Paper, Scissors," the computer will give random answers for the
// user to attempt to beat. Player or computer will win after best two out of three.

#include "Main.h"

void rockPaperScissors() {
	srand((unsigned)time(NULL)); // Seed
	int computerMove = 0;
	int playerMove = 0;
	int playerScore = 0;
	int computerScore = 0;
	bool winner = false;

	while (winner == false) {
		computerMove = rand() % 3 + 1; // Randomize the computer's choice

		std::cout << "What is your move?\n"
			<< "1. Rock, 2. Paper, 3. Scissors: ";

		if (std::cin >> playerMove) {
			switch (playerMove) {
			case 1:
				if (computerMove == 2) {
					std::cout << "Paper covers rock!\n";
					++computerScore;
				}
				else if (computerMove == 3) {
					std::cout << "Rock smashes scissors!\n";
					++playerScore;
				}
				break;
			case 2:
				if (computerScore == 3) {
					std::cout << "Scissors cuts paper!\n";
					++computerScore;
				}
				else if (computerMove == 1) {
					std::cout << "Paper covers rock!\n";
					++playerScore;
				}
				break;
			case 3:
				if (computerMove == 1) {
					std::cout << "Rock smashes scissors!\n";
					++computerScore;
				}
				else if (computerMove == 2) {
					std::cout << "Scissors cuts paper!\n";
					++playerMove;
				}
				break;
			default: std::cout << "Invalid input\n";
				break;
			}

			std::cout << "\nYour score: " << playerScore << "\n";
			std::cout << "My score: " << computerScore << "\n\n";

			if (computerScore == 3) {
				std::cout << "I win!\n";
				winner = true;
			}
			else if (playerScore == 3) {
				std::cout << "You win!\n";
				winner = true;
			}
		}
		else if (!(std::cin >> playerMove)) // Handle bad input
		{
			std::cin.clear();
			std::cin.ignore();
			std::cout << "Incorrect entry. Try again...\n\n";
		}
	}
	playAgain();
}

void playAgain() {
	char choice;

	std::cout << "\nWould you like to play again? (y/n): ";
	std::cin >> choice;

	if (choice == 'y' || choice == 'Y') { // User wants to play again
		system("CLS"); // Clear the console for the next game
		rockPaperScissors();
	}
	else
		exit;
}