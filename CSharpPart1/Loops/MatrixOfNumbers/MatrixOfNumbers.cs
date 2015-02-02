using System;

/*
    Problem 9. Matrix of Numbers

    Write a program that reads from the console a positive integer number n (1 ≤ n ≤ 20) 
    and prints a matrix like in the examples below. Use two nested loops.
    Examples:

    n = 2   matrix      n = 3   matrix      n = 4   matrix
            1 2                 1 2 3               1 2 3 4
            2 3                 2 3 4               2 3 4 5
                                3 4 5               3 4 5 6
                                                    4 5 6 7
*/

class MatrixOfNumbers
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());

        for (int row = 0; row < number; row++)
        {
            for (int col = 0; col < number; col++)
            {
                Console.Write("{0, 2} ", row + col + 1);
            }
            Console.WriteLine();
        }
    }
}