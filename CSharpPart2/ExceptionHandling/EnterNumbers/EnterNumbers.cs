namespace EnterNumbers
{
    using System;

    /*
        Problem 2. Enter numbers

        Write a method ReadNumber(int start, int end) that enters an integer number in a given range [start…end].
        If an invalid number or non-number text is entered, the method should throw an exception.
        Using this method write a program that enters 10 numbers: a1, a2, … a10, such that 1 < a1 < … < a10 < 100
    */
    class NumberNotInRangeException : ArgumentException
    {
    }
    class NotCorrectRangeException : ArgumentException
    {
    }

    class EnterNumbers
    {
        static void Main()
        {
            ReadTenNumbersFromOneToHundred();
        }

        private static void ReadTenNumbersFromOneToHundred()
        {
            Console.WriteLine("Enter 10 consecutive numbers in range [1,100]: ");
            int start = 1;
            int end = 100;
            int[] numbers = new int[10];
            for (int i = 0; i < 10; i++)
            {
                try
                {
                    numbers[i] = ReadNumber(start, end);
                    start = numbers[i];
                    Console.Clear();
                }
                catch (FormatException)
                {
                    Console.Clear();
                    Console.WriteLine("Number is not valid!");
                    i--;
                }
                catch(NotCorrectRangeException)
                {
                    Console.Clear();
                    Console.WriteLine("The range is not correct! First number should be smaller than second!");
                    i--;
                }
                catch (NumberNotInRangeException)
                {
                    Console.Clear();
                    Console.WriteLine("Number is not in range!");
                    i--;
                }

            }
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine("Number {0} ->{1}", i + 1, numbers[i]);
            }
        }

        private static int ReadNumber(int start, int end)
        {
            if (end < start)
            {
                throw new NotCorrectRangeException();
            }

            Console.WriteLine("Enter number in range [{0},{1}]", start, end);

            int number = int.Parse(Console.ReadLine());
            if (number < start || number > end)
            {
                throw new NumberNotInRangeException();
            }
            return number;
        }
    }
}
