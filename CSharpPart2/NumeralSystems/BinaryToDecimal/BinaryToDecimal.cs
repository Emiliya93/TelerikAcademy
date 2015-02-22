namespace BinaryToDecimal
{
    using System;
    using MathMethods;

    public class BinaryToDecimal
    {
        static void Main()
        {
            Console.Write("Enter binary number: ");
            string binNum = Console.ReadLine();
            int numeralSystem = 2;
            long decNum = ConvertBinToDec(binNum, numeralSystem);
            Console.WriteLine("{0} in decimal -> {1}", binNum, decNum);
        }

        private static long ConvertBinToDec(string binNum, int numeralSystem)
        {
            long decNum = 0;
            for (int i = 0; i < binNum.Length; i++)
            {
                int power = binNum.Length - i - 1;
                decNum += (binNum[i] - '0') * MathMethods.NumberOnPower(numeralSystem, power);
            }
            return decNum;
        }
    }
}
