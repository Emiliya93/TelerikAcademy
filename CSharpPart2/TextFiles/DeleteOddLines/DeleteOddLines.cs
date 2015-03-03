namespace DeleteOddLines
{
    using System;
    using System.IO;

    /*
        Problem 9. Delete odd lines

        Write a program that deletes from given text file all odd lines.
        The result should be in the same file.
    */

    class DeleteOddLines
    {
        static void Main()
        {
            using (StreamReader reader = new StreamReader(@"..\..\Files\input.txt"))
            {
                using (StreamWriter writer = new StreamWriter(@"..\..\Files\temp.txt"))
                {
                    string line = reader.ReadLine();
                    for (int i = 0; line != null; i++)
                    {
                        if (i % 2 == 0)
                        {
                            writer.WriteLine(line);
                        }
                        line = reader.ReadLine();
                    } 
                }
            }
            using (StreamReader reader = new StreamReader(@"..\..\Files\temp.txt"))
            {
                using (StreamWriter writer = new StreamWriter(@"..\..\Files\input.txt"))
                {
                    string line = reader.ReadLine();
                    while (line != null)
                    {
                        writer.WriteLine(line);
                        line = reader.ReadLine();
                    }
                }
            }
            File.Delete(@"..\..\Files\temp.txt");
        }
    }
}
