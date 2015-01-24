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
        uint firstNumber;

        while (!(uint.TryParse(Console.ReadLine(), out firstNumber)))
        {
            Console.WriteLine("Input was not in correct format. You must enter positive integer number!");
            Console.Write("Enter first positive integer number: ");
        }
        // End of getting the number

        // Get the second positive integer number
        Console.Write("Enter first positive integer number: ");
        uint secondNumber;

        while (!(uint.TryParse(Console.ReadLine(), out secondNumber)))
        {
            Console.WriteLine("Input was not in correct format. You must enter positive integer number!");
            Console.Write("Enter second positive integer number: ");
        }
        // End of getting the number

        // If the second number is smaller than first, exchange them
        if (secondNumber < firstNumber)
        {
            firstNumber += secondNumber;
            secondNumber = firstNumber - secondNumber;
            firstNumber -= secondNumber;
        }
        // End of exchange

        // Declare some helping variables
        int p = 0;
        string separator = ", ";

        // Create List to store the numbers that are in the interval and the reminder of the division by 5 is 0, 
        // so the printing can be after "for" loop
        List<int> listOfNumbers = new List<int>();

        // Find the numbers and store them in the List
        for (int i = 0; i <= secondNumber; i++)
        {
            if ((i >= firstNumber) && (i <= secondNumber) && (i % 5 == 0))
            {
                p++;
                listOfNumbers.Add(i);
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

        // Print the numbers
        for (int i = 0; i < listOfNumbers.Count; i++)
        {
            Console.Write(listOfNumbers[i]);

            // Check if the numbers in the list are more than 1 and if the "for" loop is not on the last number,
            // than print the separator ", "
            if ((listOfNumbers.Count > 1) && (i != (listOfNumbers.Count - 1)))
            {
                Console.Write(separator);
            }
            else if (listOfNumbers.Count == 1)
            {
                Console.WriteLine(listOfNumbers[i]);
            }
            else if (i == (listOfNumbers.Count - 1))
            {
                Console.WriteLine();
            }
        }
    }
}