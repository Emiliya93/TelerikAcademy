using System;

/*
    Problem 16. Decimal to Hexadecimal Number

    Using loops write a program that converts an integer number to its hexadecimal representation.
    The input is entered as long. The output should be a variable of type string.

    Do not use the built-in .NET functionality.
    Examples:

    decimal         |hexadecimal
    254	            |FE
    6883	        |1AE3
    338583669684	|4ED528CBB4
*/

class DecimalToHexadecimalNumber
{
    static void Main()
    {
        Console.WriteLine("Enter decimal number to convert in hexadecimal form:");
        long decimalNum = long.Parse(Console.ReadLine());
        string hexNum = string.Empty;
        long numeralSystem = 16;

        while (decimalNum > 0)
        {
            long currentDec = decimalNum % numeralSystem;
            decimalNum /= numeralSystem;

            switch (currentDec)
            {
                case 10: hexNum += "A"; break;
                case 11: hexNum += "B"; break;
                case 12: hexNum += "C"; break;
                case 13: hexNum += "D"; break;
                case 14: hexNum += "E"; break;
                case 15: hexNum += "F"; break;
                default:
                    {
                        hexNum += currentDec;
                        break;
                    }
            }
        }

        for (int i = hexNum.Length - 1; i >= 0; i--)
        {
            Console.Write(hexNum[i]);
        }
        Console.WriteLine();
    }
}