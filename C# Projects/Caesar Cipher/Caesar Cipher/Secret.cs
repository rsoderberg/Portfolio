using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caesar_Cipher
{
    class Secret
    {
        internal int Key { get; set; }
        internal string CodeMessage { get; set; }

        protected internal void RetrieveKey()
        {
            Console.Write("Enter the key (1-9): ");
            Key = Convert.ToInt32(Console.ReadLine());
        }

        protected internal void RetrieveMessage()
        {
            Console.Write("Enter the message: ");
            CodeMessage = Console.ReadLine();
        }
    }
}
