using System;
using System.Linq;

/*
    Problem 11. Binary search

    Write a program that finds the index of given element in a sorted array of integers by using the Binary search algorithm.

    My example:
    numbers                   |searched number |out
    1, 2, 3, 5, 10, 15, 23    |3               |index = 2
*/

class BinarySearch
{
    static void Main()
    {
        Console.WriteLine("Enter numbers (separated by an interval or comma: )");
        int[] numbers = Console.ReadLine()
                               .Split(new char[] { ' ', ',', '.' }, StringSplitOptions.RemoveEmptyEntries)
                               .Select(int.Parse)
                               .ToArray();
        Console.Write("Enter searched element: ");
        int searchedNumber = int.Parse(Console.ReadLine());

        Array.Sort(numbers);
        Console.WriteLine(string.Join(", ", numbers));

        int start = 0;
        int end = numbers.Length;

        while (start <= end)
        {
            int mid = (start + end) / 2;
            int num = numbers[mid];
            if (searchedNumber == num)
            {
                Console.WriteLine("The index of searched number {0} is: {1}", searchedNumber, mid);
                return;
            }
            else if (searchedNumber < numbers[mid])
            {
                end = mid - 1;
            }
            else if (searchedNumber > numbers[mid])
            {
                start = mid + 1;
            }
        }
        Console.WriteLine("There is not a number {0} in the sequence!", searchedNumber);
    }
}
