#pragma once

#include "Header.h"
#include "Rectangle.h"

// read_input() method: read the values of width and height.
class RectangleArea : public Rectangle {
public:
	void read_input() {
		std::cin >> width >> height;
	}
	void display() {
		std::cout << (width * height) << "\n";
	}
};
