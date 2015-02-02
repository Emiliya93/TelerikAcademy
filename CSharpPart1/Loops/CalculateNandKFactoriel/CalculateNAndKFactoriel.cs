using System;

/*
    Problem 6. Calculate N! / K!

    Write a program that calculates n! / k! for given n and k (1 < k < n < 100).
    Use only one loop.
    Examples:

    n	k	n! / k!
    5	2	60
    6	5	6
    8	3	6720
*/

class CalculateNAndKFactoriel
{
    static void Main()
    {
        Console.WriteLine("Enter n and k (1 < k < n < 100):");
        int n = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());

        if (k <= 1 || k > n)
        {
            Console.WriteLine("K is not in interval: 1 < K < n");
            return;
        }
        if (n < k || n > 100)
        {
            Console.WriteLine("N is not in interval: k < N < 100");
            return;
        }

        int factorielN = 1;
        int factorielK = 1;

        for (int i = 1; i <= n; i++)
        {
            if (i <= k)
            {
                factorielK *= i;
            }
            factorielN *= i;
        }

        Console.WriteLine(factorielN / factorielK);
    }
}
