namespace WordsCount
{
    using System;
    using System.Collections.Generic;

    /*
        Problem 22. Words count

        Write a program that reads a string from the console and lists all different words in the string along with information how many times each word is found.
    */

    class WordsCount
    {
        static void Main()
        {
            string text = "C# is not C++, not PHP and not Delphi!";
            string[] words = text.Split(new[] { ' ', ',', '.', ':', ';', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
            Dictionary<string, int> foundWord = new Dictionary<string, int>();

            for (int i = 0; i < words.Length; i++)
            {
                if (!foundWord.ContainsKey(words[i]))
                {
                    foundWord.Add(words[i], 0);
                }

                foundWord[words[i]]++;
            }

            foreach (var pair in foundWord)
            {
                Console.WriteLine("{0} -> {1} {2}", pair.Key, pair.Value, pair.Value > 1 ? "times" : "time");
            }
        }
    }
}
