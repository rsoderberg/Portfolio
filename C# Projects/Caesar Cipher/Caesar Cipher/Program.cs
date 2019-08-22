using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caesar_Cipher
{
    class Program
    {
        // Dev.to Daily Challenge #42 - Caesar Cipher
        // https://dev.to/thepracticaldev/daily-challenge-42-caesar-cipher-43k8

        // - Accept a shift key and a string and return the encrypted text. Leave any non-letter characters as-is.
        // - To encrypt, substitute the letters in the message with letters some fixed number of positions (key)
        // down the alphabet.

        static void Main(string[] args)
        {
            Console.Write("Enter the encryption shift key (1-9): ");
            var key = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the sentence to encrypt: ");
            var message = Console.ReadLine();

            Console.WriteLine(key);
            Console.WriteLine(message);

            Console.Read();
        }
    }
}
