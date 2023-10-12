using System;

namespace Caesar_Cipher
{
    class Message
    {
        internal void Encrypt(int key, string codeMessage)
        {
            ShiftMessage(key, codeMessage);
        }

        internal void Decrypt(int key, string codeMessage)
        {
            key = key * -1; // Decrypting requires counting backwards in the alphabet instead of forwards

            ShiftMessage(key, codeMessage);
        }

        private void ShiftMessage(int key, string codeMessage)
        {
            foreach (var letter in codeMessage)
            {
                int shiftedAscii;
                char shiftedLetter;
                byte originalAscii = Convert.ToByte(letter);

                if (originalAscii >= 65 && originalAscii <= 90 || originalAscii >= 97 && originalAscii <= 122) {
                    shiftedAscii = Convert.ToInt32(originalAscii) + key;
                    shiftedLetter = Convert.ToChar(shiftedAscii);
                }
                else
                {
                    shiftedLetter = letter;
                }

                Console.Write(shiftedLetter);
            }

            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
