namespace ForbiddenWords
{
    using System;
    using System.Text;

    /*
        Problem 9. Forbidden words

        We are given a string containing a list of forbidden words and a text containing some of these words.
        Write a program that replaces the forbidden words with asterisks.
        Example text: Microsoft announced its next generation PHP compiler today. It is based on .NET Framework 4.0 and is implemented as a dynamic language in CLR.

        Forbidden words: PHP, CLR, Microsoft

        The expected result: ********* announced its next generation *** compiler today. It is based on .NET Framework 4.0 and is implemented as a dynamic language in ***.
    */

    class ForbiddenWords
    {
        static void Main()
        {
            Console.WriteLine("Enter text: ");
            string text = Console.ReadLine();
            Console.WriteLine("Enter forbidden words count: ");
            int forbiddenWordsCount = int.Parse(Console.ReadLine());
            string[] forbWords = new string[forbiddenWordsCount];
            for (int i = 0; i < forbiddenWordsCount; i++)
            {
                Console.Write("Enter word {0}: ", i + 1);
                forbWords[i] = Console.ReadLine();
            }

            StringBuilder result = new StringBuilder();
            result.Append(text);
            for (int i = 0; i < forbWords.Length; i++)
            {
                result.Replace(forbWords[i], new string('*', forbWords[i].Length));
            }
            Console.WriteLine(result);
        }
    }
}
