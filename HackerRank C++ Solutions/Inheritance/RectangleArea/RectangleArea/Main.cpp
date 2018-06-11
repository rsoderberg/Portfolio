// Rachel Soderberg
// Hacker Rank Inheritance - Rectangle Area
//June 11th, 2018

// Description: Create a Rectangle and RectangleArea class and print the width and height of the rectangle, then print the area of the rectangle.

#include "RectangleArea.h"

int main() {
	RectangleArea r_area;

	r_area.read_input();

	r_area.Rectangle::display();
	r_area.display();

	return 0;
}