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
            List<string> checkedWord = new List<string>();
            Dictionary<string, int> foundWord = new Dictionary<string, int>();

            bool notInDictionary = true;
            for (int i = 0; i < words.Length; i++)
            {
                string word = words[i];
                
                if (checkedWord.Contains(words[i]))
                {
                    foundWord[words[i]]++;
                    continue;
                }
                foreach (var pair in foundWord)
                {
                    if (words[i] == pair.Key)
                    {
                        foundWord[words[i]]++;
                    }
                    else
                    {
                        notInDictionary = true;
                    }
                }
                if (foundWord.Keys.Count == 0 || notInDictionary)
                {
                    foundWord[words[i]] = 1;
                }
                checkedWord.Add(words[i]);
            }

            foreach (var pair in foundWord)
            {
                Console.WriteLine("{0} -> {1} time/s", pair.Key, pair.Value);
            }
        }
    }
}
