// Multiplication Tables
// Rachel Soderberg
// December 6th, 2017

#include <iostream>
#include "Main.h"

using namespace std;

void practice() {
	int selection = 0;

	cout << "1. Table sets in numberical order\n"
		<< "2. Random multiplication problems\n"
		<< "Please choose which you would like to practice: ";
	cin >> selection;

	if (selection >= 1 && selection <= 2) {
		switch (selection) {
		case 1: tableSets();
			break;
		case 2: generateTables();
			break;
		}
	}
	else
		cout << "Invalid input\n";
}

void generateTables() {
	int x, y = 0;
	int max = 0;
	int numProblems = 0;
	int product = 0;
	int guess = 0;

	cout << "\nHow high would you like the randomizer to go? ";
	cin >> max;
	cout << "How many problems would you like to do? ";
	cin >> numProblems;

	for (int i = 0; i <= numProblems; i++) {
		// Generate random x and random y using max for top end limit, max + 1 to compensate for zero start point
		x = rand() % max + 1;
		y = rand() % max + 1;

		// Determine the correct answer to compare
		product = x * y;

		cout << "What is " << x << " x " << y << "? ";
		cin >> guess;

		if (guess == product)
			cout << "Good job, that's correct!\n\n";
		else
			cout << "Actually, the correct answer to " << x << " x " << y << " is " << product << endl << endl;
	}

	morePractice();
}

void tableSets() {
	int tableChoice = 0;
	int maxTable = 0;
	int product = 0;
	int guess = 0;

	cout << "\nWhich number multiplication table would you like to practice? ";
	cin >> tableChoice;
	cout << "How high would you like the tables to go? ";
	cin >> maxTable;

	for (int i = 0; i <= maxTable; i++) {
		// Determine correct answer to compare
		product = tableChoice * i;
		cout << tableChoice << " x " << i << " = ";
		cin >> guess;

		if (guess == product)
			cout << "Correct!\n\n";
		else
			cout << "Incorrect, " << tableChoice << " x " << i << " = " << product << endl << endl;
	}

	morePractice();
}

void morePractice() {
	char yn = ' ';

	cout << "Would you like to keep practicing?(y/n) ";
	cin >> yn;
	cout << endl;

	if (yn == 'y' || yn == 'Y')
		practice();
	else if (yn == 'n' || yn == 'N') {
		cout << "Come back soon!\n";
		exit;
	}
	else {
		cout << "Invalid input\n";
		morePractice();
	}
}