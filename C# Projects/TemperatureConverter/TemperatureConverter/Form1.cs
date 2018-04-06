using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TemperatureConverter
{
    public partial class tempConvForm : Form
    {
        public tempConvForm()
        {
            InitializeComponent();
        }

        // C = (F - 32) / 1.8
        public void calculateFtoC()
        {
            double f = 0;
            int c = 0;

            f = Convert.ToInt32(initialTextBox.Text);
            c = Convert.ToInt32((f - 32) / 1.8);

            resultLabel.Text = Convert.ToString(c);
        }
        // K = (F + 459.67) × 0.56
        public void calculateFtoK()
        {
            double f = 0;
            int k = 0;

            f = Convert.ToInt32(initialTextBox.Text);
            k = Convert.ToInt32((f + 459.67) * 0.56);

            resultLabel.Text = Convert.ToString(k);
        }
        // F = C × 1.8 + 32 
        public void calculateCtoF()
        {
            double c = 0;
            int f = 0;

            c = Convert.ToInt32(initialTextBox.Text);
            f = Convert.ToInt32((c * 1.8) + 32);

            resultLabel.Text = Convert.ToString(f);
        }
        // K = C + 273.15
        public void calculateCtoK()
        {
            double c = 0;
            int k = 0;

            c = Convert.ToInt32(initialTextBox.Text);
            k = Convert.ToInt32(c + 273.15);

            resultLabel.Text = Convert.ToString(k);
        }
        // F = (K × 9/5) - 459.67
        public void calculateKtoF()
        {
            double k = 0;
            int f = 0;

            k = Convert.ToInt32(initialTextBox.Text);
            f = Convert.ToInt32((k * 1.8) - 459.67);

            resultLabel.Text = Convert.ToString(f);
        }
        // C = K - 273.15
        public void calculateKtoC()
        {
            double k = 0;
            int c = 0;

            k = Convert.ToInt32(initialTextBox.Text);
            c = Convert.ToInt32(k - 273.15);

            resultLabel.Text = Convert.ToString(c);
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            if (initialTextBox.Text == String.Empty)
            {
                MessageBox.Show("Error, must input a temperature to convert!");
            }
            else
            {
                // Handle various radio button combinations
                if (fahrenInitialRadio.Checked == true && celsiusResultRadio.Checked == true)
                    calculateFtoC();
                else if (fahrenInitialRadio.Checked == true && kelvinResultRadio.Checked == true)
                    calculateFtoK();
                else if (celsiusInitialRadio.Checked == true && fahrenResultRadio.Checked == true)
                    calculateCtoF();
                else if (celsiusInitialRadio.Checked == true && kelvinResultRadio.Checked == true)
                    calculateCtoK();
                else if (kelvinInitialRadio.Checked == true && fahrenResultRadio.Checked == true)
                    calculateKtoF();
                else if (kelvinInitialRadio.Checked == true && celsiusResultRadio.Checked == true)
                    calculateKtoC();
                else
                    MessageBox.Show("Error, cannot convert this."); // When matching radio buttons are used
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            // Reset radio buttons to default status
            fahrenInitialRadio.Checked = true;
            celsiusInitialRadio.Checked = false;
            kelvinInitialRadio.Checked = false;
            fahrenResultRadio.Checked = false;
            celsiusResultRadio.Checked = true;
            kelvinResultRadio.Checked = false;

            // Clear any values within the text fields
            initialTextBox.Text = " ";
            resultLabel.Text = " ";
        }
    }
}
