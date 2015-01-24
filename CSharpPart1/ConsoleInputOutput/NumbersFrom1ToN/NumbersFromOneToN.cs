using System;

/*
    Problem 8. Numbers from 1 to n

    Write a program that reads an integer number n from the console and prints all the numbers in the interval [1..n], each on a single line.
    Note: You may need to use a for-loop.
*/

class NumbersFromOneToN
{
    static void Main()
    {
        // Get the number n from console
        Console.Write("Enter integer number n: ");
        int num;

        while (!(int.TryParse(Console.ReadLine(), out num)))
        {
            Console.WriteLine("Input was not in correct format. You must enter integer number!");
            Console.Write("Enter integer number n: ");
        }
        // End of getting the number

        // Print the numbers
        for (int i = 1; i <= num; i++)
        {
            Console.WriteLine(i);
        }
    }
}