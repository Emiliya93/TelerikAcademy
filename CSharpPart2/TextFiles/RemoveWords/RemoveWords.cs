namespace RemoveWords
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text;

    /*
        Problem 12. Remove words

        Write a program that removes from a text file all words listed in given another text file.
        Handle all possible exceptions in your methods.
    */

    class RemoveWords
    {
        static void Main()
        {
            StreamReader reader = new StreamReader(@"..\..\Files\words.txt");
            List<string> forbiddenWords = new List<string>();
            
            try
            {
                // Get words to remove
                forbiddenWords = ReadForbWords(reader);

                reader = new StreamReader(@"..\..\Files\input.txt");
                StreamWriter writer = new StreamWriter(@"..\..\Files\output.txt");
                // Remove words and save text in output text file
                RemoveForbWords(reader, writer, forbiddenWords);
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
            catch (OverflowException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (ObjectDisposedException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (NotSupportedException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private static List<string> ReadForbWords(StreamReader reader)
        {
            List<string> forbiddenWords = new List<string>();
            using (reader)
            {
                string text = reader.ReadToEnd();
                forbiddenWords = text.Split(new[] { ' ', ',', '\t', '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            }
            return forbiddenWords;
        }

        private static void RemoveForbWords(StreamReader reader, StreamWriter writer, List<string> forbiddenWords)
        {
            using (reader)
            {
                using (writer)
                {
                    string line = string.Empty;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] wordsInText = line.Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);

                        for (int i = 0; i < wordsInText.Length; i++)
                        {
                            string word = wordsInText[i];
                            bool isForbWord = false;
                            for (int j = 0; j < forbiddenWords.Count; j++)
                            {
                                string forbWord = forbiddenWords[j];
                                if (word == forbWord)
                                {
                                    isForbWord = true;
                                    break;
                                }
                            }
                            if (!isForbWord)
                            {
                                writer.Write(word);
                                if (i != wordsInText.Length - 1)
                                {
                                    writer.Write(" ");
                                }
                            }
                        }
                        writer.WriteLine();
                    }
                }
            }
        }
    }
}
