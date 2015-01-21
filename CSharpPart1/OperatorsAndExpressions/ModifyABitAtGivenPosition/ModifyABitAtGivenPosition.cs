using System;

/*
    Problem 14. Modify a Bit at Given Position

    We are given an integer number n, a bit value v (v=0 or 1) and a position p.
    Write a sequence of operators (a few lines of C# code) that modifies n to hold the value v 
    at the position p from the binary representation of n while preserving all other bits in n.
*/

class ModifyABitAtGivenPosition
{
    static void Main()
    {
        Console.Write("Enter integer number: ");
        int number = int.Parse(Console.ReadLine());

        Console.Write("Enter position: ");
        int position = int.Parse(Console.ReadLine());

        Console.Write("Enter bit value (0 or 1): ");
        byte bitValue = byte.Parse(Console.ReadLine());


        if (bitValue == 1)
        {
            int mask = 1 << position;
            int modifiedNumber = number | mask;
            Console.WriteLine("Binary result: {0}", Convert.ToString(modifiedNumber, 2).PadLeft(16, '0'));
            Console.WriteLine("Result: {0}", modifiedNumber);
        }
        else
        {
            int mask = ~(1 << position);
            int modifiedNumber = number & mask;
            Console.WriteLine("Binary result: {0}", Convert.ToString(modifiedNumber, 2).PadLeft(16, '0'));
            Console.WriteLine("Result: {0}", modifiedNumber);
        }
    }
}