using System;
using System.Diagnostics;
using System.Linq;

/*
    Problem 14. Quick sort

    Write a program that sorts an array of integers using the Quick sort algorithm.
*/

class QuickSort
{
    static void Main()
    {
        Console.WriteLine("Entr array of integers (separated by an interval or comma): ");
        int[] numbers = Console.ReadLine()
                               .Split(new char[] { ' ', ',', '.' }, StringSplitOptions.RemoveEmptyEntries)
                               .Select(int.Parse)
                               .ToArray();

        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();

        // int[] numbers = { 5, 12, 3, 25, 2, 13 };
        QuickSortAlgorithm(numbers, 0, numbers.Length - 1);

        stopwatch.Stop();

        Console.WriteLine(string.Join(", ", numbers));
        Console.WriteLine("Time elapsed: {0:ss\\.fffff}", stopwatch.Elapsed);
    }

    private static void QuickSortAlgorithm(int[] numbers, int left, int right)
    {
        if (left < right)
        {
            int pivotIndex = Partition(numbers, left, right);

            if (pivotIndex > 1)
                QuickSortAlgorithm(numbers, left, pivotIndex - 1);

            if (pivotIndex + 1 < right)
                QuickSortAlgorithm(numbers, pivotIndex + 1, right);
        }
    }

    private static int Partition(int[] numbers, int left, int right)
    {
        int pivot = numbers[left];

        while (true)
        {
            while (numbers[left] < pivot)
                left++;

            while (numbers[right] > pivot)
                right--;

            if (numbers[left] == numbers[right] && numbers[left] == pivot)
            {
                left++;
            }

            if (left < right)
            {
                //int temp = numbers[right];
                //numbers[right] = numbers[left];
                //numbers[left] = temp;
                numbers[left] ^= numbers[right];
                numbers[right] ^= numbers[left];
                numbers[left] ^= numbers[right];
            }
            else
            {
                return right;
            }
        }
    }
}