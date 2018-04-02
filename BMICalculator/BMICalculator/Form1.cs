// Project: Body Mass Index (BMI) Calculator
// Author: Rachel Soderberg
// Date Created: April 2, 2018
// Latest Edit: April 2, 2018

// Description: Convert user's height and weight to meters and kilograms, respectively, and
//              calculate their BMI with their current status (under, normal, or overweight).

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMICalculator
{
    public partial class bmiCalcForm : Form
    {
        public bmiCalcForm()
        {
            InitializeComponent();
        }

        public void calculateBmi()
        {
            int height = 0, weight = 0;
            double bmi = 0;

            height = Convert.ToInt32(heightTextBox.Text);
            weight = Convert.ToInt32(weightTextBox.Text);

            // Convert inputs to metric
            double heightMeters = height * 0.0254;
            double heightSquared = heightMeters * heightMeters;
            double weightKilograms = weight * 0.453592;

            // Metric BMI formula: Weight (kg) / (Height (m))².
            bmi = weightKilograms / heightSquared;

            int roundBMI = Convert.ToInt32(bmi);
            bmiLabel.Text = Convert.ToString(roundBMI);

            if (bmi < 18.5)
                statusLabel.Text = "Underweight";
            else if (bmi >= 18.5 && bmi <= 24.9)
                statusLabel.Text = "Normal";
            else if (bmi > 25)
                statusLabel.Text = "Overweight";
            else
                statusLabel.Text = "Error";
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            if (heightTextBox.Text == string.Empty || weightTextBox.Text == string.Empty)
            {
                MessageBox.Show("Error, must input height and weight!");
            }
            else
                calculateBmi();
        }
    }
}
