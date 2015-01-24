using System;

/*
    Problem 5. Formatting Numbers

    Write a program that reads 3 numbers:
    integer a (0 <= a <= 500)
    floating-point b
    floating-point c
    The program then prints them in 4 virtual columns on the console. Each column should have a width of 10 characters.
    The number a should be printed in hexadecimal, left aligned
    Then the number a should be printed in binary form, padded with zeroes
    The number b should be printed with 2 digits after the decimal point, right aligned
    The number c should be printed with 3 digits after the decimal point, left aligned.
*/

class FormattingNumbers
{
    static void Main()
    {
        // Get number a
        Console.WriteLine("Enter integer number a:");
        int numA;

        // Check if the number a can be parsed in int
        // Check if a is not in interval (0 <= a <= 500) and repeat until a is in the interval
        while (!(int.TryParse(Console.ReadLine(), out numA)) || (numA < 0) || (numA > 500))
        {
            Console.WriteLine("Input was not in correct format! You must enter integer number!");
            Console.WriteLine("Enter integer number a:");
        }

        // Get number b
        Console.Write("Enter floating-point number b: ");
        double numB;

        while (!(double.TryParse(Console.ReadLine().Replace(',', '.'), out numB)))
        {
            Console.WriteLine("Input was not in correct format! You must enter floating-point number!");
            Console.WriteLine("Enter floating-point number b:");
        }

        // Get number c
        Console.Write("Enter floating-point number c: ");
        double numC;

        while (!(double.TryParse(Console.ReadLine().Replace(',', '.'), out numC)))
        {
            Console.WriteLine("Input was not in correct format! You must enter floating-point number!");
            Console.WriteLine("Enter floating-point number c:");
        }

        // Printing the numbers
        Console.WriteLine("{0, -10:X}|{1}|{2, 10:F2}|{3, -10:F3}|", numA, Convert.ToString(numA, 2).PadLeft(10, '0'), numB, numC);
    }
}