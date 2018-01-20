// Program: Calculator
// Author: Rachel Soderberg
// Date Created: January 19, 2018
// Latest Edit: January 19, 2018

// Description: A simple calculator that performs the basic whole number
// arithmetic functions (+, -, *, /).

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculate(char value = ' ')
        {
            // Each button press sets value to the value of the button, then sends that numerical or
            // symbol value to the array for storage.
        }

        private void solve(int qty = 0) {
            // Use for loop to access each value and solve
            for (int i = 0; i < qty; i++)
            {
                // if (array[i] == numerical value) {
                    // array[i] 
            }
        }

        private void oneButton_Click(object sender, EventArgs e)
        {
            int value = 0;

            outputLabel.Text = "1";
            value = 1;
        }

        private void twoButton_Click(object sender, EventArgs e)
        {
            int value = 0;

            outputLabel.Text = "2";
            value = 2;
        }

        private void threeButton_Click(object sender, EventArgs e)
        {
            int value = 0;

            outputLabel.Text = "3";
            value = 3;
        }

        private void fourButton_Click(object sender, EventArgs e)
        {
            int value = 0;

            outputLabel.Text = "4";
            value = 4;
        }

        private void fiveButton_Click(object sender, EventArgs e)
        {
            int value = 0;

            outputLabel.Text = "5";
            value = 5;
        }

        private void sixButton_Click(object sender, EventArgs e)
        {
            int value = 0;

            outputLabel.Text = "6";
            value = 6;
        }

        private void sevenButton_Click(object sender, EventArgs e)
        {
            int value = 0;

            outputLabel.Text = "7";
            value = 7;
        }

        private void eightButton_Click(object sender, EventArgs e)
        {
            int value = 0;

            outputLabel.Text = "8";
            value = 8;
        }

        private void nineButton_Click(object sender, EventArgs e)
        {
            int value = 0;

            outputLabel.Text = "9";
            value = 9;
        }

        private void zeroButton_Click(object sender, EventArgs e)
        {
            int value = 0;

            outputLabel.Text = "0";
            value = 0;
        }

        private void multiplyButton_Click(object sender, EventArgs e)
        {
            string value = " ";

            value = "*";

            
            outputLabel.Text = value;

        }

        private void divideButton_Click(object sender, EventArgs e)
        {
            outputLabel.Text = "/";
        }

        private void minusButton_Click(object sender, EventArgs e)
        {
            outputLabel.Text = "-";
        }

        private void plusButton_Click(object sender, EventArgs e)
        {
            outputLabel.Text = "+";
        }

        private void equalsButton_Click(object sender, EventArgs e)
        {
            outputLabel.Text = "=";
        }
    }
}
