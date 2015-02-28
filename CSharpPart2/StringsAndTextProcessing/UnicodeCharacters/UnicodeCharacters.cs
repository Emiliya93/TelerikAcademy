namespace UnicodeCharacters
{
    using System;
    using System.Text;

    /*
        Problem 10. Unicode characters

        Write a program that converts a string to a sequence of C# Unicode character literals.
        Use format strings.
        Example:

        input	output
        Hi!	    \u0048\u0069\u0021
    */

    class UnicodeCharacters
    {
        static void Main()
        {
            //Console.OutputEncoding = Encoding.UTF8;
            string text = ConvertStringToUnicode(Console.ReadLine());
            Console.WriteLine(text);
        }

        private static string ConvertStringToUnicode(string text)
        {
            StringBuilder result = new StringBuilder();
            foreach (var symbol in text)
            {
                result.Append(String.Format("\\u{0:x4}", (int)symbol));
                //Console.Write("\\u{0:x4}", (int)symbol);
            }
            return result.ToString();
        }
    }
}
