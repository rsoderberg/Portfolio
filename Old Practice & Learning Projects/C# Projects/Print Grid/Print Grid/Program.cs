using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Print_Grid
{
    class Program
    {
        private static int Rows { get; set; }

        static void Main(string[] args)
        {
            AskForNumberOfRowsForGridSize();

            int rowCounter = 0;
            while (rowCounter < Rows)
            {
                PrintGridSquares(1);
                Console.WriteLine();

                rowCounter++; // Move to the next row
            }

            Console.ReadKey();
        }

        private static void AskForNumberOfRowsForGridSize()
        {
            Console.WriteLine("Enter the number of rows for your grid: ");
            Rows = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
        }

        private static void PrintGridSquares(int squareCounter)
        {
            if (squareCounter < 1)
                return;

            if (squareCounter <= Rows)
            {
                Console.Write(" ☻ ");
                PrintGridSquares(squareCounter + 1);
            }
        }
    }
}
