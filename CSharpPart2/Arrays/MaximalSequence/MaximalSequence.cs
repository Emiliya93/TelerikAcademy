using System;

/*
    Problem 4. Maximal sequence

    Write a program that finds the maximal sequence of equal elements in an array.
    Example:

    input	                        |result
    2, 1, 1, 2, 3, 3, 2, 2, 2, 1	|2, 2, 2
*/

class MaximalSequence
{
    static void Main()
    {
        Console.WriteLine("Enter sequence of numbers (separated by space or comma):");
        string input = Console.ReadLine();
        string[] numbersArrey = input.Split(new char[] { ' ', ',', '.' }, StringSplitOptions.RemoveEmptyEntries);
        int size = numbersArrey.Length;

        bool inSequence = false;
        int currentCount = 0;
        int maxCount = 0;
        int currentNumber = 0;
        int maxNumber = 0;

        for (int i = 0; i < size; i++)
        {
            if ((i + 1) < size && numbersArrey[i] == numbersArrey[i + 1])
            {
                inSequence = true;
            }
            
            if (inSequence)
            {
                currentNumber = int.Parse(numbersArrey[i]);

                for (int j = i; j < size; j++)
                {
                    if (numbersArrey[i] == numbersArrey[j])
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
                maxNumber = currentNumber;
            }

            currentCount = 0;
            currentNumber = 0;
        }

        Console.WriteLine("Maximal sequence of equal elements in the array:");

        for (int i = 0; i < maxCount; i++)
        {
            if (i < maxCount - 1)
            {
                Console.Write("{0}, ", maxNumber);
            }
            else
            {
                Console.WriteLine("{0}", maxNumber);
            }
        }
    }
}
