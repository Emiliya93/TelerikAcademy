namespace SubStringInText
{
    using System;

    /*
        Problem 4. Sub-string in text

        Write a program that finds how many times a sub-string is contained in a given text (perform case insensitive search).
        Example:

        The target sub-string is in

        The text is as follows: 
        The text is as follows: We are living in an yellow submarine. We don't have anything else. inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.

        The result is: 9
    */

    class SubStringInText
    {
        static void Main()
        {
            Console.WriteLine("Enter text, to search the target sub-string - \"in\":");
            string input = Console.ReadLine();
            string searched = "in";
            int count = 0;

            //int index = -1;
            //do
            //{
            //    index = input.IndexOf(searched, index + 1);
            //    if (index > 0)
            //    {
            //        count++;
            //    } 
            //} while (index > 0);

            //Console.WriteLine(count);

            for (int i = 0; i < input.Length - 1; i++)
            {
                string subString = input.Substring(i, searched.Length);
                if (string.Compare(searched, subString, true) == 0)
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }
    }
}
