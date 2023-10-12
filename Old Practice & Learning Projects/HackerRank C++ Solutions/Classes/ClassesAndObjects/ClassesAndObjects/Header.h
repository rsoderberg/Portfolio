#pragma once

#include <iostream>

class Student {
private:
	int scores[5]; // Hold a student's 5 exam scores
public:
	int sum = 0;
	// Read 5 integers and save them to scores
	void input() {
		for (int i = 0; i < 5; i++) {
			std::cin >> scores[i];
			sum += scores[i];
		}
	}
	// Return the sum of the values in scores
	int calculateTotalScore() { return sum; }
};
