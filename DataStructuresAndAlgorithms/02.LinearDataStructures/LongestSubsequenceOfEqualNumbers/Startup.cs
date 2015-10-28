namespace LongestSubsequenceOfEqualNumbers
{
    using System;
    using System.Collections.Generic;

    using Helpers.InputParsers;

    public class Startup
    {
        /// <summary>
        /// Write a method that finds the longest subsequence of equal numbers in given List and
        /// returns the result as new List&lt;int&gt;.
        /// Write a program to test whether the method works correctly.
        /// 
        /// My Example:
        /// input               | output
        /// 4 2 2 5 2 3 3 3     | 3 3 3
        /// 2 2 4 5 1 1 1 6 6   | 1 1 1
        /// </summary>
        public static void Main()
        {
            Console.WriteLine("Task 4");
            Console.WriteLine("Enter sequence of integer numbers: ");
            string input = Console.ReadLine();

            List<int> numbers = SequenceParser.ParseIntegerNumbersToList(input);

            List<int> longestSubsequence = FindLongestSubsequenceOfEqualNumbers(numbers);

            if (longestSubsequence.Count > 0)
            {
                foreach (int number in longestSubsequence)
                {
                    Console.Write("{0} ", number);
                }

                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("No subsequence of equal numbers!");
            }
        }

        private static List<int> FindLongestSubsequenceOfEqualNumbers(List<int> numbers)
        {
            int maxNumber = 0;
            int currentNumber = 0;
            int maxCount = 1;
            int currentCount = 1;

            for (int i = 0; i < numbers.Count - 1 - 1; i++)
            {
                if (numbers[i] == numbers[i + 1])
                {
                    currentNumber = numbers[i];
                    currentCount++;
                }
                else if (maxCount < currentCount)
                {
                    maxCount = currentCount;
                    maxNumber = currentNumber;
                    currentCount = 1;
                }
            }

            List<int> longestSequence = new List<int>();
            if (maxCount == 1)
            {
                return longestSequence;
            }

            for (int i = 0; i < maxCount; i++)
            {
                longestSequence.Add(maxNumber);
            }

            return longestSequence;
        }
    }
}
