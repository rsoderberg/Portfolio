// Program: The Grocery Store
// Author: Rachel Soderberg
// Date Created: April 14, 2018
// Latest Edit: April 14, 2018

// Description: List available products

#include "Header.h"
#include "Product.h"

void productSelect(Product *banana, Product *apple, Product *avocado, Product *tomato, Product *cheese, Product *milk, Product *egg, Product *bread) {
	char selection = ' ';
	double qty = 0.00;
	double price = 0.00;
	bool input = true; // User input to continue shopping

					   // Set object names and measures for clean output regardless of quantity within the cart
	banana->set_name("Banana"); banana->set_measure("Pounds");
	apple->set_name("Apple"); apple->set_measure("Pounds");
	avocado->set_name("Avocado"); avocado->set_measure("Pounds");
	tomato->set_name("Tomato"); tomato->set_measure("Pounds");
	cheese->set_name("Cheese"); cheese->set_measure("Pounds");
	milk->set_name("Milk"); milk->set_measure("Carton");
	egg->set_name("Egg"); egg->set_measure("Dozen");
	bread->set_name("Bread"); bread->set_measure("Loaf");

	while (input == true) {
		system("CLS"); // Clear the console

		std::cout << "\nCurrent inventory, select item to add to cart: \n"
			<< "     1. Bananas      - $0.89/lb\n"
			<< "     2. Apples       - $0.42/lb\n"
			<< "     3. Avocados     - $1.05/lb\n"
			<< "     4. Tomatoes     - $0.50/lb\n"
			<< "     5. Cheese       - $3.99/lb\n"
			<< "     6. Milk         - $2.85 carton\n"
			<< "     7. Fresh Eggs   - $0.99 dozen\n"
			<< "     8. Bread        - $2.00 loaf\n"
			<< "     Q. Return to Welcome Screen to View Cart or Checkout\n"

			<< "Selection: ";
		std::cin >> selection;

		switch (selection) {
		case '1':
			std::cout << "How many pounds of bananas?: ";
			std::cin >> qty;
			price = qty * BANANA;
			banana->set_values("Banana", "Pounds", qty, price);
			break;
		case '2':
			std::cout << "How many pounds of apples?: ";
			std::cin >> qty;
			price = qty * APPLE;
			apple->set_values("Apple", "Pounds", qty, price);
			break;
		case '3':
			std::cout << "How many pounds of avocados?: ";
			std::cin >> qty;
			price = qty * AVOCADO;
			avocado->set_values("Avocado", "Pounds", qty, price);
			break;
		case '4':
			std::cout << "How many pounds of tomatoes?: ";
			std::cin >> qty;
			price = qty * TOMATO;
			tomato->set_values("Tomato", "Pounds", qty, price);
			break;
		case '5':
			std::cout << "How many pounds of cheese?: ";
			std::cin >> qty;
			price = qty * CHEESE;
			cheese->set_values("Cheese", "Pounds", qty, price);
			break;
		case '6':
			std::cout << "How many cartons of milk?: ";
			std::cin >> qty;
			price = qty * MILK;
			milk->set_values("Milk", "Carton", qty, price);
			break;
		case '7':
			std::cout << "How many dozens of eggs?: ";
			std::cin >> qty;
			price = qty * EGG;
			egg->set_values("Egg", "Dozen", qty, price);
			break;
		case '8':
			std::cout << "How many loaves of bread?: ";
			std::cin >> qty;
			price = qty * BREAD;
			bread->set_values("Bread", "Loaf", qty, price);
			break;
		case 'q':
			input = false;
			std::cout << "\n";
			welcome(bread, apple, avocado, tomato, cheese, milk, egg, bread);
			break;
		case 'Q':
			input = false;
			std::cout << "\n";
			welcome(bread, apple, avocado, tomato, cheese, milk, egg, bread);
			break;
		default:
			input = false;
			std::cout << "Invalid input, please choose from the current inventory list\n\n";
			productSelect(banana, apple, avocado, tomato, cheese, milk, egg, bread);
		}
	}
}

void Product::set_values(std::string tempName, std::string tempMeasure, double tempQty, double tempPrice) {
	Name = tempName;
	Measure = tempMeasure;
	Quantity = tempQty;
	Price = tempPrice;
}

void Product::set_name(std::string tempName) {
	Name = tempName;
}

void Product::set_measure(std::string tempMeasure) {
	Measure = tempMeasure;
}