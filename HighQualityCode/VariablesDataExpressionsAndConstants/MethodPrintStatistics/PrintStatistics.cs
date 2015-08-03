/* Refactor the following code to apply variable usage and naming best practices:

    public void PrintStatistics(double[] arr, int count)
    {
        double max, tmp;
        for (int i = 0; i < count; i++)
        {
            if (arr[i] > max)
            {
                max = arr[i];
            }
        }
        PrintMax(max);
        tmp = 0;
        max = 0;
        for (int i = 0; i < count; i++)
        {
            if (arr[i] < max)
            {
                max = arr[i];
            }
        }
        PrintMin(max);

        tmp = 0;
        for (int i = 0; i < count; i++)
        {
            tmp += arr[i];
        }
        PrintAvg(tmp/count);
    }
*/

namespace PrintStatistics
{
    using System;

    public class Printer 
    {
        public void PrintStatistics(double[] arr, int count)
        {
            double max = FindMaxNumberOfArray(arr, count);
            PrintMax(max);

            double min = FindMinNumberOfArray(arr, count);
            PrintMin(min);

            double average = FindAverageOfArray(arr, count);
            PrintAvg(average);
        }

        private static double FindAverageOfArray(double[] arr, int count)
        {
            double sumOfAllElements = 0;
            for (int i = 0; i < count; i++)
            {
                sumOfAllElements += arr[i];
            }

            double average = sumOfAllElements / count;
            return average;
        }

        private static double FindMinNumberOfArray(double[] arr, int count)
        {
            double min = arr[0];

            for (int i = 1; i < count; i++)
            {
                if (arr[i] < min)
                {
                    min = arr[i];
                }
            }
            return min;
        }

        private static double FindMaxNumberOfArray(double[] arr, int count)
        {
            double max = arr[0];

            for (int i = 1; i < count; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }

            return max;
        }

        private void PrintAvg(double average)
        {
            Console.WriteLine("Average sum is: {0}", average);
        }

        private void PrintMin(double min)
        {
            Console.WriteLine("Minimal number is: {0}", min);
        }

        private void PrintMax(double max)
        {
            Console.WriteLine("Maximal number is: {0}", max);
        }
    }
    }