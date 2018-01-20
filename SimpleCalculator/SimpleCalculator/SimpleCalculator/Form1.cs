// Program: SimpleCalculator
// Author: Rachel Soderberg
// Date Created: January 19, 2018
// Latest Edit: January 20, 2018

// Description: A simple 0-9 integer calculator that performs basic arithmetic functions (+, -, *, /).
// Goals: - Implement the ability to perform calculations on integers larger than 9.
//        - Allow calculations with decimal values.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        class Variables
        {
            public static int var1 = 0;
            public static int var2 = 0;
            public static string oper = " ";
            public static int solution = 0;
        }

        private void OneButton_Click(object sender, EventArgs e)
        {
            if (Variables.oper != " ")
            {
                Variables.var2 = 1;
                outputLabel.Text = Convert.ToString(Variables.var2);
            }
            else
            {
                outputLabel.ResetText();
                Variables.var1 = 1;
                outputLabel.Text = Convert.ToString(Variables.var1);
            }  
        }

        private void TwoButton_Click(object sender, EventArgs e)
        {
            if (Variables.oper != " ")
            {
                Variables.var2 = 2;
                outputLabel.Text = Convert.ToString(Variables.var2);
            }
            else
            {
                outputLabel.ResetText();
                Variables.var1 = 2;
                outputLabel.Text = Convert.ToString(Variables.var1);
            }
        }

        private void ThreeButton_Click(object sender, EventArgs e)
        {
            if (Variables.oper != " ")
            {
                Variables.var2 = 3;
                outputLabel.Text = Convert.ToString(Variables.var2);
            }
            else
            {
                outputLabel.ResetText();
                Variables.var1 = 3;
                outputLabel.Text = Convert.ToString(Variables.var1);
            }
        }

        private void FourButton_Click(object sender, EventArgs e)
        {
            if (Variables.oper != " ")
            {
                Variables.var2 = 4;
                outputLabel.Text = Convert.ToString(Variables.var2);
            }
            else
            {
                outputLabel.ResetText();
                Variables.var1 = 4;
                outputLabel.Text = Convert.ToString(Variables.var1);
            }
        }

        private void FiveButton_Click(object sender, EventArgs e)
        {
            if (Variables.oper != " ")
            {
                Variables.var2 = 5;
                outputLabel.Text = Convert.ToString(Variables.var2);
            }
            else
            {
                outputLabel.ResetText();
                Variables.var1 = 5;
                outputLabel.Text = Convert.ToString(Variables.var1);
            }
        }

        private void SixButton_Click(object sender, EventArgs e)
        {
            if (Variables.oper != " ")
            {
                Variables.var2 = 6;
                outputLabel.Text = Convert.ToString(Variables.var2);
            }
            else
            {
                outputLabel.ResetText();
                Variables.var1 = 6;
                outputLabel.Text = Convert.ToString(Variables.var1);
            }
        }

        private void SevenButton_Click(object sender, EventArgs e)
        {
            if (Variables.oper != " ")
            {
                Variables.var2 = 7;
                outputLabel.Text = Convert.ToString(Variables.var2);
            }
            else
            {
                outputLabel.ResetText();
                Variables.var1 = 7;
                outputLabel.Text = Convert.ToString(Variables.var1);
            }
        }

        private void EightButton_Click(object sender, EventArgs e)
        {
            if (Variables.oper != " ")
            {
                Variables.var2 = 8;
                outputLabel.Text = Convert.ToString(Variables.var2);
            }
            else
            {
                outputLabel.ResetText();
                Variables.var1 = 8;
                outputLabel.Text = Convert.ToString(Variables.var1);
            }
        }

        private void NineButton_Click(object sender, EventArgs e)
        {
            if (Variables.oper != " ")
            {
                Variables.var2 = 9;
                outputLabel.Text = Convert.ToString(Variables.var2);
            }
            else
            {
                outputLabel.ResetText();
                Variables.var1 = 9;
                outputLabel.Text = Convert.ToString(Variables.var1);
            }
        }

        private void ZeroButton_Click(object sender, EventArgs e)
        {
            if (Variables.oper != " ")
            {
                Variables.var2 = 0;
                outputLabel.Text = Convert.ToString(Variables.var2);
            }
            else
            {
                outputLabel.ResetText();
                Variables.var1 = 0;
                outputLabel.Text = Convert.ToString(Variables.var1);
            }
        }

        private void PlusButton_Click(object sender, EventArgs e)
        {
            Variables.oper = "+";
            outputLabel.Text = Variables.oper;
        }

        private void MinusButton_Click(object sender, EventArgs e)
        {
            Variables.oper = "-";
            outputLabel.Text = Variables.oper;
        }

        private void TimesButton_Click(object sender, EventArgs e)
        {
            Variables.oper = "x";
            outputLabel.Text = Variables.oper;
        }

        private void DivideButton_Click(object sender, EventArgs e)
        {
            Variables.oper = "/";
            outputLabel.Text = Variables.oper;
        }

        private void EqualsButton_Click(object sender, EventArgs e)
        {
            // solve
            if (Variables.oper == "+")
            {
                outputLabel.ResetText();
                Variables.solution = Variables.var1 + Variables.var2;
                outputLabel.Text = Convert.ToString(Variables.solution);
            }
            else if (Variables.oper == "-")
            {
                outputLabel.ResetText();
                Variables.solution = Variables.var1 - Variables.var2;
                outputLabel.Text = Convert.ToString(Variables.solution);
            }
            else if (Variables.oper == "x")
            {
                outputLabel.ResetText();
                Variables.solution = Variables.var1 * Variables.var2;
                outputLabel.Text = Convert.ToString(Variables.solution);
            }
            else if (Variables.oper == "/" && Variables.var2 != 0)
            {
                outputLabel.ResetText();
                Variables.solution = Variables.var1 / Variables.var2;
                outputLabel.Text = Convert.ToString(Variables.solution); // Print result and reset variables
            }
            else
            {
                outputLabel.ResetText();
                outputLabel.Text = "ERR";
            }
            Variables.var1 = 0;
            Variables.var2 = 0;
            Variables.oper = " ";
        }
    }
}
