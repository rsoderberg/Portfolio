// Rachel Soderberg
// Hacker Rank Algorithms - Grading Students
// March 19th, 2018

#include "Header.h"

std::vector<int> gradingStudents(std::vector<int> grades) {
	std::vector<int> result;

	for (int x : grades) {
		int fives = 40; // Lowest possible rounded score

		if (x < 100 && x > 37) { // 40 - 100 is passing, consider rounding
								 // Find closest multiple of 5 greater than x and round if difference is less than 3
			for (int i = 0; i < 12; i++) {
				while (fives < x && fives < 100)
					fives += 5;
			}
			if ((fives - x) < 3) { // Round up if difference is less than three
				result.push_back(fives);
			}
			else
				result.push_back(x);
		}
		else
			result.push_back(x);
	}

	return result;
}