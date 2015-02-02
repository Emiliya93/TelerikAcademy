using System;
using System.Numerics;

/*
    Problem 8. Catalan Numbers

    In combinatorics, the Catalan numbers are calculated by the following formula: catalan-formula
    Write a program to calculate the nth Catalan number by given n (0 ≤ n ≤ 100).
    Examples:

    n	Catalan(n)
    0	1
    5	42
    10	16796
    15	9694845
*/

class CatalanNumbers
{
    static void Main()
    {
        Console.Write("Enter number n: ");
        int n = int.Parse(Console.ReadLine());

        // Check if n is (0 ≤ n ≤ 100)

        BigInteger factoriel2N = 1;
        BigInteger factorielNPlusOne = 1;
        BigInteger factorielN = 1;

        for (int i = 1; i <= 2 * n; i++)
        {
            factoriel2N *= i;
            if (i <= (n + 1))
            {
                factorielNPlusOne *= i;
            }
            if (i <= n)
            {
                factorielN *= i;
            }
        }

        BigInteger result = factoriel2N / (factorielNPlusOne * factorielN);
        Console.WriteLine(result);
    }
}