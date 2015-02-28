namespace ExtractSentences
{
    using System;
    using System.Text;

    /*
        Problem 8. Extract sentences

        Write a program that extracts from a given text all sentences containing given word.
        Example:

        The word is: in

        The text is: We are living in a yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.

        The expected result is: We are living in a yellow submarine. We will move out of it in 5 days.

        Consider that the sentences are separated by . and the words – by non-letter symbols.
    */

    class ExtractSentences
    {
        static void Main()
        {
            Console.WriteLine("Enter text:");
            string text = Console.ReadLine();
            Console.Write("Enter word to search: ");
            string searchedWord = Console.ReadLine();
            string dot = ".";
            StringBuilder result = new StringBuilder();

            string[] sentences = text.Split(new[] {'.'}, StringSplitOptions.RemoveEmptyEntries);
            foreach (var sentence in sentences)
            {
                string[] words = sentence.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                int indexOfWord = Array.IndexOf(words, searchedWord);
                if (indexOfWord >= 0)
                {
                    result.Append(sentence);
                    result.Append(".");
                }
            }
            Console.WriteLine("Result:");
            Console.WriteLine(result);

        }
    }
}
