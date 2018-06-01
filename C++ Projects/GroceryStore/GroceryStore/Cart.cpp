// Program: The Grocery Store
// Author: Rachel Soderberg
// Date Created: April 14, 2018
// Latest Edit: April 14, 2018

// Description: Display current shopping cart

#include "Header.h"
#include "Product.h"

void shoppingCart(Product *banana, Product *apple, Product *avocado, Product *tomato, Product *cheese, Product *milk, Product *egg, Product *bread) {
	system("CLS"); // Clear the console

	char input = ' ';

	std::cout << "\nCart Details:\n";

	if (banana->get_name() != " ")
		std::cout << banana->get_name() + ": " << banana->get_quantity() << " " << banana->get_measure() << "...... Subtotal: $" << std::setprecision(2) << std::fixed << banana->get_price() << "\n";
	if (apple->get_name() != " ")
		std::cout << apple->get_name() + ": " << apple->get_quantity() << " " << apple->get_measure() << "...... Subtotal: $" << std::setprecision(2) << std::fixed << apple->get_price() << "\n";
	if (avocado->get_name() != " ")
		std::cout << avocado->get_name() + ": " << avocado->get_quantity() << " " << avocado->get_measure() << "...... Subtotal: $" << std::setprecision(2) << std::fixed << avocado->get_price() << "\n";
	if (tomato->get_name() != " ")
		std::cout << tomato->get_name() + ": " << tomato->get_quantity() << " " << tomato->get_measure() << "...... Subtotal: $" << std::setprecision(2) << std::fixed << tomato->get_price() << "\n";
	if (cheese->get_name() != " ")
		std::cout << cheese->get_name() + ": " << cheese->get_quantity() << " " << cheese->get_measure() << "...... Subtotal: $" << std::setprecision(2) << std::fixed << cheese->get_price() << "\n";
	if (milk->get_name() != " ")
		std::cout << milk->get_name() + ": " << milk->get_quantity() << " " << milk->get_measure() << "...... Subtotal: $" << std::setprecision(2) << std::fixed << milk->get_price() << "\n";
	if (egg->get_name() != " ")
		std::cout << egg->get_name() + ": " << egg->get_quantity() << " " << egg->get_measure() << "...... Subtotal: $" << std::setprecision(2) << std::fixed << egg->get_price() << "\n";
	if (bread->get_name() != " ")
		std::cout << bread->get_name() + ": " << bread->get_quantity() << " " << bread->get_measure() << "...... Subtotal: $" << std::setprecision(2) << std::fixed << bread->get_price() << "\n";

	std::cout << "\n\nPress Q to return to Welcome Screen for checkout or to modify your cart: ";
	std::cin >> input;

	std::cout << "\n";

	if (input == 'Q' || input == 'q')
		welcome(banana, apple, avocado, tomato, cheese, milk, egg, bread);
	else
		std::cout << "Invalid entry, try again\n\n";
}