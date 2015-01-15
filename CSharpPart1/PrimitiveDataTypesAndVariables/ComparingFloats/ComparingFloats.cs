using System;

/*
    Problem 13.* Comparing Floats

    Write a program that safely compares floating-point numbers (double) with precision eps = 0.000001.
    Note: Two floating-point numbers a and b cannot be compared directly by a == b because of the nature of the floating-point arithmetic.
    Therefore, we assume two numbers are equal if they are more closely to each other than a fixed constant eps. 
*/
class ComparingFloats
{
    static void Main()
    {
        Console.WriteLine("Enter first number to compare:");
        double firstNumber = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter second number to compare:");
        double secondNumber = double.Parse(Console.ReadLine());

        double precision = 0.000001;

        bool areEqual = (Math.Abs(firstNumber - secondNumber) < precision);
        Console.WriteLine("Are the numbers equal? -> {0}", areEqual);
    }
}