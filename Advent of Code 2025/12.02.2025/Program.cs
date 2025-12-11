// Part 1:
// Checking the ranges listed in text file for ids
// Ranges separated by commas, first id and last id in the range are separated by a dash
// Invalid ids are the sequence of digits repeated twice (ex: 55, 6464, 123123 are all invalid ids) - no leading zeroes
// Result is the sum of all invalid ids found

// Part 2:
// Invalid ids are the sequence of digits repeated AT LEAST twice (ex: 12341234 (1234 two times),
// 123123123 (123 three times), 1212121212 (12 five times), and 1111111 (1 seven times)) - still no leading zeroes
// Result is the sum of all invalid ids found


long resultSum = 0;

string fileLocation = "D:\\Portfolio\\Advent of Code 2025\\12.02.2025\\Files\\";
string fileName = "Sample.txt"; // Pt 1 Solution: 1227775554, Pt 2 Solution: 4174379265
//string fileName = "Input.txt"; // Pt 1 Solution: 13919717792, Pt 2 Solution: 

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
        Console.WriteLine($"Current: {currentDigit}");

        List<long> splits = new List<long>();

        char[] digitArray = currentDigit.ToCharArray();
        foreach (var digit in digitArray)
        {
            Console.WriteLine($"This digit: {digit}");

            if (splits.Count == 0)
            {
                splits.Add(digit);
            }
            else if (splits.Contains(digit))
            {
                splits.Add(digit);
            }
        }
        


        /*
        for (int index = 1; index <= currentDigit.Length; index++)
        {
            int splitIndex = currentDigit.Length / (index + 1); // 1 

            for (int sid = 0; sid <= splitIndex; sid++)
            {
                string splitPortion = currentDigit.Substring(sid, splitIndex);
                if (!string.IsNullOrEmpty(splitPortion) && !splitPortion.StartsWith("0"))
                {
                    try
                    {
                        long thisSplit = long.Parse(splitPortion);
                        splits.Add(thisSplit);

                        Console.WriteLine($"Added {thisSplit} to splits list");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
            }
        }
        */

        /*
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
        */
    }
}

Console.WriteLine("---------------------------------------------------");
Console.WriteLine($"Result: {resultSum}");