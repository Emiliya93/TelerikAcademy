using System;
using System.Collections.Generic;
using System.Linq;

/*
    Problem 16.* Subset with sum S

    We are given an array of integers and a number S.
    Write a program to find if there exists a subset of the elements of the array that has a sum S.
    Example:

    input array	            |S	|result
    2, 1, 2, 4, 3, 5, 2, 6	|14	|yes

    My Example:
    -9, 5, 6, 0, -3, 1, 2   |-12|yes
*/

class SubsetWithSumS
{
    static void Main()
    {
        // TODO: Make it work with -9, 5, 6, 0, -3, 1, 2   |-12
        int[] numbers = GetInputArrayOfIntegers();
        Console.Write("Enter sum to search: ");
        int searchedSum = int.Parse(Console.ReadLine());
        bool sumExists = false;

        int currentSum = 0;

        for (int i = 0; i < numbers.Length; i++)
        {
            currentSum = 0;
            if (sumExists)
            {
                break;
            }
            currentSum += numbers[i];
            sumExists = CheckIfSumExists(currentSum, searchedSum);
            if (sumExists)
            {
                break;
            }
            CheckIfSumIsBiggerSetZero(ref currentSum, searchedSum);

            if ((i + 1) < (numbers.Length - 1))
            {
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    currentSum += numbers[j];

                    sumExists = CheckIfSumExists(currentSum, searchedSum);
                    if (sumExists)
                    {
                        break;
                    }
                    CheckIfSumIsBiggerSetZero(ref currentSum, searchedSum);
                }
            }
            
        }
    }

    private static void CheckIfSumIsBiggerSetZero(ref int currentSum, int sum)
    {
        if (sum < 0)
        {
            if (currentSum < sum || currentSum > 0)
            {
                currentSum = 0;
            }
        }
        else
        {
            if (currentSum > sum)
            {
                currentSum = 0;
            }
        }
    }

    private static bool CheckIfSumExists(int currentSum, int searchedSum)
    {
        bool sumExists = false;

        if (currentSum == searchedSum)
        {
            Console.WriteLine("yes");
            sumExists = true;
        }
        
        return sumExists;
    }

    private static int[] GetInputArrayOfIntegers()
    {
        Console.WriteLine("Enter numbers, separated by interval or comma: ");
        string input = Console.ReadLine();
        string[] numbersInString = input.Split(new char[] { ' ', ',', '.' }, StringSplitOptions.RemoveEmptyEntries);
        int[] numbers = numbersInString.Select(int.Parse).ToArray();

        return numbers;
    }
}