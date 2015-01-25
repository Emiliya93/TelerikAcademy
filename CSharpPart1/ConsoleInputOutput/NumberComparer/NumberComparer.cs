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
        double[] numbers = new double[2];

        for (int i = 0; i < numbers.Length; i++)
        {
            while(!(double.TryParse(Console.ReadLine().Replace(',', '.'), out numbers[i])))
            {
                Console.WriteLine("Input was not in correct format. You must enter real number!");
                Console.Write("Enter number {0} to compare: ", i + 1);
            }
        }

        // Compare the numbers
        Console.WriteLine("Greater -> {0}", Math.Max(numbers[0], numbers[1]));
    }
}
