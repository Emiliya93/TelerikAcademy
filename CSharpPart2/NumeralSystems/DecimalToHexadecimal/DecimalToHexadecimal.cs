namespace DecimalToHexadecimal
{
    using System;

    /*
        Problem 3. Decimal to hexadecimal

        Write a program to convert decimal numbers to their hexadecimal representation.
    */

    class DecimalToHexadecimal
    {
        static void Main()
        {
            Console.Write("Enter decimal number: ");
            long decNum = long.Parse(Console.ReadLine());
            int numeralSystem = 16;
            string hexNum = ConvertDecToHex(decNum, numeralSystem);
            Console.WriteLine("{0} to hexadecimal -> {1}", decNum, hexNum);
        }

        private static string ConvertDecToHex(long decNum, int numeralSystem)
        {
            string hexNum = string.Empty;

            while (decNum > 0)
            {
                long remainder = decNum % numeralSystem;
                decNum /= numeralSystem;

                if (remainder >= 0 && remainder <= 9)
                {
                    hexNum = remainder + hexNum;
                }
                else if (remainder >= 10 && remainder <= 15)
                {
                    hexNum = (char)(remainder - 10 + 'A') + hexNum;
                }
            }

            return hexNum;
        }
    }
}
