#pragma once

// Program: The Grocery Store
// Author: Rachel Soderberg
// Date Created: April 14, 2018
// Latest Edit: April 14, 2018

// Description: Includes, definitions, and function declarations

#include <iostream>
#include <iomanip>
#include <stdlib.h>
#include <string>
#include <time.h>

#include "Product.h"

// Product Definitions
#define BANANA 0.89;
#define APPLE 0.42;
#define AVOCADO 1.05;
#define TOMATO 0.50;
#define CHEESE 3.00;
#define MILK 2.85;
#define EGG 0.99;
#define BREAD 2.00;

// Function Declarations/Prototypes
void welcome(Product *banana, Product *apple, Product *avocado, Product *tomato, Product *cheese, Product *milk, Product *egg, Product *bread);
void productSelect(Product *banana, Product *apple, Product *avocado, Product *tomato, Product *cheese, Product *milk, Product *egg, Product *bread);
void shoppingCart(Product *banana, Product *apple, Product *avocado, Product *tomato, Product *cheese, Product *milk, Product *egg, Product *bread);

void checkout(Product *banana, Product *apple, Product *avocado, Product *tomato, Product *cheese, Product *milk, Product *egg, Product *bread);
void payment(Product *banana, Product *apple, Product *avocado, Product *tomato, Product *cheese, Product *milk, Product *egg, Product *bread, double checkoutTotal, std::string email);
void payWithCard(double checkoutTotal, std::string email);
void payWithPaypal(double checkoutTotal, std::string email);
void payWithStoreCredit(Product *banana, Product *apple, Product *avocado, Product *tomato, Product *cheese, Product *milk, Product *egg, Product *bread, double checkoutTotal, std::string email);

void checkoutComplete(std::string email);