namespace HexadecimalToDecimal
{
    using System;
    using MathMethods;

    /*
        Problem 4. Hexadecimal to decimal

        Write a program to convert hexadecimal numbers to their decimal representation.
    */

    class HexadecimalToDecimal
    {
        static void Main()
        {
            Console.Write("Enter hexadecimal number: ");
            string hexNum = Console.ReadLine();
            int numeralSystem = 16;
            long decNum = ConvertHexToDec(hexNum, numeralSystem);
            Console.WriteLine("{0} to decimal -> {1}", hexNum, decNum);
        }

        private static long ConvertHexToDec(string hexNum, int numeralSystem)
        {
            long decNum = 0;
            for (int i = 0; i < hexNum.Length; i++)
            {
                long power = hexNum.Length - i - 1;
                long baseNumOnPower = MathMethods.NumberOnPower(numeralSystem, power);
                if (hexNum[i] >= '0' && hexNum[i] <= '9')
                {
                    decNum += (hexNum[i] - '0') * baseNumOnPower;
                }
                else if (hexNum[i] >= 'A' && hexNum[i] <= 'F')
                {
                    decNum += (hexNum[i] - 'A' + 10) * baseNumOnPower;
                }
                else if (hexNum[i] >= 'a' && hexNum[i] <= 'f')
                {
                    decNum += (hexNum[i] - 'a' + 10) * baseNumOnPower;
                }
            }
                return decNum;
        }
    }
}
