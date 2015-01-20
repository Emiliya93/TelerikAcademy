using System;

/*
    Problem 14.* Print the ASCII Table

    Find online more information about ASCII (American Standard Code for Information Interchange)
    and write a program that prints the entire ASCII table of characters on the console (characters from 0 to 255).
    Note: Some characters have a special purpose and will not be displayed as expected. You may skip them or display them differently.

    Note: You may need to use for-loops (learn in Internet how).
*/

class PrintTheASCIITable
{
    static void Main()
    {
        // To see the hole table you have to change console property:
        // Upper left corner of the console->Properties->Layout->Screen Buffer Size->Height->800
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        for (int i = 0; i <= 255; i++)
        {
            string separator = new string('-', 18);

            if (!char.IsControl((char)i))
            {
                Console.WriteLine("|Dec|Oct|Hex|Char|");
                Console.WriteLine("|{0,3}|{1,3}|{2,3:X}|{3,4}|", i, Convert.ToString(i, 8), Convert.ToString(i, 16), (char)i);
                Console.WriteLine(separator);
            }
        }
    }
}
