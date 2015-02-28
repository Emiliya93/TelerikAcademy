namespace ReverseSentence
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Linq;

    /*
        Problem 13. Reverse sentence

        Write a program that reverses the words in given sentence.
        Example:

        input	                                output
        C# is not C++, not PHP and not Delphi!	Delphi not and PHP, not C++ not is C#!
    */

    class ReverseSentence
    {
        static void Main()
        {
            string input = "C# is, not C++, not PHP and not Delphi!";//Console.ReadLine();
            //Console.WriteLine(char.IsPunctuation(','));

            string[] words = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            char[] punctuation = new char[(words.Length)];
            List<string> reversed = new List<string>();

            for (int index = 0; index < words.Length;index++)
            {
                string word = words[index];

                if (char.IsPunctuation(word[word.Length - 1]) && word[word.Length - 1] != '#')
                {
                    punctuation[index] = word[word.Length - 1];
                    
                    reversed.Add(word.Substring(0,word.Length - 1)); 
                }
                else
                {
                    reversed.Add(word);
                }
            }

            reversed.Reverse();
            int insertedCount = 1;
            for (int i = 0; i < punctuation.Length; i++)
            {
                 if (char.IsPunctuation(punctuation[i]))
                 {
                     reversed.Insert(i + insertedCount, punctuation[i].ToString());
                     insertedCount++;
                 }
            }
            //reversed.ToString().Split(' ').Reverse();
            //for (int j = 0; j < punctuation.Length; j++)
            //{
            //    if (char.IsPunctuation(punctuation[j]))
            //    {
            //        reversed.Insert(j, punctuation[j]);
            //    }
            //}
            Console.WriteLine(string.Join(" ", reversed));
        }
    }
}
