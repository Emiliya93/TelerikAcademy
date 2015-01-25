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
        Console.WriteLine("Enter integer number a (0 <= a <= 500):");
        int numA;
        string input = Console.ReadLine();
        bool isParsable = int.TryParse(input, out numA);

        // Check if the number a can be parsed in int
        // Check if a is not in interval (0 <= a <= 500) and repeat until a is in the interval
        while ((isParsable == false) || (numA < 0) || (numA > 500))
        {
            Console.WriteLine("Input was not in correct format! You must enter integer number!");
            Console.WriteLine("Enter integer number a:");
            input = Console.ReadLine();
            isParsable = int.TryParse(input, out numA);
        }

        // Get number b
        Console.Write("Enter floating-point number b: ");
        double numB;
        input = Console.ReadLine().Replace(',', '.');
        isParsable = double.TryParse(input, out numB);

        while (isParsable == false)
        {
            Console.WriteLine("Input was not in correct format! You must enter floating-point number!");
            Console.WriteLine("Enter floating-point number b:");
            input = Console.ReadLine().Replace(',', '.');
            isParsable = double.TryParse(input, out numB);
        }

        // Get number c
        Console.Write("Enter floating-point number c: ");
        double numC;
        input = Console.ReadLine().Replace(',', '.');
        isParsable = double.TryParse(input, out numC);

        while (isParsable == false)
        {
            Console.WriteLine("Input was not in correct format! You must enter floating-point number!");
            Console.WriteLine("Enter floating-point number c:");
            input = Console.ReadLine().Replace(',', '.');
            isParsable = double.TryParse(input, out numC);
        }

        // Printing the numbers
        Console.WriteLine("{0, -10:X}|{1}|{2, 10:F2}|{3, -10:F3}|", numA, Convert.ToString(numA, 2).PadLeft(10, '0'), numB, numC);
    }
}