// Rachel Soderberg
// Hacker Rank Algorithms - Kangaroo
// March 21st, 2018

#include "Header.h"

std::string kangaroo(int x1, int v1, int x2, int v2) {
	bool meet = false;
	std::string result = " ";

	if (v2 >= v1 && x1 != x2)
		meet = false;
	else {
		float velocity = (float)(x2 - x1) / (v1 - v2);

		if (floor(velocity) == velocity)
			meet = true;
		else
			meet = false;
	}

	if (meet == true)
		result = "YES";
	else
		result = "NO";

	return result;
}