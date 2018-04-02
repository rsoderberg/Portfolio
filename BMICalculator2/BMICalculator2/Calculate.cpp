// Project: Body Mass Index (BMI) Calculator
// Author: Rachel Soderberg
// Date Created: April 2, 2018
// Latest Edit: April 2, 2018

#include "Prototypes.h"

void userData() {
	int height = 0, weight = 0;

	std::cout << "Enter your height in inches: ";
	std::cin >> height;
	std::cout << "Enter your weight in pounds: ";
	std::cin >> weight;

	double bmi = calculate(height, weight);

	int roundBMI = (int)bmi; // Round the bmi value for under/normal/overweight status

	std::cout << "Your calculated BMI is: " << roundBMI << "\n";

	std::cout << "At this BMI, you are considered: ";
	if (bmi < 18.5)
		std::cout << "Underweight\n\n";
	else if (bmi >= 18.5 && bmi <= 24.9)
		std::cout << "Normal\n\n";
	else if (bmi > 25)
		std::cout << "Overweight\n\n";
	else
		std::cout << "Unidentified error\n\n";
}

int calculate(int height, int weight) {
	double bmi = 0;

	// Convert inputs to metric
	double heightMeters = height * 0.0254;
	double heightSquared = heightMeters * heightMeters;
	double weightKilograms = weight * 0.453592;

	// Metric BMI formula: Weight (kg) / (Height (m))².
	bmi = weightKilograms / heightSquared;

	return bmi;
}