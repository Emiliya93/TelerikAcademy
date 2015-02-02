using System;

/*
    Problem 14. Decimal to Binary Number

    Using loops write a program that converts an integer number to its binary representation.
    The input is entered as long. The output should be a variable of type string.

    Do not use the built-in .NET functionality.
    Examples:

    decimal	    |binary
    0	        |0
    3	        |11
    43691	    |1010101010101011
    236476736	|1110000110000101100101000000
*/

class DecimalToBinaryNumber
{
    static void Main()
    {
        Console.Write("Enter decimal number: ");
        long decimalNum = long.Parse(Console.ReadLine());
        string binaryNum = string.Empty;

        while (decimalNum > 0)
        {
            binaryNum += (decimalNum % 2).ToString();
            decimalNum /= 2;
        }

        for (int i = binaryNum.Length - 1; i >= 0; i--)
        {
            Console.Write(binaryNum[i]);
        }
        Console.WriteLine();
    }
}