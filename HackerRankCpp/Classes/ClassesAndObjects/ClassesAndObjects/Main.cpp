// Rachel Soderberg
// Hacker Rank Classes - Classes and Objects
// March 1st, 2018

// Description: Kristen is a contender for valedictorian of her high school. She wants to know how many
//				students (if any) have scored higher than her in the five exams given during this semester.

#include "Header.h"

int main() {
	int n; // number of students
	std::cin >> n;
	Student *s = new Student[n]; // an array of n students

	for (int i = 0; i < n; i++) {
		s[i].input();
	}

	// calculate kristen's score
	int kristen_score = s[0].calculateTotalScore();

	// determine how many students scored higher than kristen
	int count = 0;
	for (int i = 1; i < n; i++) {
		int total = s[i].calculateTotalScore();
		if (total > kristen_score) {
			count++;
		}
	}
	std::cout << count << "\n";

	system("pause");
	return 0;
}
