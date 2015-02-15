using System;
using System.Collections.Generic;
using System.Linq;

/*
    Problem 17.* Subset K with sum S

    Write a program that reads three integer numbers N, K and S and an array of N elements from the console.
    Find in the array a subset of K elements that have sum S or indicate about its absence.
*/

// NOT implemented

class SubsetKWithSumS
{
    static void Main()
    {
        Console.Write("Enter number of elements of array: ");
        int sizeOfArray = int.Parse(Console.ReadLine());
        int[] numbers = ReadArrayFromConsole(sizeOfArray);

        Console.Write("Enter subset of how elements to search: ");
        int elementsCount = int.Parse(Console.ReadLine());

        Console.Write("Enter sum to search: ");
        int searchedSum = int.Parse(Console.ReadLine());

        // TODO: continue problem
    }

    private static int[] ReadArrayFromConsole(int sizeOfArray)
    {
        int[] numbers = new int[sizeOfArray];
        for (int i = 0; i < sizeOfArray; i++)
        {
            Console.Write("Enter number {0}: ", i + 1);
            numbers[i] = int.Parse(Console.ReadLine());
        }
        return numbers;
    }
}
