using System;
using System.Numerics;

/*
    Problem 7. Calculate N! / (K! * (N-K)!)

    In combinatorics, the number of ways to choose k different members out of a group of n different elements
    (also known as the number of combinations) is calculated by the following formula:
    For example, there are 2598960 ways to withdraw 5 cards out of a standard deck of 52 cards.
    Your task is to write a program that calculates n! / (k! * (n-k)!) for given n and k (1 < k < n < 100). Try to use only two loops.
    Examples:

    n	k	n! / (k! * (n-k)!)
    3	2	3
    4	2	6
    10	6	210
    52	5	2598960
*/

class CalculateNFactorielDividedByKFactorielStatement
{
    static void Main()
    {
        Console.WriteLine("Enter n elements and k members to calculate the combinations");
        Console.WriteLine("(1 < k < n < 100):");
        long n = long.Parse(Console.ReadLine());
        long k = long.Parse(Console.ReadLine());
        BigInteger nMinusK = n - k;
        BigInteger factorielNMinusK = 1;
        BigInteger factorielN = 1;
        BigInteger factorielK = 1;

        for (int i = 1; i <= nMinusK; i++)
        {
            factorielNMinusK *= i;
        }

        for (int i = 1; i <= n; i++)
        {
            if (i <= k)
            {
                factorielK *= i;
            }
            factorielN *= i;
        }

        BigInteger combinations = factorielN / (factorielK * factorielNMinusK);
        Console.WriteLine(combinations);
    }
}
