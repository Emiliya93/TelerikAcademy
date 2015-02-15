using System;
using System.Collections.Generic;

/*
    Problem 7. Selection sort

    Sorting an array means to arrange its elements in increasing order. Write a program to sort an array.
    Use the Selection sort algorithm: 
    Find the smallest element, move it at the first position, 
    find the smallest from the rest, move it at the second position, etc.
*/

class SelectionSort
{
    static void Main()
    {
        Console.WriteLine("Enter sequence of numbers (separated by space or comma):");
        string input = Console.ReadLine();

        string[] numbersArrey = input.Split(new char[] { ' ', ',', '.' }, StringSplitOptions.RemoveEmptyEntries);
        int length = numbersArrey.Length;
        List<int> numbers = new List<int>();
        List<int> sortedNumbers = new List<int>();

        for (int i = 0; i < length; i++)
        {
            numbers.Add(int.Parse(numbersArrey[i]));
        }

        int minNumber = int.MaxValue;

        while (numbers.Count > 0)
        {
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] < minNumber)
                {
                    minNumber = numbers[i];
                }
            }
            sortedNumbers.Add(minNumber);
            numbers.Remove(minNumber);
            minNumber = int.MaxValue;
        }

        string numbersString = string.Join(", ", sortedNumbers);
        Console.WriteLine(numbersString);
    }
}
