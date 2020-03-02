// Rachel Soderberg
// Hacker Rank Introduction - Conditional Statements
// December 21st, 2017

// Description: Given a positive integer denoting n, do the following:
//				If 1 <= n <= 9, print the lowercase English word corresponding to the number.
//				If n > 9, print "Greater than 9".

#include "Header.h"

using namespace std;

int main() {
	int n = 0;
	cin >> n;

	if (n >= 1 && n <= 9) {
		switch (n) {
		case 1: cout << "one" << endl;
			break;
		case 2: cout << "two" << endl;
			break;
		case 3: cout << "three" << endl;
			break;
		case 4: cout << "four" << endl;
			break;
		case 5: cout << "five" << endl;
			break;
		case 6: cout << "six" << endl;
			break;
		case 7: cout << "seven" << endl;
			break;
		case 8: cout << "eight" << endl;
			break;
		case 9: cout << "nine" << endl;
			break;
		}
	}
	else
		cout << "Greater than 9" << endl;

	return 0;
}
