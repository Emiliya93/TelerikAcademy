using System;

/*
    Problem 5. Maximal increasing sequence

    Write a program that finds the maximal increasing sequence in an array.
    Example:

    input	            |result
    3, 2, 3, 4, 2, 2, 4	|2, 3, 4
*/

class MaximalSequenceIncreasing
{
    static void Main()
    {
        Console.WriteLine("Enter sequence of numbers (separated by space or comma):");
        string input = Console.ReadLine();
        
        string[] numbersArrey = input.Split(new char[] { ' ', ',', '.' }, StringSplitOptions.RemoveEmptyEntries);
        int size = numbersArrey.Length;
        int[] numbers = new int[size];

        for (int i = 0; i < size; i++)
        {
            numbers[i] = int.Parse(numbersArrey[i]);
        }

        bool inSequence = false;
        int currentCount = 1;
        int maxCount = 1;
        int firstNumber = 0;
        int maxNumber = 0;

        for (int i = 0; i < size; i++)
        {
            if ((i + 1) < size && numbers[i] == (numbers[i + 1] - 1))
            {
                inSequence = true;
            }

            if (inSequence)
            {
                firstNumber = numbers[i];

                for (int j = i; j < size; j++)
                {
                    if (j + 1 < size && numbers[j] == (numbers[j + 1] - 1))
                    {
                        inSequence = true;
                        currentCount++;
                    }
                    else
                    {
                        i = j - 1;
                        inSequence = false;
                        break;
                    }
                }
            }

            if (currentCount > maxCount)
            {
                maxCount = currentCount;
                maxNumber = firstNumber;
            }

            currentCount = 1;
            firstNumber = 0;
        }

        for (int i = 0; i < maxCount; i++)
        {
            if (i < maxCount - 1)
            {
                Console.Write("{0}, ", maxNumber + i);
            }
            else
            {
                Console.WriteLine("{0}", maxNumber + i);
            }
        }
    }
}