using System;
using System.Collections.Generic;
using System.Linq;

/*
    Problem 10. Find sum in array

    Write a program that finds in given array of integers a sequence of given sum S (if present).
    Example:

    array	            |S	|result
    4, 3, 1, 4, 2, 5, 8	|11	|4, 2, 5
 * 
 * My example:
 * 1, 4, 20, 3, 10, 5   |33 |20, 3, 10
*/

class FindSumInArray
{
    static void Main()
    {
        Console.WriteLine("Enter numbers (separated by space or comma): ");

        int[] numbers = Console.ReadLine()
                               .Split(new char[] { ' ', ',', '.' }, StringSplitOptions.RemoveEmptyEntries)
                               .Select(x => int.Parse(x))
                               .ToArray();
        // int[] numbers = { 4, 3, 1, 4, 2, 5, 8 };
        Console.Write("Enter searched sum: ");
        int sum = int.Parse(Console.ReadLine()); // 11;
        int currentSum = 0;
        List<int> searchedSequence = new List<int>();
        List<int> currentSequence = new List<int>();
        int counter = 0;
        // TODO: make it work with: 1, 4, 0, 0, 3, 10, 5 and sum = 7 

        for (int i = 0; i < numbers.Length; i++)
        {
            currentSum += numbers[i];
            currentSequence.Add(numbers[i]);
            //startIndex = i;
            if (currentSum == sum)
            {
                searchedSequence.AddRange(currentSequence);
                break;
            }
            if (currentSum > sum)
            {
                currentSequence.Clear();
                currentSum = 0;
                counter++;
                i = counter;
                // i--;
            }
        }

        if (searchedSequence.Count > 1)
        {
            Console.WriteLine("{0} = {1}", string.Join(" + ", searchedSequence), sum); 
        }
        else
        {
            Console.WriteLine("No subarray with sum {0} found!", sum);
        }
        
    }
}
