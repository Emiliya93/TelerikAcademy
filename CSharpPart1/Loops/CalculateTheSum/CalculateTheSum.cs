using System;

/*
    Problem 5. Calculate 1 + 1!/X + 2!/X^2 + … + N!/X^N

    Write a program that, for a given two integer numbers n and x, calculates the sum S = 1 + 1!/x + 2!/x2 + … + n!/x^n.
    Use only one loop. Print the result with 5 digits after the decimal point.
    Examples:

    n	x	S
    3	2	2.75000
    4	3	2.07407
    5	-4	0.75781
*/

class CalculateTheSum
{
    static void Main()
    {
        Console.WriteLine("Please enter two integer numbers n and x (S = 1 + 1!/x + 2!/x2 + … + n!/x^n):");
        int n = int.Parse(Console.ReadLine());
        int x = int.Parse(Console.ReadLine());
        double sum = 1;

        int factoriel = 1;

        for (int i = 1; i <= n; i++)
        {
            factoriel *= i;
            sum += factoriel / Math.Pow(x, i);
        }

        Console.WriteLine("{0:F5}", sum);


        //for (int i = 1; i <= n; i++)
        //{
        //    int factoriel = 1;
        //    int num = i;
        //    while (num > 0)
        //    {
        //        factoriel *= num;
        //        num--;
        //    }

        //    sum += factoriel / Math.Pow(x, i);
        //}
    }
}