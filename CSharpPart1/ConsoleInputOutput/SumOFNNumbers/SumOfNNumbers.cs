using System;

/*
    Problem 9. Sum of n Numbers

    Write a program that enters a number n and after that enters more n numbers and calculates and prints their sum.
    Note: You may need to use a for-loop.
*/

class SumOfNNumbers
{
    static void Main()
    {
        // Get the number n from console
        Console.Write("Enter integer number n: ");
        int numN;

        while (!(int.TryParse(Console.ReadLine(), out numN)))
        {
            Console.WriteLine("Input was not in correct format. You must enter integer number!");
            Console.Write("Enter integer number n: ");
        }
        // End of getting the number

        double numbers;
        double sum = 0;

        for (int i = 0; i < numN; i++)
        {
            Console.Write("Enter number to calculate: ");

            // Check if the number can be parsed to double
            while (!(double.TryParse(Console.ReadLine(), out numbers)))
            {
                Console.WriteLine("Input was not in correct format. You must enter integer number!");
                Console.Write("Enter integer number to calculate: ");
            }
            // End of check

            sum += numbers;
        }

        Console.WriteLine("The sum is: {0}", sum);
    }
}
