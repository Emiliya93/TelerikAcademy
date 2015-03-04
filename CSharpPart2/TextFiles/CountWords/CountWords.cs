namespace CountWords
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    /*
        Problem 13. Count words

        Write a program that reads a list of words from the file words.txt and finds how many times each of the words is contained in another file test.txt.
        The result should be written in the file result.txt and the words should be sorted by the number of their occurrences in descending order.
        Handle all possible exceptions in your methods.
    */

    class CountWords
    {
        static void Main()
        {
            StreamReader reader = new StreamReader(@"..\..\Files\words.txt");
            Dictionary<string, int> wordsToCount = new Dictionary<string, int>();
            try
            {
                // Get words to count
                wordsToCount = ReadWords(reader);

                reader = new StreamReader(@"..\..\Files\test.txt");
                StreamWriter writer = new StreamWriter(@"..\..\Files\result.txt");
                CountWordsFromList(reader, writer, wordsToCount);
            }
            catch (OutOfMemoryException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (IOException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }

            
        }

        private static void CountWordsFromList(StreamReader reader, StreamWriter writer, Dictionary<string, int> listOfWords)
        {
            using (reader)
            {
                string line = string.Empty;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] words = line.Split(new[] { ' ', ',', '.', ':', ';', '!', '?', '-' }, StringSplitOptions.RemoveEmptyEntries);
                    foreach (string word in words)
                    {
                        if (listOfWords.Keys.Contains(word))
                        {
                            listOfWords[word]++;
                        }
                    }
                }
            }
            using (writer)
            {
                foreach (KeyValuePair<string, int> pair in listOfWords.OrderByDescending(key=> key.Value))
                {
                    writer.WriteLine("{0} -> {1}", pair.Key, pair.Value);
                } 
            }
        }

        private static Dictionary<string, int> ReadWords(StreamReader reader)
        {
            Dictionary<string, int> wordsToCount = new Dictionary<string, int>();
            using (reader)
            {
                string text = reader.ReadToEnd();
                string[] words = text.Split(new[] { ' ', ',', '\t', '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
                foreach (string word in words)
                {
                    wordsToCount.Add(word, 0);
                }
            }
            return wordsToCount;
        }
    }
}
