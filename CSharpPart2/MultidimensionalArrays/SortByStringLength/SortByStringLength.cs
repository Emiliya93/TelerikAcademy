using System;
using System.Linq;

/*
    Problem 5. Sort by string length

    You are given an array of strings. Write a method that sorts the array 
    by the length of its elements (the number of characters composing them).
*/

class SortByStringLength
{
    static void Main()
    {
        string[] arrayOfStrings = ReadStringArray();

        var result = arrayOfStrings.OrderBy(s => s.Length).ToArray();

        for (int i = 0; i < result.Length; i++)
        {
            Console.WriteLine(result[i]);
        }
    }

    private static string[] ReadStringArray()
    {
        Console.WriteLine("Enter number of strings: ");
        int count = int.Parse(Console.ReadLine());
        string[] strings = new string[count];

        for (int i = 0; i < count; i++)
        {
            Console.Write("Enter string {0}: ", i + 1);
            strings[i] = Console.ReadLine();
        }

        return strings;
    }
}
