namespace LargerThanNeighbours
{
    using System;
    using AppearanceCount;

    /*
        Problem 5. Larger than neighbours

        Write a method that checks if the element at given position in given array of integers 
        is larger than its two neighbours (when such exist).
    */

    class LargerThanNeighbours
    {
        static void Main()
        {
            int[] numbers = AppearanceCount.ReadArrayOfInts();
            Console.WriteLine(string.Join(" ", numbers));
            Console.Write("Enter position of element: ");
            int position = int.Parse(Console.ReadLine());

            bool isLarger = LargerThanNeighbourElements(position, numbers);
            Console.WriteLine("Is number[{0}] > number[{1}] and number[{0}] > number[{2}]?", position, position - 1, position + 1);
            Console.WriteLine("{0} < {1} > {2} -> {3}", numbers[position - 1], numbers[position], numbers[position + 1], isLarger);
        }

        private static bool LargerThanNeighbourElements(int position, int[] numbers)
        {
            bool isLarger = false;
            if (position - 1 >= 0 && position + 1 < numbers.Length)
            {
                if (numbers[position] > numbers[position - 1] && numbers[position] > numbers[position + 1])
                {
                    isLarger = true;
                    return isLarger;
                }
            }
            return isLarger;
        }

        //private static int[] ReadArrayOfInts()
        //{
        //    Console.WriteLine("Enter numbers for array (separated by interval or comma): ");
        //    string input = Console.ReadLine();
        //    string[] numbersString = input.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
        //    int[] numbers = new int[numbersString.Length];
        //    for (int i = 0; i < numbersString.Length; i++)
        //    {
        //        numbers[i] = int.Parse(numbersString[i]);
        //    }

        //    return numbers;
        //}
    }
}