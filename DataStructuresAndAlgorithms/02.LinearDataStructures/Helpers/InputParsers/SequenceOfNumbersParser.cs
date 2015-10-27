namespace Helpers.InputParsers
{
    using System;
    using System.Collections.Generic;

    public class SequenceOfNumbersParser : IParser
    {
        public List<int> ReadIntegerNumbers(string sequenceAsString)
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
    }
}
