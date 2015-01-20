using System;
using System.Text;

/*
    Problem 8. Isosceles Triangle

    Write a program that prints an isosceles triangle of 9 copyright symbols ©, something like this:

    Note: The © symbol may be displayed incorrectly at the console so you may need to change the console character encoding to UTF-8
    and assign a Unicode-friendly font in the console.
    Note: Under old versions of Windows the © symbol may still be displayed incorrectly, regardless of how much effort you put to fix it.
*/

class IsoscelesTriangle
{
    static void Main()
    {
        // Change the console character encoding to UTF8
        Console.OutputEncoding = Encoding.UTF8;

        char copyrightSymbol = '\u00A9';
        char space = ' ';

        // Print the symbols 
        Console.WriteLine("{0}{0}{0}{1}{0}{0}{0}", space, copyrightSymbol);
        Console.WriteLine("{0}{0}{1}{0}{1}{0}{0}", space, copyrightSymbol);
        Console.WriteLine("{0}{1}{0}{0}{0}{1}{0}", space, copyrightSymbol);
        Console.WriteLine("{1}{0}{1}{0}{1}{0}{1}", space, copyrightSymbol);
    }
}