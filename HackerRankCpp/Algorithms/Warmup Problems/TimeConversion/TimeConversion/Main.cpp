// Rachel Soderberg
// Hacker Rank Algorithms - Time Conversion
// March 13th, 2018

// Description: Given a time in 12-hour AM/PM format, convert it to military (24-hour) time.
//				Note: Midnight is 12:00:00AM on a 12-hour clock, and 00:00:00 on a 24-hour clock.
//					  Noon is 12:00:00PM on a 12-hour clock, and 12:00:00 on a 24-hour clock.

#include "Header.h"

// Convert from 12-hour clock format to 24-hour format
int main() {
	int hours, minutes, seconds; // hh, mm, ss
	char ch;
	char amPm;

	std::cin >> hours >> ch >> minutes >> ch >> seconds >> amPm >> ch; // Read in time

	if (amPm == 'A') {
		if (hours == 12)
			hours = 0; // Midnight
		else
			hours = hours; // 01-11
	}
	else if (amPm == 'P') {
		if (hours == 12)
			hours = 12; // Noon
		else
			hours = hours + 12; // 13-23
	}

	std::cout << std::setw(2) << std::setfill('0') << hours << ":"
		<< std::setw(2) << std::setfill('0') << minutes << ":"
		<< std::setw(2) << std::setfill('0') << seconds << "\n";

	system("pause");
	return 0;
}
