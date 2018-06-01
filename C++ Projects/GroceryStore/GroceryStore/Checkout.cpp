// Program: The Grocery Store
// Author: Rachel Soderberg
// Date Created: April 14, 2018
// Latest Edit: April 14, 2018

// Description: Ask user for payment information and process the transaction

#include "Header.h"
#include "Product.h"

void checkout(Product *banana, Product *apple, Product *avocado, Product *tomato, Product *cheese, Product *milk, Product *egg, Product *bread) {
	system("CLS"); // Clear the console

	double checkoutTotal = 0.00;
	char answer = ' ';

	std::string firstName = " ", lastName = " ", email = " ";
	int houseNumber = 0, zipCode = 0;
	std::string street = " ", city = " ", state = " ";
	int areaCode = 0, phoneFirst = 0, phoneSecond = 0;

	// Total up all items to display
	checkoutTotal = banana->get_price() + apple->get_price() + avocado->get_price() + tomato->get_price() + cheese->get_price() + milk->get_price() + egg->get_price() + bread->get_price();

	std::cout << "Your total is: " << std::setprecision(2) << std::fixed << checkoutTotal << "\n"

		// Take in user shipping information
		<< "Please enter your shipping info:\n"
		<< "     First Name: ";
	std::cin >> firstName;
	std::cout << "     Last Name: ";
	std::cin >> lastName;
	std::cout << "     Address (house street city state zip): ";
	std::cin >> houseNumber >> street >> city >> state >> zipCode;
	std::cout << "     Phone Number (separate by spaces): ";
	std::cin >> areaCode >> phoneFirst >> phoneSecond;
	std::cout << "     Email: ";
	std::cin >> email;

	// Verify with user that information is correct, proceed to payment if so
	std::cout << "\n\nIs this correct?\n"
		<< firstName << " " << lastName << "\n"
		<< houseNumber << " " << street << " " + city << ", " << state << " " << zipCode << "\n"
		<< areaCode << phoneFirst << phoneSecond << "\n"
		<< email << "\n";

	std::cout << "\nY/N: ";
	std::cin >> answer;

	switch (answer) {
	case 'y':
		payment(banana, apple, avocado, tomato, cheese, milk, egg, bread, checkoutTotal, email);
		break;
	case 'Y':
		payment(banana, apple, avocado, tomato, cheese, milk, egg, bread, checkoutTotal, email);
		break;
	case 'n':
		std::cout << "Okay, let's try again:\n\n";
		checkout(banana, apple, avocado, tomato, cheese, milk, egg, bread);
		break;
	case 'N':
		std::cout << "Okay, let's try again:\n\n";
		checkout(banana, apple, avocado, tomato, cheese, milk, egg, bread);
		break;
	default:
		std::cout << "Invalid, please enter Y or N\n\n";
		break;
	}
}

void payment(Product *banana, Product *apple, Product *avocado, Product *tomato, Product *cheese, Product *milk, Product *egg, Product *bread, double checkoutTotal, std::string email) {
	char selection = ' ';

	std::cout << "Your total is: " << std::setprecision(2) << std::fixed << checkoutTotal << "\n";

	std::cout << "\nHow would you like to pay today?\n"
		<< "     1. Debit/Credit Card\n"
		<< "     2. PayPal\n"
		<< "     3. Store Credit\n"
		<< "     Q: Return to Welcome Screen\n";

	std::cout << "Selection: ";
	std::cin >> selection;

	// Available payment methods
	switch (selection) {
	case '1':
		payWithCard(checkoutTotal, email);
		break;
	case '2':
		payWithPaypal(checkoutTotal, email);
		break;
	case '3':
		payWithStoreCredit(banana, apple, avocado, tomato, cheese, milk, egg, bread, checkoutTotal, email);
		break;
	case 'q':
		checkout(banana, apple, avocado, tomato, cheese, milk, egg, bread);
		break;
	default:
		std::cout << "Please choose from the payment types above\n\n";
		payment(banana, apple, avocado, tomato, cheese, milk, egg, bread, checkoutTotal, email);
		break;
	}
}

// User pays with debit or credit card
void payWithCard(double checkoutTotal, std::string email) {
	int creditFirst = 0, creditSecond = 0, creditThird = 0, creditFourth = 0; // XXXX XXXX XXXX XXXX
	int expDateMonth = 0, expDateYear = 0; // MM, YY
	int securityCode = 0; // SSS
	std::string firstName = " ", lastName = " ";
	char answer = ' '; // Y or N/ y or n

	std::cout << "Your total is: " << std::setprecision(2) << std::fixed << checkoutTotal << "\n";

	std::cout << "\nEnter your credit card number, separated by spaces: ";
	std::cin >> creditFirst >> creditSecond >> creditThird >> creditFourth;
	std::cout << "Expiration date MM YY: ";
	std::cin >> expDateMonth >> expDateYear;
	std::cout << "Security code on the back of the card?: ";
	std::cin >> securityCode;
	std::cout << "Full name as shown on the card?: ";
	std::cin >> firstName >> lastName;

	// Process transaction
	checkoutComplete(email);
}

// User pays with PayPal 
void payWithPaypal(double checkoutTotal, std::string email) {

	std::cout << "Your total is: " << std::setprecision(2) << std::fixed << checkoutTotal << "\n";

	std::cout << "\nProceeding to PayPal website, please wait...\n\n.....\n\n.......\n\n.....\n\n";

	// Process transaction
	checkoutComplete(email);
}

// User pays with store credit card
// Check whether total is enough to cover the balance, if not, continue with more payment methods
void payWithStoreCredit(Product *banana, Product *apple, Product *avocado, Product *tomato, Product *cheese, Product *milk, Product *egg, Product *bread, double checkoutTotal, std::string email) {
	int creditFirst = 0, creditSecond = 0, creditThird = 0, creditFourth = 0; // XXXX XXXX XXXX XXXX
	int securityCode = 0; // SSS
	char selection = ' '; // Y or N/ y or n
	double cardTotal = 0.00, owed = 0.00; // Total on store credit card, amount owed after balance difference

	std::cout << "Your total is: " << std::setprecision(2) << std::fixed << checkoutTotal << "\n";

	std::cout << "\nEnter your store card number, separated by spaces: ";
	std::cin >> creditFirst >> creditSecond >> creditThird >> creditFourth;
	std::cout << "Security code on the back of the card?: ";
	std::cin >> securityCode;
	std::cout << "Amount on card (DD.CC)";
	std::cin >> cardTotal;

	// Determine whether the store credit balance covers the purchase balance
	if (cardTotal < checkoutTotal) {
		owed = checkoutTotal - cardTotal;
		checkoutTotal = owed;

		// Balance is not sufficient, continue with further payment options
		system("CLS"); // Clear the console
		std::cout << "Your remaining balance is " << std::setprecision(2) << std::fixed << owed << ", how would you like to pay?: \n"
			<< "How would you like to pay today?\n"
			<< "     1. Debit/Credit Card\n"
			<< "     2. PayPal\n"
			<< "     3. Store Credit\n"
			<< "     Q: Return to Welcome Screen\n";

		std::cout << "Selection: ";
		std::cin >> selection;

		switch (selection) {
		case '1':
			payWithCard(checkoutTotal, email);
			break;
		case '2':
			payWithPaypal(checkoutTotal, email);
			break;
		case '3':
			payWithStoreCredit(banana, apple, avocado, tomato, cheese, milk, egg, bread, checkoutTotal, email);
			break;
		case 'q':
			checkout(banana, apple, avocado, tomato, cheese, milk, egg, bread);
			break;
		default:
			std::cout << "Please choose from the payment types above\n\n";
			payWithStoreCredit(banana, apple, avocado, tomato, cheese, milk, egg, bread, checkoutTotal, email);
			break;
		}
	}
	// Balance sufficient, process transaction
	else if (cardTotal >= checkoutTotal) {
		checkoutComplete(email);
	}
}

// Process transaction, generate order number
void checkoutComplete(std::string email) {
	system("CLS"); // Clear the console

	int orderNumber = 0;

	orderNumber = rand() % 88888 + 99999;   // Generate random order number

	std::cout << "Congratulations, your order is complete!\n\n"
		<< "Your order number is: " << orderNumber << "\n"
		<< "Please look to your email " << email << " for shipping updates\n\n"
		<< "Thank you for shopping with us, please come back again soon!\n\n";
}