using System;
using System.Globalization;
using System.Threading;

/*
    Problem 1. Sum of 3 Numbers

    Write a program that reads 3 real numbers from the console and prints their sum. 
*/

class SumOf3Numbers
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

        // Get first number from console
        Console.Write("Enter first real number: ");
        double numberOne;

        // This loop will implement the body (everything that is between {}) until correct input is entered
        while (!(double.TryParse(Console.ReadLine().Replace(',', '.'), out numberOne)))
        {
            Console.WriteLine("Input was not in correct format. You must enter real number!");
            Console.Write("Enter first real number: ");
        }
        // End of getting the first number

        // Get second number from console
        Console.Write("Enter second real number: ");
        double numberTwo;

        while (!(double.TryParse(Console.ReadLine().Replace(',', '.'), out numberTwo)))
        {
            Console.WriteLine("Input was not in correct format. You must enter real number!");
            Console.Write("Enter second real number: ");
        }
        // End of getting the second number

        // Get third number from console
        Console.Write("Enter third real number: ");
        double numberThree;

        while (!(double.TryParse(Console.ReadLine().Replace(',', '.'), out numberThree)))
        {
            Console.WriteLine("Input was not in correct format. You must enter real number!");
            Console.Write("Enter third real number: ");
        }
        // End of getting the third number

        // Calculate the sum
        double sum = numberOne + numberTwo + numberThree;

        Console.WriteLine("The sum of the three numbers: {0}", sum);
    }
}
