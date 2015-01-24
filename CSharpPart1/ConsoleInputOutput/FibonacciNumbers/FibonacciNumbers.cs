using System;

/*
    Problem 10. Fibonacci Numbers

    Write a program that reads a number n and prints on the console the first n members of the Fibonacci sequence
    (at a single line, separated by comma and space - ,) : 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, ….
    Note: You may need to learn how to use loops.
*/

class FibonacciNumbers
{
    static void Main()
    {
        // Get the number n from console
        Console.Write("Enter integer number n: ");
        int numN;

        while (!(int.TryParse(Console.ReadLine(), out numN)))
        {
            Console.WriteLine("Input was not in correct format. You must enter integer number!");
            Console.Write("Enter integer number n: ");
        }
        // End of getting the number

        int a = 0;
        int b = 1;
        string separator = ", ";

        for (int i = 0; i < numN; i++)
        {
            Console.Write(a);

            // Check if the number n is 1, and if the for loop is on the last number, than don't print the separator ", "
            if ((numN != 1) && (i != (numN - 1)))
            {
                Console.Write("{0}", separator);
                a = a + b;
                b = a - b;
            }
            else if (i == (numN - 1))
            {
                Console.WriteLine();
            }
        }
    }
}
