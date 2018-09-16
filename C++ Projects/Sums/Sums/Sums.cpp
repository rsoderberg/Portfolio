#include "Main.h"

using namespace std;

void sums() {
	int sum = 0, size = 0;
	vector<int> intArray;
	int pairs[2];

	cout << "Please enter the sum of pairs: ";
	cin >> sum;

	cout << "Now enter the size of the array: ";
	cin >> size;

	cout << "... and the set of numbers to check: ";
	for (int i = 0; i < size; i++) {
		int temp;
		cin >> temp;
		intArray.push_back(temp);
	}

	// Remove numbers larger than the sum
	for (int i = 0; i < intArray.size(); i++) {
		if (intArray[i] > sum) {
			intArray.erase(intArray.begin() + i);
			i--;
		}
	}

	// Filter duplicate numbers
	for (int i = 0; i < intArray.size() - 1; i++) {
			if (intArray[i] == intArray[i + 1]){
				intArray.erase(intArray.begin() + i);
			}
	}

	// Now use what's left to compare to sum, find pairs
	for (int i = 0; i < intArray.size(); i++) {
		for (int j = 1; j < intArray.size(); j++) {
			if (intArray[i] + intArray[j] == sum) { 
				pairs[0] = intArray[i];
				pairs[1] = intArray[j];

				cout << "(" << pairs[0] << ", " << pairs[1] << ")\n";

				// Remove pair values as you use them
				intArray.erase(intArray.begin() + i);
				intArray.erase(intArray.begin() + (j - 1));

				i--;
				j--;
			}
		}
	}
}