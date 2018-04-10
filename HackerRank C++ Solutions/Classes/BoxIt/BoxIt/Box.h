// Rachel Soderberg
// Hacker Rank Classes - Box It!
// April 10, 2018

#include "Header.h"

class Box {
	int l, b, h;
public:
	Box() { l = 0; b = 0; h = 0; }
	Box(int length, int breadth, int height) { l = length; b = breadth; h = height; }
	Box(const Box& B) { l = B.l; b = B.b; h = B.h; }

	int getLength() { return l; } // Box length
	int getBreadth() { return b; } // Box breadth (width)
	int getHeight() { return h; } // Box height
	long long CalculateVolume() { return (long long)l*b*h; } // Return volume of box
	// Overload operator <
	// Box A < Box B if:
	// - A.l < B.l
	// - A.b < B.b && A.l == B.l
	// - A.h < B.h && A.b == B.b && A.l == B.l
	friend bool operator<(Box &A, Box &B) {
		if (A.l < B.l || A.b < B.b && A.l == B.l || A.h < B.h && A.b == B.b && A.l == B.l)
			return true;
		else
			return false;
	};
	// Overload operator <<
	// If B is an object of class Box:
	// - cout << B should print B.l, B.b, and B.h on a single line separated by spaces
	friend std::ostream &operator<<(std::ostream &out, const Box &B) {
		out << B.l << " " << B.b << " " << B.h;
		return out;
	}
};