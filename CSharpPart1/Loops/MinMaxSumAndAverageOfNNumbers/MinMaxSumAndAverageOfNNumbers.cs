using System;

/*
    Problem 3. Min, Max, Sum and Average of N Numbers

    Write a program that reads from the console a sequence of n integer numbers and returns
    the minimal, the maximal number, the sum and the average of all numbers (displayed with 2 digits after the decimal point).
    The input starts by the number n (alone in a line) followed by n lines, each holding an integer number.
    The output is like in the examples below.

    Example 1:
    input	output
    3 
    2 
    5 
    1	    min = 1 
            max = 5 
            sum = 8 
            avg = 2.67

    Example 2:
    input	output
    2 
    -1 
    4	    min = -1 
            max = 4 
            sum = 3 
            avg = 1.50
*/

class MinMaxSumAndAverageOfNNumbers
{
    static void Main()
    {
        Console.Write("Please enter count of numbers: ");
        int countOfNumbers = int.Parse(Console.ReadLine());
        int[] numbers = new int[countOfNumbers];
        int maxNumber = int.MinValue;
        int minNumber = int.MaxValue;
        int sum = 0;


        for (int i = 0; i < countOfNumbers; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
            sum += numbers[i];

            if (numbers[i] > maxNumber)
            {
                maxNumber = numbers[i];
            }
            if (numbers[i] < minNumber)
            {
                minNumber = numbers[i];
            }
        }
        
        double average = (double)sum / countOfNumbers;

        Console.WriteLine("min = {0}", minNumber);
        Console.WriteLine("max = {0}", maxNumber);
        Console.WriteLine("sum = {0}", sum);
        Console.WriteLine("avg = {0:F2}", average);
    }
}