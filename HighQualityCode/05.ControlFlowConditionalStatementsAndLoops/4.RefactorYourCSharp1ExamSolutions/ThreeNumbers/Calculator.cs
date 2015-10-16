/* Telerik Academy Exam 1 @ 3 February 2015 Morning
    Original code (sent in BGCoder) for Task 1. Three Numbers:

    using System;

    class Program
    {
        static void Main()
        {
            long a = long.Parse(Console.ReadLine());
            long b = long.Parse(Console.ReadLine());
            long c = long.Parse(Console.ReadLine());

            long biggest = a;
            long smallest = a;

            double mean = 0;
            double sum = 0;
            int countOfNumbers = 3;

            sum = a + b + c;
            mean = sum / countOfNumbers;

            if (b > biggest)
            {
                biggest = b;
            }
            if (c > biggest)
            {
                biggest = c;
            }

            if (b < smallest)
            {
                smallest = b;
            }
            if (c < smallest)
            {
                smallest = c;
            }
            Console.WriteLine(biggest);
            Console.WriteLine(smallest);
            Console.WriteLine("{0:F2}", mean);
        }
    }
*/

using System;

public class Calculator
{
    public static void Main()
    {
        const int CountOfNumbers = 3;

        long firstNumber = long.Parse(Console.ReadLine());
        long secondNumber = long.Parse(Console.ReadLine());
        long thirdNumber = long.Parse(Console.ReadLine());

        double sum = firstNumber + secondNumber + thirdNumber;

        double mean = sum / CountOfNumbers;

        long biggest = FindBiggestOfThreeNumbers(firstNumber, secondNumber, thirdNumber);

        long smallest = FindSmallestOfThreeNumbers(firstNumber, secondNumber, thirdNumber);

        Console.WriteLine(biggest);
        Console.WriteLine(smallest);
        Console.WriteLine("{0:F2}", mean);
    }

    private static long FindSmallestOfThreeNumbers(long firstNumber, long secondNumber, long thirdNumber)
    {
        long smallest = firstNumber;
        if (secondNumber < smallest)
        {
            smallest = secondNumber;
        }

        if (thirdNumber < smallest)
        {
            smallest = thirdNumber;
        }

        return smallest;
    }

    private static long FindBiggestOfThreeNumbers(long firstNumber, long secondNumber, long thirdNumber)
    {
        long biggest = firstNumber;
        if (secondNumber > biggest)
        {
            biggest = secondNumber;
        }

        if (thirdNumber > biggest)
        {
            biggest = thirdNumber;
        }
        
        return biggest;
    }
}