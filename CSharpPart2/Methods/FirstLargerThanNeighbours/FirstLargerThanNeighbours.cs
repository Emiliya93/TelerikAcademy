namespace FirstLargerThanNeighbours
{
    using System;
    using AppearanceCount;
    /*
        Problem 6. First larger than neighbours

        Write a method that returns the index of the first element in array that
        is larger than its neighbours, or -1, if there’s no such element.
        Use the method from the previous exercise.
    */

    class FirstLargerThanNeighbours
    {
        static void Main()
        {
            int[] numbers = AppearanceCount.ReadArrayOfInts();
            int index = LargerThanNeighbourElements(numbers);
            if (index < 0)
            {
                Console.WriteLine("There is no such number!");
            }
            else
            {
                Console.WriteLine("Index is: {0}", index);
            }
        }

        private static int LargerThanNeighbourElements(int[] numbers)
        {
            bool isLarger = false;
            int index = -1;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (i - 1 >= 0 && i + 1 < numbers.Length)
                {
                    if (numbers[i] > numbers[i - 1] && numbers[i] > numbers[i + 1])
                    {
                        index = i;
                    }
                }
            }

            return index;
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