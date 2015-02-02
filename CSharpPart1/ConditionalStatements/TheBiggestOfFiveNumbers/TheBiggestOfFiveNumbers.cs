using System;
using System.Globalization;
using System.Threading;

/*
    Problem 6. The Biggest of Five Numbers

    Write a program that finds the biggest of five numbers by using only five if statements.
    Examples:

    |a	    |b	    |c	    |d	    |e	    |biggest|
    |5	    |2	    |2	    |4	    |1	    |5      |
    |-2	    |-22	|1	    |0	    |0	    |1      |
    |-2	    |4	    |3	    |2	    |0	    |4      |
    |0	    |-2.5	|0	    |5	    |5	    |5      |
    |-3	    |-0.5	|-1.1	|-2	    |-0.1	|-0.1   |
*/

class TheBiggestOfFiveNumbers
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

        Console.WriteLine("Enter five numbers: ");
        double a = double.Parse(Console.ReadLine());

        double b = double.Parse(Console.ReadLine());

        double c = double.Parse(Console.ReadLine());

        double d = double.Parse(Console.ReadLine());

        double e = double.Parse(Console.ReadLine());

        double biggestNum = double.MinValue;

        if (a > biggestNum)
        {
            biggestNum = a;
        }
        if (b > biggestNum)
        {
            biggestNum = b;
        }
        if (c > biggestNum)
        {
            biggestNum = c;
        }
        if (d > biggestNum)
        {
            biggestNum = d;
        }
        if (e > biggestNum)
        {
            biggestNum = e;
        }

        Console.WriteLine(biggestNum);
    }
}