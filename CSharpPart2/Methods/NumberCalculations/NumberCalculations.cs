namespace NumberCalculations
{
    using System;

    /*
        Problem 15.* Number calculations

        Modify your last program and try to make it work for any number type, not just integer (e.g. decimal, float, byte, etc.)
        Use generic method (read in Internet about generic methods in C#).
    */

    class NumberCalculations
    {
        static void Main()
        {
            double[] nums = {5.23, 10.11, 5.25};

            //min
            FindMinOfSequence<double>(nums);

            //max
            FindMaxOfSequence<double>(nums);

            //sum
            double sum = 1;
            sum = Operate<double>(nums, 0, (s1, s2) => s1 + s2);
            Console.WriteLine("Sum -> {0}", sum);

            //product
            double product = Operate<double>(nums, 1, (s1, s2) => s1 * s2);
            Console.WriteLine("Product -> {0}", product);

            //average
            int lenght = nums.Length;
            double average = Average<double>(sum, lenght, (s1, s2) => s1 / s2);
            Console.WriteLine("Average -> {0}", average);
        }

        static void FindMinOfSequence<T>(T[] numbers) where T : System.IComparable<T>
        {
            T min = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                // min > numbers[i]
                if (min.CompareTo(numbers[i]) > 0)
                {
                    min = numbers[i];
                }
            }
            Console.WriteLine("Min -> {0}", min);
        }

        static void FindMaxOfSequence<T>(T[] numbers) where T : System.IComparable<T>
        {
            T max = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                // min > numbers[i]
                if (max.CompareTo(numbers[i]) < 0)
                {
                    max = numbers[i];
                }
            }
            Console.WriteLine("Max -> {0}", max);
        }

        static T Operate<T>(T[] numbers, T defaultValue, Func<T,T,T> operationMethod)
        {
            T result = defaultValue;
            for (int i = 0; i < numbers.Length; i++)
            {
                result = operationMethod(result, numbers[i]);
            }
            return result;
        }

        static T Average<T>(T sum, T lenght, Func<T,T,T> divideMethod)
        {
            T average = divideMethod(sum, lenght);
            return average;
        }
    }
}
