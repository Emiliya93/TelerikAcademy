namespace ReplaceSubString
{
    using System;
    using System.IO;

    /*
        Problem 7. Replace sub-string

        Write a program that replaces all occurrences of the sub-string start with the sub-string finish in a text file.
        Ensure it will work with large files (e.g. 100 MB).
    */

    class ReplaceSubString
    {
        static void Main()
        {
            string oldString = "start";
            string newString = "finish";

            using (StreamReader reader = new StreamReader(@"..\..\Files\input.txt"))
            {
                using (StreamWriter writer = new StreamWriter(@"..\..\Files\output.txt"))
                {
                    string line = reader.ReadLine();
                    while (line != null)
                    {
                        writer.WriteLine(line.Replace(oldString, newString));
                        line = reader.ReadLine();
                    }
                }
            }
        }
    }
}
