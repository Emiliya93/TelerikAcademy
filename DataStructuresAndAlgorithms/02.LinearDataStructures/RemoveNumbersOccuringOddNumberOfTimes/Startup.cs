namespace RemoveNumbersOccuringOddNumberOfTimes
{
    using System;
    using System.Collections.Generic;
    using Helpers.InputParsers;

    public class Startup
    {
        /// <summary>
        /// Write a program that removes from given sequence all numbers that occur odd number of times.
        /// Example:
        /// {4, 2, 2, 5, 2, 3, 2, 3, 1, 5, 2} → {5, 3, 3, 5}
        /// </summary>
        public static void Main()
        {
            Console.WriteLine("Task 6");
            Console.WriteLine("Enter sequence of integer numbers: ");

            string input = Console.ReadLine();

            LinkedList<int> numbers = SequenceParser.ParseIntegerNumbersToLinkedList(input);

            RemoveNumbersOccuringOddTimes(numbers);

            foreach (var number in numbers)
            {
                Console.Write("{0} ", number);
            }
        }

        private static void RemoveNumbersOccuringOddTimes(LinkedList<int> numbers)
        {
            Dictionary<int, int> numberOccurence = OccurencesParser.FindOccurences(numbers);

            var numberNode = numbers.First;
            while (numberNode != null)
            {
                if (numberOccurence.ContainsKey(numberNode.Value) && 
                    numberOccurence[numberNode.Value] % 2 != 0)
                {
                    var nodeToRemove = numberNode;
                    numberNode = numberNode.Next;
                    numbers.Remove(nodeToRemove);
                }
                else
                {
                    numberNode = numberNode.Next;
                }
            }
        }
    }
}
