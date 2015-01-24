using System;

/*
    Problem 4. Number Comparer

    Write a program that gets two numbers from the console and prints the greater of them.
    Try to implement this without if statements.
*/

class NumberComparer
{
    static void Main()
    {
        // Get first number to compare
        Console.Write("Enter first number to compare: ");
        double firstNumber;

        while(!(double.TryParse(Console.ReadLine().Replace(',', '.'), out firstNumber)))
        {
            Console.WriteLine("Input was not in correct format. You must enter real number!");
            Console.Write("Enter first number to compare: ");
        }

        // Get second number to compare
        Console.Write("Enter second number to compare: ");
        double secondNumber;

        while (!(double.TryParse(Console.ReadLine().Replace(',', '.'), out secondNumber)))
        {
            Console.WriteLine("Input was not in correct format. You must enter real number!");
            Console.Write("Enter second number to compare: ");
        }

        // Compare the numbers
        Console.WriteLine("Greater -> {0}", Math.Max(firstNumber, secondNumber));
    }
}
