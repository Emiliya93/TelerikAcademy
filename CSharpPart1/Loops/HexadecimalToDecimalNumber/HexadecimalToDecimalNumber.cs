using System;

/*
    Problem 15. Hexadecimal to Decimal Number

    Using loops write a program that converts a hexadecimal integer number to its decimal form.
    The input is entered as string. The output should be a variable of type long.

    Do not use the built-in .NET functionality.
    Examples:

    hexadecimal	|decimal
    FE	        |254
    1AE3	    |6883
    4ED528CBB4	|338583669684
*/

class HexadecimalToDecimalNumber
{
    static void Main()
    {
        Console.WriteLine("Enter hexadecimal integer number to convert to its decimal form: ");
        string hexNum = Console.ReadLine();
        long decimalNum = 0;

        for (int i = hexNum.Length - 1, j = 0; i >= 0; i--, j++)
        {
            string currentHex = hexNum[i].ToString();
            switch (currentHex)
            {
                case "A": currentHex = "10"; break;
                case "a": currentHex = "10"; break;
                case "B": currentHex = "11"; break;
                case "b": currentHex = "11"; break;
                case "C": currentHex = "12"; break;
                case "c": currentHex = "12"; break;
                case "D": currentHex = "13"; break;
                case "d": currentHex = "13"; break;
                case "E": currentHex = "14"; break;
                case "e": currentHex = "14"; break;
                case "F": currentHex = "15"; break;
                case "f": currentHex = "15"; break;
                default:
                    break;
            }
            decimalNum += long.Parse(currentHex) * (long)Math.Pow(16, j);
        }
        Console.WriteLine(decimalNum);
    }
}
