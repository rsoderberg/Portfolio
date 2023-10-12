using System;

namespace Caesar_Cipher
{
    class CaesarCypher
    {
        // Dev.to Daily Challenge #42 - Caesar Cipher
        // https://dev.to/thepracticaldev/daily-challenge-42-caesar-cipher-43k8

        // - Accept a shift key and a string and return the encrypted text. Leave any non-letter characters as-is.
        // - To encrypt, substitute the letters in the message with letters some fixed number of positions (key)
        // down the alphabet.

        public static bool QuitApplication { get; set; }

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Caesar Cipher!");

            Menu menu = new Menu();
            while (QuitApplication == false)
                menu.UserSelection();
        }
    }
}
