namespace LineNumbers
{
    using System;
    using System.IO;

    /*
        Problem 3. Line numbers

        Write a program that reads a text file and inserts line numbers in front of each of its lines.
        The result should be written to another text file.
    */

    class LineNumbers
    {
        static void Main()
        {
            StreamReader reader = new StreamReader(@"..\..\Files\text.txt");
            StreamWriter writer = new StreamWriter(@"..\..\Files\output.txt");

            using (reader)
            {
                using (writer)
                {
                    string line = reader.ReadLine();
                    for (int i = 1; line != null; i++)
                    {
                        writer.WriteLine("{0}. {1}", i, line);
                        line = reader.ReadLine();
                    } 
                }
            }
        }
    }
}
