// Program: The Grocery Store
// Author: Rachel Soderberg
// Date Created: April 14, 2018
// Latest Edit: April 14, 2018

// Description: Welcome message to greet user upon launch

#include "Header.h"
#include "Product.h"

void welcome(Product *banana, Product *apple, Product *avocado, Product *tomato, Product *cheese, Product *milk, Product *egg, Product *bread) {
	system("CLS"); // Clear the console

	char selection = 0;

	// Friendly welcome message, user can return to this from most screens using Q or q
	std::cout << "Welcome to the Grocery Store!\n" << "-----------------------------\n" << "Please make your selection from the choices below:\n"
		<< "     1. Shop our product catalog\n"
		<< "     2. View or edit your shopping cart\n"
		<< "     3. Proceed to checkout\n"

		<< "\nSelection: ";
	std::cin >> selection; // Check for valid numerical input

	switch (selection) {
	case '1':
		productSelect(bread, apple, avocado, tomato, cheese, milk, egg, bread);
		break;
	case '2':
		shoppingCart(bread, apple, avocado, tomato, cheese, milk, egg, bread);
		break;
	case '3':
		checkout(banana, apple, avocado, tomato, cheese, milk, egg, bread);
		break;
	default:
		std::cout << "Invalid selection, please choose one of the shown options\n\n";
		welcome(bread, apple, avocado, tomato, cheese, milk, egg, bread);
		break;
	}
}