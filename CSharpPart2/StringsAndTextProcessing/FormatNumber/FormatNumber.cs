namespace FormatNumber
{
    using System;
    using System.Globalization;
    using System.Text;
    using System.Threading;

    /*
        Problem 11. Format number

        Write a program that reads a number and prints it as a decimal number, hexadecimal number, percentage and in scientific notation.
        Format the output aligned right in 15 symbols.
    */

    class FormatNumber
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine("|{0,15}|{0,15:X}|{0,15:P2}|{0,15:E}|",number);
        }
    }
}
