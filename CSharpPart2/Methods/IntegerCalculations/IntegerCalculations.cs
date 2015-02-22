namespace IntegerCalculations
{
    using System;
    using AppearanceCount;

    /*
        Problem 14. Integer calculations

        Write methods to calculate minimum, maximum, average, sum and product of given set of integer numbers.
        Use variable number of arguments.
    */

    class IntegerCalculations
    {
        static void Main()
        {
            int[] numbers = AppearanceCount.ReadArrayOfInts();
            int min = MinimumOfSequenceOfInts(numbers);
            int max = MaximumOfSequenceOfInts(numbers);
            double avrg = AverageOfSequenceOfInts(numbers);
            int sum = SumOfSequenceOfInts(numbers);
            long product = ProductOfSequenceOfInts(numbers);

            PrintResults(min, max, avrg, sum, product);
        }

        private static void PrintResults(int min, int max, double avrg, int sum, long product)
        {
            Console.WriteLine("Min -> {0}", min);
            Console.WriteLine("Max -> {0}", max);
            Console.WriteLine("Average -> {0}", avrg);
            Console.WriteLine("Sum -> {0}", sum);
            Console.WriteLine("Product -> {0}", product);
        }

        private static long ProductOfSequenceOfInts(int[] numbers)
        {
            long product = 1;
            for (int i = 0; i < numbers.Length; i++)
            {
                product *= numbers[i];
            }
            return product;
        }

        private static int SumOfSequenceOfInts(int[] numbers)
        {
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            return sum;
        }

        private static double AverageOfSequenceOfInts(int[] numbers)
        {
            int sum = SumOfSequenceOfInts(numbers);
            double average = sum / (numbers.Length);
            return average;
        }

        private static int MaximumOfSequenceOfInts(int[] numbers)
        {
            int max = int.MinValue;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > max)
                {
                    max = numbers[i];
                }
            }
            return max;
        }

        private static int MinimumOfSequenceOfInts(int[] numbers)
        {
            int min = int.MaxValue;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] < min)
                {
                    min = numbers[i];
                }
            }
            return min;
        }
    }
}
