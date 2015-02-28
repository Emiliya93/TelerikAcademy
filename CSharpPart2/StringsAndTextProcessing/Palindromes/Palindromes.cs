namespace Palindromes
{
    using System;

    /*
        Problem 20. Palindromes

        Write a program that extracts from a given text all palindromes, e.g. ABBA, lamal, exe.
    */

    class Palindromes
    {
        static void Main()
        {
            string text = "ABBA lamal, exe mimi cv";
            string[] words = text.Split(new[] {' ', ','},StringSplitOptions.RemoveEmptyEntries);

            foreach (string word in words)
            {
                int lenght = word.Length;
                for (int i = 0; i < lenght/2; i++)
                {
                    if (word[i] != word[lenght - i - 1])
                    {
                        break;
                    }
                    if (i == lenght/2 - 1)
                    {
                        Console.WriteLine("Symetric word: {0}", word);
                    }
                }
            }
        }
    }
}
