using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morse_Code_Translator
{
    class Program
    {
        // https://morsecode.scphillips.com/morse2.html
        // 3 spaces = new letter, 7 spaces = new word

        public static Dictionary<string, string> morseTranslations = new Dictionary<string, string>
            {
                { ".-", "A" }, { "-...", "B"}, { "-.-.", "C"}, { "-..", "D"}, { ".", "E"},
                { "..-.", "F"}, { "--.", "G"}, { "....", "H"}, { "..", "I"}, { ".---", "J"},
                { "-.-", "K"}, { ".-..", "L"}, { "--", "M"}, { "-.", "N"}, { "---", "O"},
                { ".--.", "P"}, { "--.-", "Q"}, { ".-.", "R"}, { "...", "S"}, { "-", "T"},
                { "..-", "U"}, { "...-", "V"}, { ".--", "W"}, { "-..-", "X"}, { "-.--", "Y"},
                { "--..", "Z"}, { "-----", "0"}, { ".----", "1"}, { "..---", "2"}, { "...--", "3"},
                { "....-", "4"}, { ".....", "5"}, { "-....", "6"}, { "--...", "7"}, { "---..", "8"},
                { "----.", "9"}, { "----", "CH" }
            };

        private static List<string> LatinWords = new List<string>();

        static void Main(string[] args)
        {
            string message = Console.ReadLine();

            int spaceCount = 0;
            string morseLetter = "";
            string latinWord = "";

            foreach (var unit in message)
            {
                if (unit == '.' || unit == '-')
                {
                    spaceCount = 0;

                    morseLetter += unit;
                }
                if (unit == ' ')
                {
                    spaceCount++;

                    if (spaceCount == 3)
                    {
                        // End letter - translate letter & add to latinWord
                        if (morseTranslations.ContainsKey(morseLetter))
                        {
                            latinWord += morseTranslations[morseLetter];
                            Console.WriteLine(latinWord);
                        }
                        morseLetter = "";
                    }
                    if (spaceCount == 7)
                    {
                        if (morseTranslations.ContainsKey(morseLetter))
                        {
                            latinWord += morseTranslations[morseLetter];
                            Console.WriteLine(latinWord);
                        }
                        morseLetter = "";

                        // End word - add latinWord to LatinWords
                        LatinWords.Add(latinWord);
                        latinWord = "";
                    }
                    // if it's the last letter in the message...
                }
                
                //else
                //{
                //    // alphabet
                //    spaceCount = 0;
                //    Console.WriteLine("Only enter morse code!");
                //}
            }

            foreach (var word in LatinWords)
            {
                Console.Write($"Message: {word} ");
            }

            Console.ReadLine();
        }
    }
}
