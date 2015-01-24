using System;

/*
    Problem 7. Sum of 5 Numbers

    Write a program that enters 5 numbers (given in a single line, separated by a space), calculates and prints their sum.
*/

class SumOf5Numbers
{
    static void Main()
    {
        Console.Write("Enter 5 numbers, separated by a space: ");
        string numbersString = Console.ReadLine();
        double sum = 0;

        string[] numbersArrey = numbersString.Split(' ');

        for (int i = 0; i < numbersArrey.Length; i++)
        {
            sum += double.Parse(numbersArrey[i]);
        }

        Console.WriteLine("The sum of all numbers is: {0}", sum);
    }
}