namespace NFactorial
{
    using System;
    using System.Numerics;

    /*
        Problem 10. N Factorial

        Write a program to calculate n! for each n in the range [1..100].
        Hint: Implement first a method that multiplies a number represented as array of digits by given integer number.
    */

    class NFactorial
    {
        static void Main()
        {
            int startNum = 1;
            int endNum = 100;
            BigInteger factorial = 1;  

            for (int i = startNum; i <= endNum; i++)
            {
                factorial = FindFactorial(i);
                Console.WriteLine("{0, 3}! = {1}", i, factorial);
            }
        }

        private static BigInteger FindFactorial(int number)
        {
            BigInteger factorial = 1;
            for (int i = 2; i <= number; i++)
            {
                factorial *= i;
            }
            return factorial;
        }
    }
}
