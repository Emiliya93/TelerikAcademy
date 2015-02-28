namespace WordDictionary
{
    using System;
    using System.Collections.Generic;

    /*
        Problem 14. Word dictionary

        A dictionary is stored as a sequence of text lines containing words and their explanations.
        Write a program that enters a word and translates it by using the dictionary.
        Sample dictionary:

        input	        output
        .NET	        platform for applications from Microsoft
        CLR	            managed execution environment for .NET 
        namespace       hierarchical organization of classes
    */

    class WordDictionary
    {
        static void Main()
        {
            Dictionary<string,string> dictionary = new Dictionary<string,string>();
            dictionary.Add(".NET", "platform for applications from Microsoft");
            dictionary.Add("CLR", "managed execution environment for .NET");
            dictionary.Add("namespace", "hierarchical organization of classes");

            Console.Write("Enter word to translate: ");
            string word = Console.ReadLine();
            Console.WriteLine(dictionary[word]);
        }
    }
}
