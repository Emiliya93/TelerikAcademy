namespace CalculateAndPrintSumAndAverageOfSequence
{
    using System;
    using System.Collections.Generic;

    using Helpers.InputOutputUtils;
    using Helpers.InputParsers;

    public class Startup
    {
        private static IMessageProcessor messageProcessor = new ConsoleMessageProcessor();
        private static IParser sequenceReader = new SequenceOfNumbersParser();

        /// <summary>
        /// Write a program that reads from the console a sequence of positive integer numbers.
        /// The sequence ends when empty line is entered.
        /// Calculate and print the sum and average of the elements of the sequence.
        /// Keep the sequence in List<int>.
        /// 
        /// My Examples:
        /// input       | output
        /// 5 5 4 5 1   | sum = 20; avrg = 4
        /// </summary>
        public static void Main()
        {
            messageProcessor.PrintMessageOnLine("Enter sequence of integer numbers: ");
            string input = messageProcessor.ReadMessageOnLine();

            List<int> numbers = sequenceReader.ReadIntegerNumbers(input);

            long sum = 0;
            foreach (int number in numbers)
            {
                sum += number;
            }

            double average = sum / numbers.Count;

            messageProcessor.PrintMessageOnLine(string.Format("Sum: {0}; Average: {1}", sum, average));
        }
    }
}
