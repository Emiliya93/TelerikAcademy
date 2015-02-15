using System;

/*
    Problem 2. Compare arrays

    Write a program that reads two integer arrays from the console and compares them element by element.
*/

class CompareArrays
{
    static void Main()
    {
        Console.WriteLine("Enter number of elements in arrays to compare: ");
        int size = int.Parse(Console.ReadLine());
        int[] firstArray = new int[size];

        Console.WriteLine("Enter elements of first array ({0} elements): ", size);
        for (int i = 0; i < size; i++)
        {
            Console.Write("Enter element {0}: ", i);
            firstArray[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Enter elements of second array (they must be {0}): ", size);
        int[] secondArray = new int[size];

        for (int i = 0; i < size; i++)
        {
            Console.Write("Enter element {0}: ", i);
            secondArray[i] = int.Parse(Console.ReadLine());
        }

        int counter = 0;
        for (int i = 0; i < size; i++)
        {
            if (firstArray[i] == secondArray[i])
            {
                Console.WriteLine("firstArray[{0}] -> {1} = secondArray[{0}] -> {2}", i, firstArray[i], secondArray[i]);
                counter++;
            }
        }

        if (counter == size)
        {
            Console.WriteLine("Arrays are equal!");
        }
        else
        {
            Console.WriteLine("Arrays are not equal!");
        }
    }
}