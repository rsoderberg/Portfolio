// Checking the ranges listed in text file for ids
// Ranges separated by commas, first id and last id in the range are separated by a dash
// Invalid ids are the sequence of digits repeated twice (ex: 55, 6464, 123123 are all invalid ids) - no leading zeroes
// Result is the sum of all invalid ids found

long resultSum = 0;

string fileLocation = "D:\\Portfolio\\Advent of Code 2025\\12.02.2025\\Files\\";
//string fileName = "Sample.txt"; // Solution: 1227775554
string fileName = "Input.txt"; // Solution: 13919717792

var input = File.ReadAllText(fileLocation + fileName);
string[] ranges = input.Split(',');
foreach (var range in ranges)
{
    string[] thisRange = range.Split('-');
    long rangeStart = long.Parse(thisRange[0]);
    long rangeEnd = long.Parse(thisRange[1]);

    Console.WriteLine($"RangeStart: {rangeStart}, RangeEnd: {rangeEnd}");

    for (long i = rangeStart; i <= rangeEnd; i++)
    {
        string currentDigit = i.ToString();

        int middleIndex = currentDigit.Length / 2;
        string firstHalf = currentDigit.Substring(0, middleIndex);
        string secondHalf = currentDigit.Substring(middleIndex);

        if (!string.IsNullOrEmpty(firstHalf) && !firstHalf.StartsWith("0") && !secondHalf.StartsWith("0"))
        {
            try
            {
                long firstHalfInt = long.Parse(firstHalf);
                long secondHalfInt = long.Parse(secondHalf);

                if (firstHalfInt == secondHalfInt)
                {
                    resultSum += long.Parse(currentDigit);
                    Console.WriteLine($"Match: {currentDigit}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}

Console.WriteLine("---------------------------------------------------");
Console.WriteLine($"Result: {resultSum}");