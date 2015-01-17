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

        if ((number % 2) == 0)
        {
            Console.WriteLine("The number {0} is even.", number);
        }
        else
        {
            Console.WriteLine("The number {0} is odd", number);
        }

        //string evenOrOdd = (number % 2 == 0) ? "EVEN" : "ODD";
        //Console.WriteLine(evenOrOdd);
    }
}