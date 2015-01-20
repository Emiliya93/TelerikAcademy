using System;

/*
    Problem 8. Prime Number Check

    Write an expression that checks if given positive integer number n (n = 100) is prime
    (i.e. it is divisible without remainder only to itself and 1).
*/
class PrimeNumberCheck
{
    static void Main()
    {
        Console.WriteLine("Enter number:");
        int number = int.Parse(Console.ReadLine());
        bool isPrime = true;

        if (number < 2)
        {
            isPrime = false;
        }
        else if ((number == 2) || (number == 3))
        {
            isPrime = true;
        }
        else
        {
            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if ((number % i) == 0)
                {
                    isPrime = false;
                }
            }
        }

        Console.WriteLine(isPrime);
    }
}