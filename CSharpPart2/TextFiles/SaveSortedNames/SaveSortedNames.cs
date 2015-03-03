namespace SaveSortedNames
{
    using System;
    using System.Linq;
    using System.IO;
    using System.Collections.Generic;

    /*
        Problem 6. Save sorted names

        Write a program that reads a text file containing a list of strings, sorts them and saves them to another text file.
        Example:

        input.txt	output.txt
        Ivan        George
        Peter       Ivan
        Maria       Maria
        George      Peter
    */

    class SaveSortedNames
    {
        static void Main()
        {
            StreamReader reader = new StreamReader(@"..\..\Files\input.txt");
            string text;

            using (reader)
            {
                text = reader.ReadToEnd();
            }

            string[] names = text.Split(new[] { ' ', '\n' }, StringSplitOptions.RemoveEmptyEntries);
            Array.Sort(names);
            StreamWriter writer = new StreamWriter(@"..\..\Files\output.txt");
            using (writer)
            {
                foreach (string name in names)
                {
                    writer.WriteLine(name);
                }
            }
        }
    }
}
