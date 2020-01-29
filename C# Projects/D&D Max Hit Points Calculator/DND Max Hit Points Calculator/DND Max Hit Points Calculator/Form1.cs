using System;
using System.Windows.Forms;

namespace DND_Max_Hit_Points_Calculator
{
    public partial class calculateMaxHPForm : Form
    {
        public static calculateMaxHPForm OutputHandler;

        public calculateMaxHPForm()
        {
            InitializeComponent();
            OutputHandler = this;
        }

        public void PrintResult(string output)
        {
            resultsTextBox.Text = resultsTextBox.Text + output + Environment.NewLine;
            resultsTextBox.Update();
        }

        private void rollButton_Click(object sender, EventArgs e)
        {
            Dice die = new Dice();

            string rollValue = "";

            switch (Convert.ToString(dieComboBox.SelectedItem))
            {
                case "d2":
                    rollValue = die.Roll(2);
                    break;
                case "d3":
                    rollValue = die.Roll(3);
                    break;
                case "d4":
                    rollValue = die.Roll(4);
                    break;
                case "d6":
                    rollValue = die.Roll(6);
                    break;
                case "d8":
                    rollValue = die.Roll(8);
                    break;
                case "d10":
                    rollValue = die.Roll(10);
                    break;
                case "d12":
                    rollValue = die.Roll(12);
                    break;
                case "d20":
                    rollValue = die.Roll(20);
                    break;
            }

            rollTextBox.Text = rollValue;
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {

        }
    }
}
