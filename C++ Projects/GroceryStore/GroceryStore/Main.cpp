// Program: The Grocery Store
// Author: Rachel Soderberg
// Date Created: April 14, 2018
// Latest Edit: April 14, 2018

// Program Description: A console application which performs several shopping functions:
//				- Display a menu of available commands
//				- Allows input of grocery products to a shopping cart (attr: Name, Unit of Measure, Qty, Price)
//				- Allows listing of items in cart with subtotals
//				- Allows user to sort by name or subtotal (a subtotal should be shown on each line with qty * price)
//				- Supports adding to and removing from cart, clearing cart, and checkout
//				- Presents payment methods and appropriate input information

#include "Header.h"

int main() {
	srand((unsigned)time(NULL)); // Seed for generating random order number at checkout

	Product *banana = new Product;
	Product *apple = new Product;
	Product *avocado = new Product;
	Product *tomato = new Product;
	Product *cheese = new Product;
	Product *milk = new Product;
	Product *egg = new Product;
	Product *bread = new Product;

	welcome(bread, apple, avocado, tomato, cheese, milk, egg, bread);

	system("pause");
	return 0;
}