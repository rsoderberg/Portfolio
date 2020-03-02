// Name: Prime Numbers Calculator
// Programmer: Rachel Soderberg
// Date Created: January 8th, 2018
// Latest Edit: January 12th, 2018

// Description: Finds all prime numbers between 1 and the max value given by the user.

#include "Main.h"

void primeNumbers() {
	// Check if a number can be divided by a prime number smaller than itself using a vector of primes.
	// primes[0]==2, primes[1]==3, primes[2]==5, etc.
	std::vector<int> primes; // Store prime numbers
	int max = 0; // User's desired max
	int counter = 0; // Keep track of placement in vector, since i == 3

	std::cout << "What max would you like to count primes up to? Assume the first prime is 2: ";
	std::cin >> max;

	primes.push_back(2); // First prime assumed to be 2
	if (max == 0) {
		std::cout << "0 is an invalid input. Assume the first prime number is 2.\n\n";
		primeNumbers();
	}
	else if (max == 1) {
		std::cout << "1 is an invalid input. Assume the first prime number is 2.\n\n";
		primeNumbers();
	}
	else {
		for (int i = 3; i < max; i++) { // Find all primes from 3 to 100
			if (counter == 0) {
				// If the remainder of the number divided by 2 is not equal to zero, it is prime
				if (i % primes[0] != 0) {
					primes.push_back(i); // Add to vector
					counter++; // Increment as vector grows
				}
			}
			else if (counter == 1) {
				// If the remainder of the number divided by 2 and 3 is not equal to zero, it is prime
				if (i % primes[0] != 0 && i % primes[1] != 0) {
					primes.push_back(i);
					counter++;
				}
			}
			else if (counter > 1 && counter <= 2) {
				// If the remainder of the number divided by 2, 3, and 5 is not equal to zero, it is prime
				if (i % primes[0] != 0 && i % primes[1] != 0 && i % primes[2] != 0) {
					primes.push_back(i);
					counter++;
				}
			}
			else if (counter > 2) {
				// If the remainder of the number divided by 2, 3, 5, and 7 is not equal to zero, it is prime
				if (i % primes[0] != 0 && i % primes[1] != 0 && i % primes[2] != 0 && i % primes[3] != 0) {
					primes.push_back(i);
					counter++;
				}
			}
		}

		std::cout << "The prime numbers up to " << max << " are: "; // Print primes from vector
		for (int i = 0; i < primes.size(); i++) {
			std::cout << primes[i] << " ";
		}
		std::cout << "\n\n";
		primeNumbers();
	}
}