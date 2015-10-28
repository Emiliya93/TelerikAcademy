namespace FindNumbersOccurenceInRange
{
    using System;
    using System.Collections.Generic;
    using Helpers.InputParsers;

    public class Startup
    {
        /// <summary>
        /// Write a program that finds in given array of integers (all belonging to the range [0..1000]) 
        /// how many times each of them occurs.
        /// <para></para>
        /// Example: array = {3, 4, 4, 2, 3, 3, 4, 3, 2}
        /// 2 → 2 times
        /// 3 → 4 times
        /// 4 → 3 times
        /// </summary>
        public static void Main()
        {
            const int MinRange = 0;
            const int MaxRange = 1000;

            Console.WriteLine("Task 7");
            Console.WriteLine("Enter sequence of integer numbers: ");

            string input = Console.ReadLine();

            int[] numbers = SequenceParser.ParseIntegerNumbersToArray(input);

            SortedDictionary<int, int> numberOccurence = OccurencesParser.FindOccurences(numbers, MinRange, MaxRange);

            if (numberOccurence.Count > 0)
            {
                foreach (var pair in numberOccurence)
                {
                    Console.WriteLine(
                        "{0} -> {1} time{2}", 
                        pair.Key, 
                        pair.Value, 
                        pair.Value == 1 ? string.Empty : "s");
                }
            }
            else
            {
                Console.WriteLine("No number in range [{0};{1}]", MinRange, MaxRange);
            }
        }
    }
}
