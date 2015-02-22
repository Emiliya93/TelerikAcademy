namespace SortingArray
{
    using System;
    using AppearanceCount;

    /*
        Problem 9. Sorting array

        Write a method that return the maximal element in a portion of array of integers starting at given index.
        Using it write another method that sorts an array in ascending / descending order.
    */

    class SortingArray
    {
        static void Main()
        {
            int[] numbers = AppearanceCount.ReadArrayOfInts();

            Console.Write("Enter index: ");
            int index = int.Parse(Console.ReadLine());
            while (index < 0 || index >= numbers.Length)
            {
                Console.WriteLine("No such index in the array! Choose one from 0 to {0}", numbers.Length - 1);
                index = int.Parse(Console.ReadLine());
            }

            int max = MaxElementInArray(index, numbers);
            Console.WriteLine(max);
        }

        private static int MaxElementInArray(int index, int[] numbers)
        {
            int max = numbers[index];
            for (int i = index + 1; i < numbers.Length; i++)
            {
                if (numbers[i] > max)
                {
                    max = numbers[i];
                }
            }
            return max;
        }
    }
}