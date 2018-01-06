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

void main() {
	quadraticEquation();
}