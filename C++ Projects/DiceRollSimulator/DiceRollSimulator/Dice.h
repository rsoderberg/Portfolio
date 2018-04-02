#pragma once
#include "Prototypes.h"

class Dice {
	int ones = 0, twos = 0, threes = 0, fours = 0, fives = 0, sixes = 0;
	std::string result;

public:
	void set_values(int, int, int, int, int, int, std::string);
	const int get_ones() { return ones; }
	const int get_twos() { return twos; }
	const int get_threes() { return threes; }
	const int get_fours() { return fours; }
	const int get_fives() { return fives; }
	const int get_sixes() { return sixes; }
	const std::string get_result() { return result; }
};