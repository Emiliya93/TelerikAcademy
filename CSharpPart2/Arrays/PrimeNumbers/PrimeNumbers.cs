using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

/*
    Problem 15. Prime numbers

    Write a program that finds all prime numbers in the range [1...10 000 000]. Use the Sieve of Eratosthenes algorithm.
*/

class PrimeNumbers
{
    static void Main()
    {
        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();
        
        bool[] notPrime = new bool[10000001];

        for (int i = 0; i < Math.Sqrt(notPrime.Length); i++)
        {
            if (i == 0 || i == 1)
            {
                notPrime[i] = true;
                continue;
            }

            if (notPrime[i] != true)
            {
                for (int j = i; j < notPrime.Length; j += i)
                {
                    if (j == i)
                    {
                        continue;
                    }
                    notPrime[j] = true;
                }
            }
        }

        stopwatch.Stop();

        Console.WriteLine("Time elapsed: {0:ss\\.fffff} sec", stopwatch.Elapsed);

        // Print the numbers (takes too much time, uncomment to see it)

        //for (int i = 0; i < notPrime.Length; i++)
        //{
        //    if (notPrime[i] == false)
        //    {
        //        Console.Write("{0} ", i);
        //    }

        //}
        //Console.WriteLine();
    }
}