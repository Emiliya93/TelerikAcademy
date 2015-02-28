namespace LettersCount
{
    using System;
    using System.Collections.Generic;

    /*
        Problem 21. Letters count

        Write a program that reads a string from the console and prints all different letters
        in the string along with information how many times each letter is found.
    */

    class LettersCount
    {
        static void Main()
        {
            string text = "C# is not C++, not PHP and not Delphi!";
            List<char> checkedLetter = new List<char>();
            Dictionary<char, int> foundLetter = new Dictionary<char, int>();

            bool notInDictionary = true;
            for (int i = 0; i < text.Length; i++)
            {
                char letter = text[i];
                if (Char.IsLetter(text[i]))
                {
                    if (checkedLetter.Contains(text[i]))
                    {
                        foundLetter[text[i]]++;
                        continue;
                    }
                    foreach (var pair in foundLetter)
                    {
                        if (text[i] == pair.Key)
                        {
                            foundLetter[text[i]]++;
                        }
                        else
                        {
                            notInDictionary = true;
                        }
                    }
                    if (foundLetter.Keys.Count == 0 || notInDictionary)
                    {
                        foundLetter[text[i]] = 1;
                    }
                    checkedLetter.Add(text[i]);
                }
            }

            foreach (var pair in foundLetter)
            {
                Console.WriteLine("{0} -> {1} time/s", pair.Key, pair.Value);
            }
        }
    }
}
