using System;
using System.Linq;
using System.Collections.Generic;

/*
    Problem 8. Maximal sum

    Write a program that finds the sequence of maximal sum in given array.
    Example:

    input	                            result
    2, 3, -6, -1, 2, -1, 6, 4, -8, 8	2, -1, 6, 4
    Can you do it with only one loop (with single scan through the elements of the array)?
*/

class MaximalSum
{
    static void Main()
    {
        Console.WriteLine("Enter numbers: ");

        int[] numbers = Console.ReadLine()
                               .Split(new char[] { ' ', ',', '.' }, StringSplitOptions.RemoveEmptyEntries)
                               .Select(x => int.Parse(x))
                               .ToArray();

        int currentSum = 0;
        int maxSum = int.MinValue;
        List<int> currentSequence = new List<int>();
        List<int> maxSumSequence = new List<int>();
        string numbersString;

        // If all numbers are negative, the biggest sum is the biggest negative number
        if (numbers.Max() <= 0)
        {
            Console.WriteLine(numbers.Max());
        }
        // If all numbers are positive, the biggest sum is the sum of all of them
        else if (numbers.Min() >= 0)
        {
            numbersString = string.Join(" + ", numbers);
            maxSum = numbers.Sum();
            Console.WriteLine(numbersString + " = " + maxSum);
        }
        // There are positive and negative numbers
        // Use Kadane’s Algorithm
        else
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                currentSequence.Add(numbers[i]);
                currentSum += numbers[i];

                if (currentSum > maxSum)
                {
                    maxSum = currentSum;
                    maxSumSequence.Clear();
                    maxSumSequence.AddRange(currentSequence);
                }
                else if (currentSum <= 0)
                {
                    currentSequence.Clear();
                    currentSum = 0;
                }
            }
            numbersString = string.Join(" + ", maxSumSequence);
            numbersString += " = " + maxSum;
            Console.WriteLine(numbersString);
        }
    }
}