namespace NumberAsArray
{
    using System;
    using System.Linq;

    /*
        Problem 8. Number as array

        Write a method that adds two positive integer numbers represented as arrays of digits
        (each array element arr[i] contains a digit; the last digit is kept in arr[0]).
        Each of the numbers that will be added could have up to 10 000 digits.
    */

    class NumberAsArray
    {
        static void Main()
        {
            char[] digitsFirstNum = ReadNumberAsCharArray();
            char[] digitsSecondNum = ReadNumberAsCharArray();

            Array.Reverse(digitsFirstNum);
            Array.Reverse(digitsSecondNum);

            int length = Math.Max(digitsFirstNum.Length, digitsSecondNum.Length);
            int[] sum = new int[6];
            int currentSum = 0;
            int inMind = 0;
            for (int i = 0, j = 0; i < sum.Length; i++, j++)
            {
                if (i < digitsFirstNum.Length && i < digitsSecondNum.Length)
                {
                    currentSum = (digitsFirstNum[i] - '0') + (digitsSecondNum[i] - '0') + inMind;
                    inMind = 0;
                    if (currentSum >= 10)
                    {
                        inMind = currentSum / 10;
                        sum[j] = currentSum % 10;
                    }
                    else
                    {
                        sum[j] = currentSum;
                    }
                }
                else if (i < digitsFirstNum.Length)
                {
                    //sum[j] = (digitsFirstNum[i] - '0') + inMind;
                    //inMind = 0;
                    currentSum = (digitsFirstNum[i] - '0') + inMind;
                    inMind = 0;
                    if (currentSum >= 10)
                    {
                        inMind = currentSum / 10;
                        sum[j] = currentSum % 10;
                    }
                    else
                    {
                        sum[j] = currentSum;
                    }
                }
                else if (i < digitsSecondNum.Length)
                {
                    //sum[j] = (digitsSecondNum[i] - '0') + inMind;
                    //inMind = 0;
                    currentSum = (digitsSecondNum[i] - '0') + inMind;
                    inMind = 0;
                    if (currentSum >= 10)
                    {
                        inMind = currentSum / 10;
                        sum[j] = currentSum % 10;
                    }
                    else
                    {
                        sum[j] = currentSum;
                    }
                }
                else
                {
                    sum[j] = inMind;
                    inMind = 0;
                }

            }
            var result = sum.Reverse().ToArray();
            bool firstZeros = true;

            for (int i = 0; i < result.Length; i++)
            {
                if (result[i] != 0)
                {
                    firstZeros = false;
                }
                if (firstZeros)
                {
                    continue;
                }
                Console.Write(result[i]);
            }
            Console.WriteLine();
        }

        private static char[] ReadNumberAsCharArray()
        {
            Console.Write("Enter number: ");
            string number = Console.ReadLine();
            char[] digitsOfNumber = new char[number.Length];

            for (int i = 0; i < number.Length; i++)
            {
                digitsOfNumber[i] = number[i];
            }

            return digitsOfNumber;
        }
    }
}