using System;

/*
    Problem 3. Compare char arrays

    Write a program that compares two char arrays lexicographically (letter by letter).
*/

class CompareCharArrays
{
    static void Main()
    {
        Console.WriteLine("Enter some chars for first array:");
        string firstArray = Console.ReadLine();

        Console.WriteLine("Enter some chars for second array (they must be {0}):", firstArray.Length);
        string secondArray = Console.ReadLine();

        // Compare the arrays
        for (int i = 0; i < firstArray.Length; i++)
        {
            if (firstArray.Length != secondArray.Length)
            {
                Console.WriteLine("Arrays must be with equal number of chars!");
                break;
            }
            if (firstArray[i] == secondArray[i])
            {
                Console.WriteLine("firstArray[{0}] -> {1} = secondArray[{0}] -> {2}", i, firstArray[i], secondArray[i]);
            }
        }
    }
}