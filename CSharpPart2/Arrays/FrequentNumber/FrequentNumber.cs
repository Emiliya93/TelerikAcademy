using System;
using System.Collections.Generic;
using System.Linq;

/*
    Problem 9. Frequent number

    Write a program that finds the most frequent number in an array.
    Example:

    input	                                |result
    4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3	|4 (5 times)
*/

class FrequentNumber
{
    static void Main()
    {
        Console.WriteLine("Enter numbers for array, separated by space or comma:");
        int[] numbers = Console.ReadLine().Split(new char[] { ' ', ',', '.' }, StringSplitOptions.RemoveEmptyEntries)
                                          .Select(int.Parse)
                                          .ToArray();

        Dictionary<int, int> counter = new Dictionary<int, int>();

        for (int i = 0; i < numbers.Length; i++)
        {
            if (!counter.ContainsKey(numbers[i]))
            {
                counter.Add(numbers[i], 0);
            }

            counter[numbers[i]]++;
        }

        int max = int.MinValue;
        int element = 0;
        foreach (KeyValuePair<int, int> pair in counter)
        {
            if (pair.Value > max)
            {
                max = pair.Value;
                element = pair.Key;
            }
        }

        Console.WriteLine("{0} ({1} times)", element, max);
    }
}
