namespace SortSequenceInIncreasingOrder
{
    using System;
    using System.Collections.Generic;

    using Helpers.InputParsers;

    public class Startup
    {
        /// <summary>
        /// Write a program that reads a sequence of integers (List&lt;int&gt;) ending with an empty line and 
        /// sorts them in an increasing order.
        /// 
        /// My Example:
        /// input           | output
        /// 4 5 1 3 7 8     | 1 3 4 5 7 8
        /// </summary>
        public static void Main()
        {
            Console.WriteLine("Task 3");
            Console.WriteLine("Enter sequence of integer numbers: ");
            string input = Console.ReadLine();

            List<int> numbers = SequenceParser.ParseIntegerNumbersToList(input);

            // numbers.Sort();
            BubbleSort(numbers);

            foreach (int num in numbers)
            {
                Console.Write("{0} ", num);
            }
        }

        /// <summary>
        /// Sorting algorithm for list of numbers. Consider it is very slow for large sequence of numbers, but for a few is ok.
        /// </summary>
        /// <param name="sequence">The sequence to be sorted.</param>
        /// <returns>The sorted sequence.</returns>
        private static IList<int> BubbleSort(IList<int> sequence)
        {
            int length = sequence.Count;
            bool isSorted = true;

            for (int i = 0; i < length - 1; i++)
            {
                isSorted = true;
                for (int j = 0; j < length - 1 - i; j++)
                {
                     if (sequence[j] > sequence[j + 1])
                    {
                        sequence[j] = sequence[j] ^ sequence[j + 1];
                        sequence[j + 1] = sequence[j] ^ sequence[j + 1];
                        sequence[j] = sequence[j] ^ sequence[j + 1];
                        isSorted = false;
                    }
                }

                if (isSorted)
                {
                    return sequence;
                }
            }

            return sequence;
        }
    }
}
