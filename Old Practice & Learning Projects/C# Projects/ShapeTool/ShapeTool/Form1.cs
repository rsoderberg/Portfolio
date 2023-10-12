using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShapeTool
{
    public partial class shapeForm : Form
    {
        public shapeForm()
        {
            InitializeComponent();
        }

        public void calculateShapes()
        {
            double area = 0;
            double length = 0;
            double width = 0;
            double radius = 0;
            double circumf = 0;

            double result = 0;

            if (squareRadioButton.Checked == true)
            {
                if (areaTextBox.Text != String.Empty)
                {
                    area = Convert.ToDouble(areaTextBox.Text);   
                }
                else if (lengthTextBox.Text != String.Empty)
                {
                    length = Convert.ToDouble(lengthTextBox.Text);
                }
                else if (widthTextBox.Text != String.Empty)
                {
                    width = Convert.ToDouble(widthTextBox.Text);
                }
            }
            else if (rectangleRadioButton.Checked == true)
            {
                if (areaTextBox.Text != String.Empty)
                {
                    area = Convert.ToDouble(areaTextBox.Text);
                }
                else if (lengthTextBox.Text != String.Empty)
                {
                    length = Convert.ToDouble(lengthTextBox.Text);
                }
                else if (widthTextBox.Text != String.Empty)
                {
                    width = Convert.ToDouble(widthTextBox.Text);
                }
            }
            else if (circleRadioButton.Checked == true)
            {
                if (areaTextBox.Text != String.Empty)
                {
                    area = Convert.ToDouble(areaTextBox.Text);
                }
                else if (lengthTextBox.Text != String.Empty)
                {
                    circumf = Convert.ToDouble(lengthTextBox.Text);
                }
                else if (widthTextBox.Text != String.Empty)
                {
                    radius = Convert.ToDouble(widthTextBox.Text);
                }
            }

            // Square Calculations
            if (squareRadioButton.Checked == true && areaTextBox.Text == String.Empty && lengthTextBox.Text != String.Empty)
            {
                result = length * length;
                areaTextBox.Text = Convert.ToString(result);

                if (widthTextBox.Text == String.Empty)
                    widthTextBox.Text = Convert.ToString(length);
            }
            else if (squareRadioButton.Checked == true && areaTextBox.Text == String.Empty && widthTextBox.Text != String.Empty)
            {
                result = width * width;
                areaTextBox.Text = Convert.ToString(result);

                if (lengthTextBox.Text == String.Empty)
                    lengthTextBox.Text = Convert.ToString(width);
            }
            else if (squareRadioButton.Checked == true && areaTextBox.Text != String.Empty && lengthTextBox.Text == String.Empty && widthTextBox.Text == String.Empty)
            {
                length = (Math.Sqrt(area));
                width = length;

                areaTextBox.Text = Convert.ToString(area);
                lengthTextBox.Text = Convert.ToString(length);
                widthTextBox.Text = Convert.ToString(width);
            }

            // Rectangle Calculations
            if (rectangleRadioButton.Checked == true && areaTextBox.Text == String.Empty && lengthTextBox.Text != String.Empty)
            {
                if (widthTextBox.Text == String.Empty)
                    MessageBox.Show("Must provide the width to calculate the area of a rectangle");
                else
                {
                    length = Convert.ToDouble(lengthTextBox.Text);
                    width = Convert.ToDouble(widthTextBox.Text);
                    result = length * width;
                    areaTextBox.Text = Convert.ToString(result);
                }
            }
            else if (rectangleRadioButton.Checked == true & areaTextBox.Text == String.Empty && widthTextBox.Text != String.Empty)
            {
                if (lengthTextBox.Text == String.Empty)
                    MessageBox.Show("Must provide the length to calculate the area of a rectangle");
                else
                {
                    length = Convert.ToDouble(lengthTextBox.Text);
                    width = Convert.ToDouble(widthTextBox.Text);
                    result = length * width;
                    areaTextBox.Text = Convert.ToString(result);
                }  
            }
            else if (rectangleRadioButton.Checked == true && areaTextBox.Text != String.Empty)
            {
                if (widthTextBox.Text == String.Empty && lengthTextBox.Text == String.Empty)
                    MessageBox.Show("Must provide the length or width along with the area to calculate the sides of a rectangle");

                else if (lengthTextBox.Text != String.Empty)
                {
                    length = Convert.ToDouble(lengthTextBox.Text);
                    result = area / length;
                    widthTextBox.Text = Convert.ToString(result);
                }
                    
                else if (widthTextBox.Text != String.Empty)
                {
                    width = Convert.ToDouble(widthTextBox.Text);
                    result = area / width;
                    lengthTextBox.Text = Convert.ToString(result);
                }
            }

            // Circle Calculations
            // circumferenceTextBox = lengthTextBox
            // radiusTextBox = widthTextBox
            if (circleRadioButton.Checked == true && areaTextBox.Text == String.Empty) // pi * (radius * radius)
            {
                if (widthTextBox.Text == String.Empty && lengthTextBox.Text == String.Empty)
                    MessageBox.Show("Must provide the radius or circumference to find the area of a circle");
                
                else if (lengthTextBox.Text == String.Empty)
                {
                    radius = Convert.ToDouble(widthTextBox.Text);
                    circumf = 2 * Math.PI * radius;
                    result = Math.PI * (radius * radius);
                    lengthTextBox.Text = Convert.ToString(circumf);
                    areaTextBox.Text = Convert.ToString(result);
                }
                if (widthTextBox.Text == String.Empty)
                {
                    circumf = Convert.ToDouble(lengthTextBox.Text);
                    radius = circumf / (2 * Math.PI);
                    result = Math.PI * (radius * radius);
                    widthTextBox.Text = Convert.ToString(radius);
                    areaTextBox.Text = Convert.ToString(result);
                }
            }
            else if (circleRadioButton.Checked == true && areaTextBox.Text != String.Empty) // r = C / 2 * pi
            {
                if (lengthTextBox.Text == String.Empty)
                {
                    radius = Convert.ToDouble(widthTextBox.Text);
                    circumf = 2 * Math.PI * radius;
                    result = Math.PI * (radius * radius);
                    lengthTextBox.Text = Convert.ToString(circumf);
                    areaTextBox.Text = Convert.ToString(result);
                }
                else if (widthTextBox.Text == String.Empty)
                {
                    circumf = Convert.ToDouble(lengthTextBox.Text);
                    radius = circumf / (2 * Math.PI);
                    widthTextBox.Text = Convert.ToString(radius);
                    lengthTextBox.Text = Convert.ToString(circumf);
                    areaTextBox.Text = Convert.ToString(area);
                }
            }
        }


        private void calculateButton_Click(object sender, EventArgs e)
        {
            calculateShapes();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            // Clear values and radio buttons
            areaTextBox.Text = String.Empty;
            lengthTextBox.Text = String.Empty;
            widthTextBox.Text = String.Empty;
        }

        private void squareRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (squareRadioButton.Checked == true)
            {
                areaLabel.Show();
                lengthLabel.Show();
                widthLabel.Show();
                circLabel.Hide();
                radiusLabel.Hide();
            }
            else if (rectangleRadioButton.Checked == true)
            {
                areaLabel.Show();
                lengthLabel.Show();
                widthLabel.Show();
                circLabel.Hide();
                radiusLabel.Hide();
            }
            else if (circleRadioButton.Checked == true)
            {
                areaLabel.Show();
                lengthLabel.Hide();
                widthLabel.Hide();
                circLabel.Show();
                radiusLabel.Show();
            }
        }

        private void rectangleRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (squareRadioButton.Checked == true)
            {
                areaLabel.Show();
                lengthLabel.Show();
                widthLabel.Show();
                circLabel.Hide();
                radiusLabel.Hide();
            }
            else if (rectangleRadioButton.Checked == true)
            {
                areaLabel.Show();
                lengthLabel.Show();
                widthLabel.Show();
                circLabel.Hide();
                radiusLabel.Hide();
            }
            else if (circleRadioButton.Checked == true)
            {
                areaLabel.Show();
                lengthLabel.Hide();
                widthLabel.Hide();
                circLabel.Show();
                radiusLabel.Show();
            }
        }

        private void circleRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (squareRadioButton.Checked == true)
            {
                areaLabel.Show();
                lengthLabel.Show();
                widthLabel.Show();
                circLabel.Hide();
                radiusLabel.Hide();
            }
            else if (rectangleRadioButton.Checked == true)
            {
                areaLabel.Show();
                lengthLabel.Show();
                widthLabel.Show();
                circLabel.Hide();
                radiusLabel.Hide();
            }
            else if (circleRadioButton.Checked == true)
            {
                areaLabel.Show();
                lengthLabel.Hide();
                widthLabel.Hide();
                circLabel.Show();
                radiusLabel.Show();
            }
        }
    }
}
