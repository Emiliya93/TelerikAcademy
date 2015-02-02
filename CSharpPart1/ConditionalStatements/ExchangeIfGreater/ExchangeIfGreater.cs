using System;

/*
    Problem 1. Exchange If Greater

    Write an if-statement that takes two double variables a and b and exchanges their values 
    if the first one is greater than the second one. As a result print the values a and b, separated by a space.
*/

class ExchangeIfGreater
{
    static void Main()
    {
        Console.Write("Enter first number: ");
        double a;

        while (!(double.TryParse(Console.ReadLine().Replace(',', '.'), out a)))
        {
            Console.WriteLine("Input was not in correct format! Please enter first real number: ");
        }

        Console.Write("Enter second number: ");
        double b;

        while (!(double.TryParse(Console.ReadLine().Replace(',', '.'), out b)))
        {
            Console.WriteLine("Input was not in correct format! Please enter second real number: ");
        }

        if (a > b)
        {
            a += b;
            b = a - b;
            a -= b;
        }

        Console.WriteLine("{0} {1}", a, b);
    }
}