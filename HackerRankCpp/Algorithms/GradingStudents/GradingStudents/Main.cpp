// Rachel Soderberg
// Hacker Rank Algorithms - Grading Students
// March 19th, 2018

// Description: For each grade i of n grades, print the rounded grade on a new line.
//				Only grades above 40 will be considered for rounding, and only when the difference from the next multiple
//				of five is less than three.

#include "Header.h"

int main()
{
	std::ofstream fout(getenv("OUTPUT_PATH"));

	int n;
	std::cin >> n;
	std::cin.ignore(std::numeric_limits<std::streamsize>::max(), '\n');

	std::vector<int> grades(n);

	for (int grades_itr = 0; grades_itr < n; grades_itr++) {
		int grades_item;
		std::cin >> grades_item;
		std::cin.ignore(std::numeric_limits<std::streamsize>::max(), '\n');

		grades[grades_itr] = grades_item;
	}

	std::vector<int> result = gradingStudents(grades);

	for (int result_itr = 0; result_itr < result.size(); result_itr++) {
		fout << result[result_itr];

		if (result_itr != result.size() - 1) {
			fout << "\n";
		}
	}

	fout << "\n";

	fout.close();

	system("pause");
	return 0;
}
