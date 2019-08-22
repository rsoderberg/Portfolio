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

        private static int Key { get; set; }
        private static string CodeMessage { get; set; }

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Caesar Cipher!");

            MenuSelection();

            Console.Read();
        }

        private static void MenuSelection()
        {
            Console.WriteLine("Please select an option:");
            Console.WriteLine("1 - Encrypt");
            Console.WriteLine("2 - Decrypt");
            Console.WriteLine("Q - Quit");

            var selection = Console.ReadLine();

            if (selection != null)
            {
                Message message = new Message();

                if (selection == "1")
                {
                    RetrieveKey();
                    RetrieveMessage();

                    message.Encrypt(Key, CodeMessage);
                }
                else if (selection == "2")
                {
                    RetrieveKey();
                    RetrieveMessage();

                    message.Decrypt(Key, CodeMessage);
                }
                else if (selection.ToUpper() == "Q")
                {
                    Quit();
                }
                else
                {
                    MenuErrorOutput();
                }
            }
            else
            {
                MenuErrorOutput();
            }
        }

        private static void RetrieveKey()
        {
            Console.Write("Enter the key (1-9): ");
            Key = Convert.ToInt32(Console.ReadLine());
        }

        private static void RetrieveMessage()
        {
            Console.Write("Enter the message: ");
            CodeMessage = Console.ReadLine();
        }

        private static void MenuErrorOutput()
        {
            Console.WriteLine("Invalid input, please select an option from the menu");
            MenuSelection();
        }

        private static void Quit()
        {
            Environment.Exit(0);
        }
    }
}
