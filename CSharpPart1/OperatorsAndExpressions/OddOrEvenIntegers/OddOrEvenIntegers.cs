using System;

/*
    Problem 1. Odd or Even Integers

    Write an expression that checks if given integer is odd or even.
*/

class OddOrEvenIntegers
{
    static void Main()
    {
        Console.WriteLine("Enter a number:");
        int number = int.Parse(Console.ReadLine());

        Console.WriteLine("Is the number {0} odd?", number);
        bool isOdd = (number % 2 == 0) ? false : true;
        Console.WriteLine(isOdd);

        string separator = new string('-', 20);
        Console.WriteLine(separator);

        // With if statement
        Console.WriteLine("With \"if\" statement:");
        if ((number % 2) == 0)
        {
            Console.WriteLine("Is the number {0} odd? -> false", number);
        }
        else
        {
            Console.WriteLine("Is the number {0} odd? -> true", number);
        }
    }
}