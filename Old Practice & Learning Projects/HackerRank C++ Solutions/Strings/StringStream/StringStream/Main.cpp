// Rachel Soderberg
// Hacker Rank Strings - StringStream
// March 14th, 2018

// Description: Print integers after parsing and removing comma delimiters.

#include "Header.h"

int main() {
	std::string str;
	std::cin >> str;

	std::vector<int> integers = parseInts(str);
	for (int i = 0; i < integers.size(); i++) {
		std::cout << integers[i] << "\n";
	}

	system("pause");
	return 0;
}
