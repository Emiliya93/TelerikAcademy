namespace EncodeDecode
{
    using System;
    using System.Text;
     
    /*
        Problem 7. Encode/decode

        Write a program that encodes and decodes a string using given encryption key (cipher).
        The key consists of a sequence of characters.
        The encoding/decoding is done by performing XOR (exclusive or) operation over
        the first letter of the string with the first of the key, the second – with the second, etc.
        When the last key character is reached, the next is the first.
    */

    class EncodeDecode
    {
        static void Main()
        {
            Console.WriteLine("Enter encryption key (cipher): ");
            string encryptionKey = Console.ReadLine();

            Console.WriteLine("Enter string to encode/decode: ");
            string text = Console.ReadLine();
            StringBuilder encrypted = new StringBuilder(text.Length);

            for (int i = 0, j = 0; i < text.Length; i++, j++)
            {
                if (j == encryptionKey.Length - 1)
                {
                    j = 0;
                }
                encrypted.Append((char)(text[i] ^ encryptionKey[j]));
            }
            Console.WriteLine("Encrypted ->{0}<-", encrypted);

            StringBuilder decrypted = new StringBuilder(encrypted.Length);
            for (int i = 0, j = 0; i < encrypted.Length; i++, j++)
            {
                if (j == encryptionKey.Length - 1)
                {
                    j = 0;
                }
                decrypted.Append((char)(encrypted[i] ^ encryptionKey[j]));
            }
            Console.WriteLine("Decrypted ->{0}<-", decrypted);
        }
    }
}
