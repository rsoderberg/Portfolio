// Name: Quadratic Equation Solver
// Programmer: Rachel Soderberg
// Date Created: January 6th, 2018
// Latest Edit: January 6th, 2018

// Description: 
// Quadratic equations are of the form:
//          a * x^2 + b * x + c = 0
// To solve these, one uses the quadratic formula:
//          x = (-b +/- sqrt(b^2 - 4ac)) / 2a
// There is a problem, though: if b^2 - 4ac is less than zero, then it will fail.
// - Write a program that can calculate x for a quadratic equation.
// - Create a function that prints out the roots of a quadratic equation, given a, b, c.
// - When the program detects an equation with no real roots, have it print out a message.
// Roots are exactly the x-intercepts of the quadratic function f(x) = a * x^2 + b * x + c = 0,
// that is the intersection between the graph of the quadratic function with the x-axis. 

#include "Main.h"

void quadraticEquation() {
	int a = 0; // Input a
	int b = 0; // Input b
	int c = 0; // Input c
	int discriminant = 0; // Store whether descriminant is >0, ==0, <0 for if statement
	float root1 = 0; // First root
	float root2 = 0; // Second root

	cout << "Welcome to the Quadratic Equation Solver!\n\n";
	cout << "Please enter the values for your equation below...\n"
		<< "a: ";
	cin >> a;
	cout << "b: ";
	cin >> b;
	cout << "c: ";
	cin >> c;
	cout << "\n\nYour equation is: 0 = " << a << "x^2 + " << b << "x + " << c << "\n"; // Print out the simple equation
	cout << "In the quadratic equation it looks like:             -" << b << " +- sqrt(" << b << "^2 - 4(" << "(" << a << ")" << "(" << c << ")" << ")\n" // Print out in solution format
		<< "                                                 x = ------------------------------\n"
		<< "                                                              2(" << a << ")\n\n";

	// Discriminant: A function of the coefficients of a polynomial equation
	// whose value gives information about the roots of the polynomial.
	discriminant = (pow(b, 2) - 4 * a * c); // descriminant = b^2 - 4ac

	cout << "Now let's handle the solution!...\n"
		<< "The roots given your values for a, b, and c are...\n";

	if (a == 0) {
		cout << "\nDivide by zero error.\n\n";
	}
	else {
		if (discriminant > 0) {
			root1 = (-1 * (b)+sqrt(discriminant)) / (2 * a);
			root2 = (-1 * (b)-sqrt(discriminant)) / (2 * a);
		}
		else if (discriminant == 0) {
			root1 = root2 = (-abs(b)) / (2 * a);
		}
		else {
			discriminant = -abs(discriminant);

			cout << "x1 = " << "(" << -1 * (b) << " + i" << sqrt(discriminant) << ") / " << 2 * a << "\n";
			cout << "x2 = " << "(" << -1 * (b) << " - i" << sqrt(discriminant) << ") / " << 2 * a << "\n";
		}

		cout << "x1 = " << root1 << "\n";
		cout << "x2 = " << root2 << "\n\n";
	}
}