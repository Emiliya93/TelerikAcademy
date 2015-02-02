using System;
using System.Numerics;

/*
    Problem 18.* Trailing Zeroes in N!

    Write a program that calculates with how many zeroes the factorial of a given number n has at its end.
    Your program should work well for very big numbers, e.g. n=100000.
    Examples:

    n	    |trailing zeroes of n!	|explaination
    10	    |2	                    |3628800
    20	    |4	                    |2432902008176640000
    100000	|24999	                |think why
*/

class TrailingZeroesInNFactorial
{
    static void Main()
    {
        Console.Write("Enter number: ");
        int number = int.Parse(Console.ReadLine());
        BigInteger factorial = 1;

        for (int i = 2; i <= number; i++)
        {
            factorial *= i;
        }

        Console.WriteLine(factorial);

        int zeroCounter = 0;
        BigInteger remainder = new BigInteger();
        do
        {
            remainder = factorial % 10;
            factorial /= 10;
            if (remainder == 0)
            {
                zeroCounter++;
            }
        } while (remainder == 0);

        Console.WriteLine(zeroCounter);
    }
}