using System;

/*
    Problem 12. Extract Bit from Integer

    Write an expression that extracts from given integer n the value of given bit at index p
*/
class ExtractBitFromInteger
{
    static void Main()
    {
        Console.Write("Enter integer number: ");
        int number = int.Parse(Console.ReadLine());

        Console.Write("Enter index of searched bit: ");
        int index = int.Parse(Console.ReadLine());

        int mask = 1 << index;
        int numberAndMask = number & mask;
        int bit = numberAndMask >> index;

        Console.WriteLine(bit);
    }
}