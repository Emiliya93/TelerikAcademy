using System;
using System.Collections.Generic;

/*
    Problem 11.* Numbers in Interval Dividable by Given Number

    Write a program that reads two positive integer numbers and prints how many numbers p 
    exist between them such that the reminder of the division by 5 is 0.
*/

class NumbersInInterval
{
    static void Main()
    {
        // Get the first positive integer number
        Console.Write("Enter first positive integer number: ");
        uint startNumber;

        while (!(uint.TryParse(Console.ReadLine(), out startNumber)))
        {
            Console.WriteLine("Input was not in correct format. You must enter positive integer number!");
            Console.Write("Enter first positive integer number: ");
        }
        // End of getting the number

        // Get the second positive integer number
        Console.Write("Enter first positive integer number: ");
        uint endNumber;

        while (!(uint.TryParse(Console.ReadLine(), out endNumber)))
        {
            Console.WriteLine("Input was not in correct format. You must enter positive integer number!");
            Console.Write("Enter second positive integer number: ");
        }
        // End of getting the number

        // If the second number is smaller than first, exchange them
        if (endNumber < startNumber)
        {
            startNumber += endNumber;
            endNumber = startNumber - endNumber;
            startNumber -= endNumber;
        }
        // End of exchange

        // Declare some helping variables
        int p = 0;

        // Create string to store the numbers that are in the interval and the reminder of the division by 5 is 0, 
        // so the printing can be after "for" loop
        string numbers = string.Empty;

        // Find the numbers and store them in the string "numbers"
        for (int i = 0; i <= endNumber; i++)
        {
            if ((i >= startNumber) && (i <= endNumber) && (i % 5 == 0))
            {
                p++;
                numbers += i + ", ";
            }
        }

        // Print p
        Console.WriteLine("p = {0}", p);

        // Check if there aren't any numbers, than print - and quit the program
        if (p == 0)
        {
            Console.WriteLine("-");
            Environment.Exit(0);
        }
        else
        {
            // Print the numbers
            Console.WriteLine(numbers.Substring(0, numbers.Length - 2));
        }
    }
}