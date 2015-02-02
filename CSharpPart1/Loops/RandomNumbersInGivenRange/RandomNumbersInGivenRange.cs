using System;

/*
    Problem 11. Random Numbers in Given Range

    Write a program that enters 3 integers n, min and max (min != max) and prints n random numbers in the range [min...max].
    Examples:

    n	|min	|max	|random numbers
    5	|0	    |1	    |1 0 0 1 1
    10	|10	    |15	    |12 14 12 15 10 12 14 13 13 11

    Note: The above output is just an example. Due to randomness, your program most probably will produce different results.
*/

class RandomNumbersInGivenRange
{
    static Random rand = new Random();

    static void Main()
    {
        Console.WriteLine("Enter number n, min and max for range: ");
        int number = int.Parse(Console.ReadLine());
        int minNum = int.Parse(Console.ReadLine());
        int maxNum = int.Parse(Console.ReadLine());

        if (minNum > maxNum)
        {
            minNum += maxNum;
            maxNum = minNum - maxNum;
            minNum -= maxNum;
        }

        for (int i = 0; i < number; i++)
        {
            Console.Write("{0} ", rand.Next(minNum, maxNum + 1));
        }
    }
}