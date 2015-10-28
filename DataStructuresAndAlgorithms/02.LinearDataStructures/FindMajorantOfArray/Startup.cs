namespace FindMajorantOfArray
{
    using System;
    using System.Collections.Generic;
    using Helpers.InputParsers;

    public class Startup
    {
        /// <summary>
        /// <para></para>
        /// *The majorant of an array of size N is a value that occurs in it at least N/2 + 1 times.
        /// Write a program to find the majorant of given array (if exists).
        /// 
        /// Example:
        /// {2, 2, 3, 3, 2, 3, 4, 3, 3} → 3
        /// </summary>
        public static void Main()
        {
            Console.WriteLine("Task 8");
            Console.WriteLine("Enter sequence of integer numbers: ");

            string input = Console.ReadLine();

            int[] numbers = SequenceParser.ParseIntegerNumbersToArray(input);

            int majorantNumber = FindMajorantOfArray(numbers);

            Console.WriteLine("The majorant is: {0}", majorantNumber);
        }

        /// <summary>
        /// Finds majorant in array.
        /// </summary>
        /// <param name="numbers">The array.</param>
        /// <returns>The majorant number.</returns>
        /// <exception cref="InvalidOperationException">There is no majorant in the sequence.</exception>
        private static int FindMajorantOfArray(int[] numbers)
        {
            int length = numbers.Length;

            int majorantLeastCount = (length / 2) + 1;

            Dictionary<int, int> numberOccurences = OccurencesParser.FindOccurences(numbers);

            foreach (KeyValuePair<int, int> pair in numberOccurences)
            {
                if (pair.Value >= majorantLeastCount)
                {
                    return pair.Key;
                }
            }

            throw new InvalidOperationException("There is no majorant in the sequence!");
        }
    }
}
