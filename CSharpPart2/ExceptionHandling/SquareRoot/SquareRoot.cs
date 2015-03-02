namespace SquareRoot
{
    using System;

    /*
        Problem 1. Square root

        Write a program that reads an integer number and calculates and prints its square root.
        If the number is invalid or negative, print Invalid number.
        In all cases finally print Good bye.
        Use try-catch-finally block.
    */
    class PositiveNumberExpectedException : ArgumentException
    {

    }

    class SquareRoot
    {
        public static double Sqrt(double number)
        {
            if (number < 0)
            {
                throw new PositiveNumberExpectedException();
            }
            return Math.Sqrt(number);
        }

        static void Main()
        {
            double square = 0;
            try
            {
                double number = double.Parse(Console.ReadLine());
                square = Sqrt(number);
                Console.WriteLine("{0:F2}", square);
            }
            catch (PositiveNumberExpectedException)
            {
                Console.WriteLine("Invalid number!");
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid number!");
            }
            finally
            {
                Console.WriteLine("Good bye!");
            }
        }

    }
}
