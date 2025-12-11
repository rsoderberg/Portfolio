// Numbers 0-99 valid
// L means decrease, R means increase
// Left from 0 = 99, Right from 99 = 0
// Start at 50

int minVal = 0;
int maxVal = 99;
int currentPosition = 50;
int zeroCounter = 0;

string fileLocation = "D:\\Portfolio\\Advent of Code 2025\\12.01.2025\\Files\\";
//string fileName = "Sample.txt"; // Solution: 3 zeroes
string fileName = "Input.txt"; // Solution: 1129 zeroes

var lines = File.ReadLines(fileLocation + fileName);
foreach (string line in lines)
{
    int changeVal = 0;

    if (line.Contains("L"))
    {
        // decrease
        changeVal = Convert.ToInt32(line.Replace("L", ""));
        currentPosition = currentPosition - changeVal;
    }
    else if (line.Contains("R"))
    {
        // increase
        changeVal = Convert.ToInt32(line.Replace("R", ""));
        currentPosition = currentPosition + changeVal;
    }

    while (currentPosition < minVal || currentPosition > maxVal)
    {
        int diff = 0;
        if (currentPosition < minVal)
        {
            diff = -(currentPosition + 1);

            currentPosition = maxVal - diff;
        }
        else if (currentPosition > maxVal)
        {
            diff = currentPosition - 1;

            currentPosition = -(maxVal - diff);
        }
    }

    if (currentPosition == 0)
    {
        zeroCounter++;
    }

    Console.WriteLine($"Rotated {line} to {currentPosition}");
}

Console.WriteLine("---------------------------------------------------");
Console.WriteLine($"There were {zeroCounter} zeros");