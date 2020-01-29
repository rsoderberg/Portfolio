using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DND_Max_Hit_Points_Calculator
{
    class Dice
    {
        public string Roll(int die)
        {
            calculateMaxHPForm.OutputHandler.PrintResult($"Rolling a d{die}.....{Environment.NewLine}");

            int roll = die;

            // TODO: Randomization! Need to "roll" the die

            calculateMaxHPForm.OutputHandler.PrintResult($"You rolled: {roll}{Environment.NewLine}");

            return Convert.ToString(roll);
        }
    }
}
