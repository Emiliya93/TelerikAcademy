namespace ReplaceWholeWord
{
    using System;
    using System.IO;
    using System.Text.RegularExpressions;

    /*
        Problem 8. Replace whole word

        Modify the solution of the previous problem to replace only whole words (not strings).
    */

    class ReplaceWholeWord
    {
        static void Main()
        {
            string oldStringPattern = @"\bstart\b";
            string newString = "finish";

            using (StreamReader reader = new StreamReader(@"..\..\Files\input.txt"))
            {
                using (StreamWriter writer = new StreamWriter(@"..\..\Files\output.txt"))
                {
                    string line = reader.ReadLine();
                    while (line != null)
                    {
                        writer.WriteLine(Regex.Replace(line, oldStringPattern, newString));
                        line = reader.ReadLine();
                    }
                }
            }
        }
    }
}
