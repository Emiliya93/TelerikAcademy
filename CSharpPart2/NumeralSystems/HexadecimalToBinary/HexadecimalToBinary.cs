namespace HexadecimalToBinary
{
    using System;
    using System.Collections.Generic;

    /*
        Problem 5. Hexadecimal to binary

        Write a program to convert hexadecimal numbers to binary numbers (directly).
    */

    class HexadecimalToBinary
    {
        static void Main()
        {
            Console.Write("Enter hexadecimal number: ");
            string hexNum = Console.ReadLine();
            List<string> binNum = ConvertHexToBin(hexNum);
            Console.Write("{0} to binary -> ", hexNum);
            Console.WriteLine(string.Join(" ", binNum));

        }

        private static List<string> ConvertHexToBin(string hexNum)
        {
            string[] hexToBin = {
                                 "0000",    //0x0
                                 "0001",    //0x1
                                 "0010",    //0x2
                                 "0011",    //0x3
                                 "0100",    //0x4
                                 "0101",    //0x5
                                 "0110",    //0x6
                                 "0111",    //0x7
                                 "1000",    //0x8
                                 "1001",    //0x9
                                 "1010",    //0xA
                                 "1011",    //0xB
                                 "1100",    //0xC
                                 "1101",    //0xD
                                 "1110",    //0xE
                                 "1111"     //0xF
                             };
            List<string> binNum = new List<string>();

            for (int i = 0; i < hexNum.Length; i++)
            {
                if (hexNum[i] >= 'A' && hexNum[i] <= 'Z')
                {
                    int hex = hexNum[i] - 'A' + 10;
                    binNum.Add(hexToBin[(hexNum[i] - 'A' + 10)]);
                }
                else
                {
                    binNum.Add((hexToBin[hexNum[i] - '0']));
                }
            }

            return binNum;
        }
    }
}
