namespace RemoveNegativeNumbersFromSequence
{
    using System;
    using System.Collections.Generic;
    using Helpers.InputParsers;

    public class Startup
    {
        /// <summary>
        /// Write a program that removes from given sequence all negative numbers.
        /// <para></para>
        /// My Examples:
        /// input               | output
        /// 6 4 -8 -20 0 1 -9   | 6 4 0 1
        /// </summary>
        public static void Main()
        {
            Console.WriteLine("Task 5");
            Console.WriteLine("Enter sequence of integer numbers: ");
            string input = Console.ReadLine();

            LinkedList<int> numbers = SequenceParser.ParseIntegerNumbersToLinkedList(input);

            var numberNode = numbers.First;
            while (numberNode != null)
            {
                if (numberNode.Value < 0)
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

            foreach (var number in numbers)
            {
                Console.Write("{0} ", number);
            }

            Console.WriteLine();
        }
    }
}
