namespace SeriesOfLetters
{
    using System;
    using System.Text;

    /*
        Problem 23. Series of letters

        Write a program that reads a string from the console and replaces all series of consecutive identical letters with a single one.
        Example:

        input	                |output
        aaaaabbbbbcdddeeeedssaa	|abcdedsa
    */

    class SeriesOfLetters
    {
        static void Main()
        {
            string text = "aaaaabbbbbcdddeeeedssaa";
            StringBuilder replaced = new StringBuilder();

            for (int i = 0; i < text.Length; i++)
            {
                char sym = text[i];
                if (i + 1 < text.Length)
                {
                    char sym1 = text[i + 1];
                    if (text[i] != text[i + 1])
                    {
                        replaced.Append(text[i]);
                    } 
                }
                else if (i == text.Length - 1 && text[i] != replaced[replaced.Length - 1])
                {
                    replaced.Append(text[i]);
                }
            }
            Console.WriteLine(replaced);
        }
    }
}
