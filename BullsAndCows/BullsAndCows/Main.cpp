// Name: Bulls and Cows Game
// Programmer: Rachel Soderberg
// Date Created: December 30, 2017
// Latest Edit: December 31, 2017

// Description: This version of "Bulls and Cows" is a game where the computer generates four
// different integers in the range of 0 to 9 (e.g., 1234 but not 1122) and it is the user's
// task to correctly determine those numbers through repeated guesses. If the numbers to guess
// are 1234 and the user guesses 1359; the response will be "1 bull and 1 cow" because
// the user got one digit correct in the correct position (a bull), and one digit correct
// but in the wrong position (a cow). The guessing continues until the user gets four bulls,
// that is, has the four digits correct and in the correct order.

#include "Header.h"

void main() {
	bullsAndCows();
}