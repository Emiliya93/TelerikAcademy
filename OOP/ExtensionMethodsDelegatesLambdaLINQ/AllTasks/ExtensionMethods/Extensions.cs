namespace AllTasks.ExtensionMethods
{
    using System;
    using System.Text;
    using System.Collections.Generic;

    public static class Extensions
    {
        public static void ForEach<T>(this IEnumerable<T> collection, Action<T> action)
        {
            foreach (var item in collection)
            {
                action(item);
            }
        }

        // Problem 1. StringBuilder.Substring
        // Implement an extension method Substring(int index, int length) for the class StringBuilder 
        // that returns new StringBuilder and has the same functionality as Substring in the class String.
        public static StringBuilder Substring(this StringBuilder text, int startIndex, int lenght)
        {
            StringBuilder substring = new StringBuilder();

            if (startIndex < 0 || startIndex > text.Length - 1)
            {
                throw new ArgumentOutOfRangeException("Start index must be zero based and less than text size minus one!");
            }

            if (lenght <= 0 || lenght > (text.Length - startIndex + 1))
            {
                throw new ArgumentOutOfRangeException("Lenght must be more than zero and not larger than text size!");
            }

            for (int i = startIndex; i <= lenght; i++)
            {
                substring.Append(text[i]);
            }

            return substring;
        }

        public static StringBuilder Substring(this StringBuilder text, int startIndex)
        {
            StringBuilder substring = new StringBuilder();

            if (startIndex < 0 || startIndex > text.Length - 1)
            {
                throw new ArgumentOutOfRangeException("Start index must be zero based and less than text size minus one!");
            }

            for (int i = startIndex; i < text.Length; i++)
            {
                substring.Append(text[i]);
            }

            return substring;

        }

        // Problem 2. IEnumerable extensions
        // Implement a set of extension methods for IEnumerable<T> that implement the following group functions:
        // sum, product, min, max, average
        public static T Sum<T>(this IEnumerable<T> collection)
            where T : struct, IComparable, IFormattable, IConvertible, IComparable<T>, IEquatable<T>
        {
            dynamic sum = 0;

            foreach (T item in collection)
            {
                sum += item;
            }

            return sum;
        }

        public static T Product<T>(this IEnumerable<T> collection)
            where T : struct, IComparable, IFormattable, IConvertible, IComparable<T>, IEquatable<T>
        {
            dynamic product = 1;

            foreach (T item in collection)
            {
                product *= item;
            }

            return product;
        }

        public static T Min<T>(this IEnumerable<T> collection)
            where T : IComparable, IComparable<T>
        {
            T min = default(T);
            bool firstItemAssigned = false;

            foreach (T item in collection)
            {
                if (item.CompareTo(min) < 0 || !firstItemAssigned)
                {
                    min = item;
                    firstItemAssigned = true;
                }
            }

            return min;
        }

        public static T Max<T>(this IEnumerable<T> collection)
            where T : IComparable, IComparable<T>
        {
            T max = default(T);
            bool firstItemAssigned = false;

            foreach (T item in collection)
            {
                if (item.CompareTo(max) > 0 || !firstItemAssigned)
                {
                    max = item;
                    firstItemAssigned = true;
                }
            }

            return max;
        }

        public static double Average<T>(this IEnumerable<T> collection)
            where T : struct, IComparable, IFormattable, IConvertible, IComparable<T>, IEquatable<T>
        {
            double avrg = 0;
            dynamic sum = collection.Sum();
            int count = 0;

            foreach (T item in collection)
            {
                count++;
            }

            avrg = sum / count;

            return avrg;
        }
    }
}