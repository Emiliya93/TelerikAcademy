using System;
using System.Diagnostics;
using System.Linq;

/*
    Problem 13.* Merge sort

    Write a program that sorts an array of integers using the Merge sort algorithm.
    My Example
    input                       |output
    5, 12, 3, 25, 2, 13         |2,3, 5, 12, 13, 25
    25, 64, 25, 4, 1, 59, -5, 0 |-5, 0, 1, 4, 25, 25, 59, 64
*/

class MergeSort
{
    static void Main()
    {
        //Console.WriteLine("Entr array of integers (separated by an interval or comma): ");
        //int[] numbers = Console.ReadLine()
        //                       .Split(new char[] { ' ', ',', '.' }, StringSplitOptions.RemoveEmptyEntries)
        //                       .Select(int.Parse)
        //                       .ToArray();

        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();

        int[] numbers = { 5, 12, 3, 25, 2, 13 };

        numbers = SplitNumbersInArray(numbers);

        stopwatch.Stop();

        Console.WriteLine(string.Join(", ", numbers));
        Console.WriteLine("Time elapsed: {0:ss\\.fffff}", stopwatch.Elapsed);
    }

    private static int[] SplitNumbersInArray(int[] numbers)
    {
        if (numbers.Length <= 1)
        {
            return numbers;
        }

        int middle = numbers.Length / 2;
        int[] left = new int[middle];
        int[] right = new int[numbers.Length - middle];

        for (int i = 0; i < numbers.Length; i++)
        {
            if (i < middle)
            {
                left[i] = numbers[i];
            }
            else if (i >= middle && i < numbers.Length)
            {
                right[i - middle] = numbers[i];
            }
        }

        left = SplitNumbersInArray(left);
        right = SplitNumbersInArray(right);

        return MergeArrays(left, right);
    }

    private static int[] MergeArrays(int[] left, int[] right)
    {
        int[] merged = new int[left.Length + right.Length];
        int leftIncrease = 0;
        int rightIncrease = 0;
        for (int i = 0; i < merged.Length; i++)
        {
            if (rightIncrease == right.Length || (leftIncrease < left.Length && left[leftIncrease] <= right[rightIncrease]))
            {
                merged[i] = left[leftIncrease];
                leftIncrease++;
            }
            else if (leftIncrease == left.Length || (rightIncrease < right.Length && left[leftIncrease] >= right[rightIncrease]))
            {
                merged[i] = right[rightIncrease];
                rightIncrease++;
            }

            //if (i < left.Length && i < right.Length)
            //{
            //    // TODO: goes here only 1 time, don't increase i to be able to see the element in the other array
            //    if (left[leftIncrease] < right[rightIncrease])
            //    {
            //        merged[i] = left[i];
            //        leftIncrease++;
            //    }
            //    else
            //    {
            //        merged[i] = right[i];
            //        rightIncrease++;
            //    }
            //}
            //else
            //{
            //    for (int j = leftIncrease; j < left.Length; j++)
            //    {
            //        merged[i] = left[j];
            //    }

            //    for (int k = rightIncrease; k < right.Length; k++)
            //    {
            //        merged[i] = right[k];
            //    }
            //}
        }

        return merged;
    }
}
