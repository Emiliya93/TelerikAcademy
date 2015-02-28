namespace ParseTags
{
    using System;
    using System.Text;

    /*
        Problem 5. Parse tags

        You are given a text. Write a program that changes the text in all regions surrounded by the tags <upcase> and </upcase> to upper-case.
        The tags cannot be nested.
                 0123456789ABCDEFGHIJ                       43                      68      75       84      92
        Example: We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.

        The expected result: We are living in a YELLOW SUBMARINE. We don't have ANYTHING else.
    */

    class ParseTags
    {
        static void Main()
        {
            string input = Console.ReadLine();
            StringBuilder result = new StringBuilder();
            string openTag = "<upcase>";
            string closeTag = "</upcase>";
            int indexOpen = -1;
            int indexClose = -1;

            int i = 0;

            do
            {
                indexOpen = input.IndexOf(openTag, i);
                int lenght = indexOpen - i;
                if (indexOpen > 0)
                {
                    result.Append(input.Substring(i, lenght));
                }
                indexClose = input.IndexOf(closeTag, i);
                if (indexClose > 0)
                {
                    int upCaseStart = indexOpen + openTag.Length;
                    lenght = indexClose - (indexOpen + openTag.Length);

                    result.Append(input.Substring(upCaseStart, lenght).ToUpper());
                    i = indexClose + closeTag.Length;
                }
                else
                {
                    result.Append(input.Substring(i));
                }
            } while (indexOpen >= 0 && indexOpen < (input.Length - openTag.Length));

            Console.WriteLine("Result:");
            Console.WriteLine(result);
        }
    }
}
