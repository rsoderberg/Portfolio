// Rachel Soderberg
// Hacker Rank Algorithms - Birthday Cake Candles
// March 11th, 2018

// Description: Colleen is having a birthday! She will have a cake with one candle for each year
//				of her age. When she blows out the candles, she’ll only be able to blow out the
//				tallest ones.
//				Find and print the number of candles she can successfully blow out.

#include "Header.h"

// Only the tallest candles can be blown out.

// Input: First line number of candles, n. Second line candle heights as space-separated integers.
// Output: Print the number of candles that can be blown out.

int main() {
	int n = 0; // Number of candles
	int tallest = 0, blowable = 0; // Height value of tallest candle, total blowable candles

	std::cin.ignore(); // Ignore n input in comparison
	while (std::cin >> n) { // While there are candle values to take in
	for (int i = 0; i < n; i++) {
		if (tallest < n) { // Tallest is greater than previous value, set tallest
			tallest = n;
			blowable = 1;
		}
		else {
			if (tallest == n) // Tallest is match, increment blowable
				blowable++;
		}
	}
	std::cout << blowable << "\n";

	system("pause");
	return 0;
}