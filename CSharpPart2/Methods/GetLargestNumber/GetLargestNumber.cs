namespace GetLargestNumber
{
    using System;

    /*
        Problem 2. Get largest number

        Write a method GetMax() with two parameters that returns the larger of two integers.
        Write a program that reads 3 integers from the console and prints the largest of them using the method GetMax().
    */

    class GetLargestNumber
    {
        static void Main()
        {
            Console.Write("Enter first number: ");
            int firstNumber = int.Parse(Console.ReadLine());

            Console.Write("Enter second number: ");
            int secondNumber = int.Parse(Console.ReadLine());

            Console.Write("Enter third number: ");
            int thirdNumber = int.Parse(Console.ReadLine());

            int max = GetMax(firstNumber, secondNumber);
            Console.WriteLine("Max number: {0}", GetMax(max, thirdNumber));
        }

        private static int GetMax(int firstNumber, int secondNumber)
        {
            if (firstNumber > secondNumber)
            {
                return firstNumber;
            }
            return secondNumber;
        }
    }
}