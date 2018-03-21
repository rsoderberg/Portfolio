// Rachel Soderberg
// Hacker Rank Introduction - Pointer
// December 21st, 2017

#include "Header.h"

void update(int *a, int *b) {
	*a = *a + *b;
	*b = abs((*a) - (*b) - *b);
}