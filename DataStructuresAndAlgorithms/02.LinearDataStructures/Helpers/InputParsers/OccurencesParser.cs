namespace Helpers.InputParsers
{
    using System.Collections.Generic;

    public static class OccurencesParser
    {
        /// <summary>
        /// Finds how many times each number occures in given collection.
        /// </summary>
        /// <param name="numbers">The collection in which occurences are calculated.</param>
        /// <returns>A dictionary with the number as key and the occurences as value.</returns>
        public static Dictionary<int, int> FindOccurences(IEnumerable<int> numbers)
        {
            Dictionary<int, int> numberOccurence = new Dictionary<int, int>();

            foreach (var number in numbers)
            {
                if (!numberOccurence.ContainsKey(number))
                {
                    numberOccurence.Add(number, 0);
                }

                numberOccurence[number]++;
            }

            return numberOccurence;
        }

        /// <summary>
        /// Finds how many times each number occures in given collection.
        /// </summary>
        /// <param name="numbers">The collection in which occurences are calculated.</param>
        /// <param name="minRange">The min range in which to calculate number occurences.</param>
        /// <param name="maxRange">The max range in which to calculate number occurences.</param>
        /// <returns>A sorted dictionary with the number as key and the occurences as value.</returns>
        public static SortedDictionary<int, int> FindOccurences(IEnumerable<int> numbers, int minRange, int maxRange)
        {
            SortedDictionary<int, int> numberOccurence = new SortedDictionary<int, int>();

            foreach (var number in numbers)
            {
                if (number > minRange && number < maxRange)
                {
                    if (!numberOccurence.ContainsKey(number))
                    {
                        numberOccurence.Add(number, 0);
                    }

                    numberOccurence[number]++;
                }
            }

            return numberOccurence;
        }
    }
}
