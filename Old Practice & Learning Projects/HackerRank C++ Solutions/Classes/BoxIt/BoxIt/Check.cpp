// Rachel Soderberg
// Hacker Rank Classes - Box It!
// April 10, 2018

#include "Header.h"
#include "Box.h"

void check2() {
	int n;
	std::cin >> n;
	Box temp;
	for (int i = 0; i<n; i++) {
		int type;
		std::cin >> type;
		if (type == 1)
			std::cout << temp << "\n";
		if (type == 2) {
			int l, b, h;
			std::cin >> l >> b >> h;
			Box NewBox(l, b, h);
			temp = NewBox;
			std::cout << temp << "\n";
		}
		if (type == 3) {
			int l, b, h;
			std::cin >> l >> b >> h;
			Box NewBox(l, b, h);
			if (NewBox<temp)
				std::cout << "Lesser\n";
			else
				std::cout << "Greater\n";
		}
		if (type == 4) {
			std::cout << temp.CalculateVolume() << "\n";
		}
		if (type == 5) {
			Box NewBox(temp);
			std::cout << NewBox << "\n";
		}
	}
}