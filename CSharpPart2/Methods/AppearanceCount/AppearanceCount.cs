namespace AppearanceCount
{
    using System;
    using System.Linq;
    /*
        Problem 4. Appearance count

        Write a method that counts how many times given number appears in given array.
        Write a test program to check if the method is workings correctly.
    */

    public class AppearanceCount
    {
        static void Main()
        {
            int[] numbers = ReadArrayOfInts();

            Console.Write("Enter number to search: ");
            int searchedNum = int.Parse(Console.ReadLine());

            int count = AppearanceCounter(searchedNum, numbers);
            if (count == 0)
            {
                Console.WriteLine("Number {0} is not in the sequence!", searchedNum);
            }
            else
            {
                Console.WriteLine("Number {0} has appearrance -> {1} time/s", searchedNum, count);
            }
        }

        public static int[] ReadArrayOfInts()
        {
            Console.WriteLine("Enter sequence of integer numbers (separated by interval or comma): ");
            string input = Console.ReadLine();
            string[] numbersString = input.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
            int[] numbers = numbersString.Select(x => int.Parse(x)).ToArray();

            return numbers;
        }

        private static int AppearanceCounter(int searchedNum, int[] numbers)
        {
            int count = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == searchedNum)
                {
                    count++;
                }
            }
            return count;
        }
    }
}