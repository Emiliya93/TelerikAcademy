namespace Helpers.InputParsers
{
    using System;
    using System.Collections.Generic;

    public static class SequenceParser
    {
        public static List<int> ParseIntegerNumbersToList(string sequenceAsString)
        {
            string[] numbersAsStrings = sequenceAsString.Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);

            List<int> numbers = new List<int>();
            foreach (string numberAsString in numbersAsStrings)
            {
                int currentNumber = int.Parse(numberAsString);

                numbers.Add(int.Parse(numberAsString));
            }

            return numbers;
        }

        public static LinkedList<int> ParseIntegerNumbersToLinkedList(string sequenceAsString)
        {
            string[] numbersAsStrings = sequenceAsString.Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);

            LinkedList<int> numbers = new LinkedList<int>();

            int currentNumber = int.Parse(numbersAsStrings[0]);

            numbers.AddFirst(currentNumber);
            for (int i = 1; i < numbersAsStrings.Length; i++)
            {
                currentNumber = int.Parse(numbersAsStrings[i]);

                numbers.AddLast(currentNumber);
            }

            return numbers;
        }

        public static Stack<int> ParseIntegerNumbersToStack(string sequenceAsString)
        {
            string[] numbersAsStrings = sequenceAsString.Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);

            Stack<int> numbersStack = new Stack<int>();
            foreach (string numberAsString in numbersAsStrings)
            {
                int currentNumber = int.Parse(numberAsString);

                numbersStack.Push(currentNumber);
            }

            return numbersStack;
        }

        public static int[] ParseIntegerNumbersToArray(string sequenceAsString)
        {
            string[] numbersAsStrings = sequenceAsString.Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);

            int[] numbers = new int[numbersAsStrings.Length];

            for (int i = 0; i < numbersAsStrings.Length; i++)
            {
                string numberAsString = numbersAsStrings[i];
                int currentNumber = int.Parse(numberAsString);

                numbers[i] = currentNumber;
            }

            return numbers;
        }
    }
}
