namespace BinaryToHexadecimal
{
    using System;
    using System.Collections.Generic;

    /*
        Problem 6. binary to hexadecimal

        Write a program to convert binary numbers to hexadecimal numbers (directly).
    */

    class BinaryToHexadecimal
    {
        static void Main()
        {
            string binNum = Console.ReadLine();
            string hexNum = ConvertBinToHex(binNum);
            Console.WriteLine(hexNum);
        }

        private static string ConvertBinToHex(string binNum)
        {
            Dictionary<string, string> binToHex = new Dictionary<string, string>();

            binToHex["0000"] = "0";
            binToHex["0001"] = "1";
            binToHex["0010"] = "2";
            binToHex["0011"] = "3";
            binToHex["0100"] = "4";
            binToHex["0101"] = "5";
            binToHex["0110"] = "6";
            binToHex["0111"] = "7";
            binToHex["1000"] = "8";
            binToHex["1001"] = "9";
            binToHex["1010"] = "A";
            binToHex["1011"] = "B";
            binToHex["1100"] = "C";
            binToHex["1101"] = "D";
            binToHex["1110"] = "E";
            binToHex["1111"] = "F";

            string hexNum = string.Empty;

            while (binNum.Length % 4 != 0)
            {
                binNum = binNum.PadLeft(binNum.Length + 1, '0');   
            }

            for (int i = 0; i < (binNum.Length / 4); i++)
            {
                string substr = binNum.Substring(i * 4, 4);
                foreach (var pair in binToHex)
                {
                    if (substr == pair.Key)
                    {
                        hexNum += pair.Value;
                    }
                }
            }

            return hexNum;
        }
    }
}