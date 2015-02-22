using System;
using System.Linq;

/*
    Problem 4. Binary search

    Write a program, that reads from the console an array of N integers and an integer K,
    sorts the array and 
    using the method Array.BinSearch() finds the largest number in the array which is ≤ K.
*/

class BinarySearch
{
    static void Main()
    {
        int[] inputNumbers = ReadIntArray();
        int compareNum = int.Parse(Console.ReadLine());

        int[] numbers = inputNumbers.Where(x => x < compareNum || x == compareNum)
                                    .OrderBy(x => x)
                                    .ToArray();
        Console.WriteLine(string.Join(", ", numbers));
        int largestNumber = numbers[numbers.Length - 1];

        int index = Array.BinarySearch(numbers, largestNumber);
        Console.WriteLine("{0} -> index: {1}", largestNumber, index);

        //Index of original sequence
        int i = Array.BinarySearch(inputNumbers, largestNumber);
        Console.WriteLine("{0} -> origin numbers index: {1}", largestNumber, i);
    }

    private static int[] ReadIntArray()
    {
        Console.WriteLine("Enter numbers, separated by space or comma: ");
        string input = Console.ReadLine();
        string[] numbersString = input.Split(new char[] { ' ', ',', '.' }, StringSplitOptions.RemoveEmptyEntries);
        int[] numbers = numbersString.Select(int.Parse).ToArray();
        return numbers;
    }
}
