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

        double[] numbers = new double[3];

        // Get the three numbers and store them in array 
        for (int i = 0; i < 3; i++)
        {
            Console.Write("Enter real number {0}: ", i + 1);

            // This loop will implement the body (everything that is between {}) until correct input is entered
            while (!(double.TryParse(Console.ReadLine().Replace(',', '.'), out numbers[i])))
            {
                Console.WriteLine("Input was not in correct format. You must enter real number!");
                Console.Write("Enter real number {0}: ", i + 1);
            }
        }

        // Calculate the sum
        double sum = 0;

        for (int i = 0; i < 3; i++)
        {
            sum += numbers[i];
        }

        Console.WriteLine("The sum of the three numbers: {0}", sum);
    }
}
