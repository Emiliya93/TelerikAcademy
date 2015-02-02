using System;

/*
    Problem 12.* Randomize the Numbers 1…N

    Write a program that enters in integer n and prints the numbers 1, 2, …, n in random order.
    Examples:

    n	randomized numbers 1…n
    3	2 1 3
    10	3 4 8 2 6 7 9 1 10 5

    Note: The above output is just an example.
    Due to randomness, your program most probably will produce different results. You might need to use arrays.
*/

class RandomizeTheNumbersOneToN
{
    static Random rand = new Random();

    static void Main()
    {
        Console.WriteLine("Enter integer number:");
        int userInput = int.Parse(Console.ReadLine());
        int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        // Shuffle
        for (int i = 0; i < numbers.Length; i++)
        {
            int index1 = rand.Next(userInput);
            int index2 = rand.Next(userInput);

            if (index1 == index2)
            {
                continue;
            }
            numbers[index1] += numbers[index2];
            numbers[index2] = numbers[index1] - numbers[index2];
            numbers[index1] -= numbers[index2];
        }

        for (int i = 0; i < userInput; i++)
        {
            Console.Write("{0} ", numbers[i]);
        }
    }
}