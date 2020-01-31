using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DND_Max_Hit_Points_Calculator
{
    class Dice
    {
        public string Roll(int die, string currentLevel)
        {
            calculateMaxHPForm.OutputHandler.PrintResult($"Rolling a d{die}.....{Environment.NewLine}");

            int roll = 0;

            if (currentLevel == "0")
            {
                roll = die;
            }
            else
            {
                // TODO: Randomization! Need to "roll" the die
                roll = die - 1;
            }

            calculateMaxHPForm.OutputHandler.PrintResult($"You rolled: {roll}{Environment.NewLine}");

            return Convert.ToString(roll);
        }
    }
}
