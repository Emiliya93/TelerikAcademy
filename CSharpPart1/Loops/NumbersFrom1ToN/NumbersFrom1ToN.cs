using System;

/*
    Problem 1. Numbers from 1 to N

    Write a program that enters from the console a positive integer n and prints 
    all the numbers from 1 to n, on a single line, separated by a space.
    Examples:

    n	output
    3	1 2 3
    5	1 2 3 4 5
*/

class NumbersFrom1ToN
{
    static void Main()
    {
        Console.Write("Please enter a positive integer number: ");
        int userInput = int.Parse(Console.ReadLine());

        for (int i = 0; i < userInput; i++)
        {
            Console.Write(i + 1 + " ");
        }
        Console.WriteLine();
    }
}