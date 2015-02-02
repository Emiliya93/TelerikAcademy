using System;
using System.Globalization;
using System.Threading;

/*
    Problem 5. The Biggest of 3 Numbers

    Write a program that finds the biggest of three numbers.

    Examples:
    a	    |b	    |c	    |biggest
    5	    |2	    |2	    |5
    -2	    |-2	    |1	    |1
    -2	    |4	    |3	    |4
    0	    |-2.5	|5	    |5
    -0.1	|-0.5	|-1.1	|-0.1
*/

class TheBiggestOfThreeNumbers
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

        Console.Write("Enter first number: ");
        double numberOne = double.Parse(Console.ReadLine());

        Console.Write("Enter second number: ");
        double numberTwo = double.Parse(Console.ReadLine());

        Console.Write("Enter third number: ");
        double numberThree = double.Parse(Console.ReadLine());

        double maxNumber = numberOne;

        if (numberTwo > maxNumber)
        {
            maxNumber = numberTwo;
        }
        else if (numberThree > maxNumber)
        {
            maxNumber = numberThree;
        }

        Console.WriteLine(maxNumber);
    }
}