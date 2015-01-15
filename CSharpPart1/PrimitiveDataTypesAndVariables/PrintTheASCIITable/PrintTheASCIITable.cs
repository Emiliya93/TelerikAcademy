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
        for (int i = 0; i <= 255; i++)
        {
            Console.WriteLine("|Dec|Oct|Hex|Char|");
            Console.WriteLine("|{0,3}|{1,3}|{2,3:X}|{3,4}|", i, Convert.ToString(i, 8), Convert.ToString(i, 16), (char)i);
        }
    }
}
