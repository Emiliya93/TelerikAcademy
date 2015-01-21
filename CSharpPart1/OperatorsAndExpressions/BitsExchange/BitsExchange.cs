using System;

/*
    Problem 15.* Bits Exchange

    Write a program that exchanges bits 3, 4 and 5 with bits 
                                        24, 25 and 26 of given 32-bit unsigned integer.
*/
class BitsExchange
{
    static void Main()
    {
        Console.Write("Enter unsigned integer: ");
        uint number = uint.Parse(Console.ReadLine());
        
        uint bit3 = (number >> 3) & 1;
        uint bit4 = (number >> 4) & 1;
        uint bit5 = (number >> 5) & 1;
        uint bit24 = (number >> 24) & 1;
        uint bit25 = (number >> 25) & 1;
        uint bit26 = (number >> 26) & 1;

        if (bit3 != bit24)
        {
            number = number ^ (1 << 3);
            number = number ^ (1 << 24);
        }
        if (bit4 != bit25)
        {
            number ^= (1 << 4);
            number ^= (1 << 25);
        }
        if (bit5 != bit26)
        {
            number ^= (1 << 5);
            number ^= (1 << 26);
        }

        Console.WriteLine("Binary result: {0}", Convert.ToString(number, 2).PadLeft(32,'0'));
        Console.WriteLine("Result: {0}", number);
    }
}