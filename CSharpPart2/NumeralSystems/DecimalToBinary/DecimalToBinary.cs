namespace DecimalToBinary
{
    using System;
    using System.Text;
    using System.Linq;

    /*
        Problem 1. Decimal to binary

        Write a program to convert decimal numbers to their binary representation.
    */

    class DecimalToBinary
    {
        static void Main()
        {
            Console.Write("Enter decimal number: ");
            long decNum = long.Parse(Console.ReadLine());
            int numeralSystem = 2;
            string binNum = ConvertDecToBin(decNum, numeralSystem);
            Console.WriteLine("{0} in binary -> {1}", decNum, binNum);
        }

        private static string ConvertDecToBin(long decNum, int numeralSystem)
        {
            string binNum = string.Empty;
            while (decNum > 0)
            {
                long remainder = decNum % numeralSystem;
                decNum /= numeralSystem;
                binNum += remainder;
            }

            return new string(binNum.Reverse().ToArray());
        }
    }
}
