#pragma once

#include "Header.h"

// Two data fields: width and height of int types.
// display() method: print the width and height of the rectangle separated by space.
class Rectangle {
public:
	void display() {
		std::cout << width << " " << height << "\n";
	}
protected:
	int width = 0;
	int height = 0;
};