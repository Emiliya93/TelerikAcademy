using System;

/*
    Problem 12. Index of letters

    Write a program that creates an array containing all letters from the alphabet (A-Z).
    Read a word from the console and print the index of each of its letters in the array.
*/

class IndexOfLetters
{
    static void Main()
    {
        char[] letters = new char[26];
        char firstLetter = 'A';
        for (int i = 0; i < letters.Length; i++)
        {
            letters[i] = firstLetter;
            firstLetter++;
        }

        Console.Write("Enter word: ");
        string word = Console.ReadLine();
        int[] indexes = new int[word.Length];

        for (int i = 0; i < word.Length; i++)
        {
            for (int j = 0; j < letters.Length; j++)
            {
                if (word[i] == letters[j])
                {
                    indexes[i] = j;
                    break;
                }
            }
        }

        Console.WriteLine(string.Join(", ", indexes));
    }
}
