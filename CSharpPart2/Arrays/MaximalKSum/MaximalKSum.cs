using System;

/*
    Problem 6. Maximal K sum

    Write a program that reads two integer numbers N and K and an array of N elements from the console.
    Find in the array those K elements that have maximal sum.

 * My Example:
 * N array      K   MaxSum
 * 2 5 6 -5 4   3   6 + 5 + 4 = 15
 * 3 -5 9 15    2   15 + 9 = 24
*/

class MaximalKSum
{
    static void Main()
    {
        Console.Write("Enter count of array elements (N): ");
        int size = int.Parse(Console.ReadLine());

        Console.Write("Enter K: ");
        int elementsCountMaxSum = int.Parse(Console.ReadLine());

        int[] numbers = new int[size];

        // Reads N elements of array
        for (int i = 0; i < size; i++)
        {
            Console.Write("Enter element {0}: ", i + 1);
            numbers[i] = int.Parse(Console.ReadLine());
        }

        // Sort in descedenting order
        Array.Sort(numbers);
        Array.Reverse(numbers);

        int maxSum = 0;
        int[] maxSumNumbers = new int[elementsCountMaxSum];

        for (int i = 0; i < elementsCountMaxSum; i++)
        {
            maxSum += numbers[i];
            maxSumNumbers[i] = numbers[i];
        }

        string maxNumbersString = string.Join(" + ", maxSumNumbers);
        maxNumbersString += " = " + maxSum.ToString();

        Console.WriteLine(maxNumbersString);
    }
}
