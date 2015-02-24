namespace SumIntegers
{
    using System;

    /*
        Problem 6. Sum integers

        You are given a sequence of positive integer values written into a string, separated by spaces.
        Write a function that reads these values from given string and calculates their sum.
        Example:

        input	            output
        "43 68 9 23 318"	461
    */

    class SumIntegers
    {
        static void Main()
        {
            Console.WriteLine("Enter numbers, separated by spaces: ");
            string input = Console.ReadLine();

            long sum = GetSumOFNumbersFromString(input);
            Console.WriteLine(sum);
        }

        private static long GetSumOFNumbersFromString(string input)
        {
            long sum = 0;
            string[] numbersArray = input.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < numbersArray.Length; i++)
            {
                sum += long.Parse(numbersArray[i]);
            }
            return sum;
        }
    }
}
