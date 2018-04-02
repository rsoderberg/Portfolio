#pragma once
#include "Prototypes.h"

class Coin {
	int heads = 0, tails = 0; // Number of heads and tails
	std::string result;

public:
	void set_values(int, int, std::string);
	const int get_heads() { return heads; }
	const int get_tails() { return tails; }
	const std::string get_result() { return result; }
};