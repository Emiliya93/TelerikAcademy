namespace SolveTasks
{
    using System;
    using ReverseNumber;
    using AppearanceCount;

    /*
        Problem 13. Solve tasks

        * Write a program that can solve these tasks:
        - Reverses the digits of a number
        - Calculates the average of a sequence of integers
        - Solves a linear equation a * x + b = 0
        * Create appropriate methods.
        * Provide a simple text-based menu for the user to choose which task to solve.
        * Validate the input data:
        - The decimal number should be non-negative
        - The sequence should not be empty
        - a should not be equal to 0
    */

    class SolveTasks
    {
        static void Main()
        {
            PrintMenu();
            int choice;
            string input = Console.ReadLine();
            bool isParsed = int.TryParse(input, out choice);
            while (isParsed == false)
            {
                Console.WriteLine("{0} is incorrect number!", input);
                PrintMenu();
                input = Console.ReadLine();
                isParsed = int.TryParse(input, out choice);
            }

            switch (choice)
            {
                case 1: ReverseDigitsOfNumber(); break;
                case 2: CalculateAverageOfSequence(); break;
                case 3: SolveLinearEquation(); break;
                default: IncorrectChoice(choice); break;
            }
        }

        private static void IncorrectChoice(int choice)
        {
            Console.WriteLine("{0} is incorrect number!", choice);
            PrintMenu();
        }

        private static void SolveLinearEquation()
        {
            // Read coefficients (a,b) and check
            Console.WriteLine("Enter coefficients of equation: a*x + b");
            Console.Write("Enter a (not zero): ");
            string input = Console.ReadLine();
            double a;
            bool isParsed = double.TryParse(input, out a);
            while (isParsed == false || a == 0)
            {
                Console.WriteLine("Coefficient a should not be equal to 0!");
                Console.Write("Enter a (not zero): ");
            }
            Console.WriteLine("Enter b:");
            input = Console.ReadLine();
            double b;
            isParsed = double.TryParse(input, out b);
            while (isParsed == false)
            {
                Console.WriteLine("Coefficient b should be real number!");
                Console.Write("Enter b: ");
            }

            // Solve the equation a * x + b = 0
            double result = -b / a;

            // Print result
            Console.WriteLine("Result of equation {0}*x + {1} = 0 is: {2}", a, b, result);
        }

        private static void CalculateAverageOfSequence()
        {
            // Read sequence
            int[] numbers = AppearanceCount.ReadArrayOfInts();

            // Check if empty
            while (numbers.Length == 0)
            {
                Console.WriteLine("Sequence should not be empty!");
                numbers = AppearanceCount.ReadArrayOfInts();
            }

            // Calculate average
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            double average = sum / (numbers.Length);

            // Print average
            Console.WriteLine("Average of numbers is: {0}", average);
        }

        private static void ReverseDigitsOfNumber()
        {
            // Read and check number
            Console.Write("Enter decimal number (non-negative): ");
            string input = Console.ReadLine();
            double number;
            bool isParsed = double.TryParse(input, out number);
            while (isParsed == false || number < 0)
            {
                Console.WriteLine("Number is not correct!");
                Console.Write("Enter decimal number (non-negative): ");
                input = Console.ReadLine();
                isParsed = double.TryParse(input, out number);
            }

            // Reverse number
            char[] reversed = ReverseNumber.ReverseDigits(input);

            // Print number
            Console.Write("Reversed number {0} -> ", number);
            for (int i = 0; i < reversed.Length; i++)
            {
                Console.Write(reversed[i]);
            }
            Console.WriteLine();
        }

        private static void PrintMenu()
        {
            Console.WriteLine("Choose one of the following:");
            Console.WriteLine("1 -> To reverse the digits of a number (non-negative)");
            Console.WriteLine("2 -> To calculate the average of a sequence of integers (not empty)");
            Console.WriteLine("3 -> To solve a linear equation: a * x + b = 0 (a not 0)");
        }
    }
}
