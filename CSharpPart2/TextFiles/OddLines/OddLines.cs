namespace OddLines
{
    using System;
    using System.IO;

    /*
        Problem 1. Odd lines

        Write a program that reads a text file and 
        prints on the console its odd lines.
    */

    class OddLines
    {
        static void Main()
        {
            StreamReader reader = new StreamReader(@"..\..\Files\test.txt");

            using (reader)
            {
                string line = reader.ReadLine();
                Console.WriteLine("Odd lines:");
                for (int i = 1; line != null; i++)
                {
                    if (i % 2 != 0)
                    {
                        Console.WriteLine(line);
                    }
                    line = reader.ReadLine();
                }
            }
        }
    }
}
