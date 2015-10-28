namespace CalculateAndPrintSumAndAverageOfSequence
{
    using System;
    using System.Collections.Generic;

    using Helpers.InputParsers;

    public class Startup
    {
        /// <summary>
        /// Write a program that reads from the console a sequence of positive integer numbers.
        /// The sequence ends when empty line is entered.
        /// Calculate and print the sum and average of the elements of the sequence.
        /// Keep the sequence in List&lt;int&gt;.
        /// 
        /// My Examples:
        /// input       | output
        /// 5 5 4 5 1   | sum = 20; avrg = 4
        /// </summary>
        public static void Main()
        {
            Console.WriteLine("Task 1");
            Console.WriteLine("Enter sequence of integer numbers: ");
            string input = Console.ReadLine();

            List<int> numbers = SequenceParser.ParseIntegerNumbersToList(input);

            long sum = 0;
            foreach (int number in numbers)
            {
                sum += number;
            }

            double average = sum / numbers.Count;

            Console.WriteLine("Sum: {0}; Average: {1}", sum, average);
        }
    }
}
