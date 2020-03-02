using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caesar_Cipher
{
    class Menu
    {
        public void UserSelection()
        {
            PrintOptions();

            var selection = Console.ReadLine();

            if (selection != null)
            {
                Message message = new Message();
                Secret secret = new Secret();

                if (selection == "1")
                {
                    secret.RetrieveKey();
                    secret.RetrieveMessage();

                    message.Encrypt(secret.Key, secret.CodeMessage);
                }
                else if (selection == "2")
                {
                    secret.RetrieveKey();
                    secret.RetrieveMessage();

                    message.Decrypt(secret.Key, secret.CodeMessage);
                }
                else if (selection.ToUpper() == "Q")
                {
                    CaesarCypher.QuitApplication = true;
                }
                else
                {
                    ErrorOutput();
                }
            }
            else
            {
                ErrorOutput();
            }
        }

        private void PrintOptions()
        {
            Console.WriteLine("Please select an option:");
            Console.WriteLine("1 - Encrypt");
            Console.WriteLine("2 - Decrypt");
            Console.WriteLine("Q - Quit");
        }

        private void ErrorOutput()
        {
            Console.WriteLine("Invalid input, please select an option from the menu");
        }
    }
}
