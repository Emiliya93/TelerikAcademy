namespace ConcatenateTextFiles
{
    using System;
    using System.IO;

    /*
        Problem 2. Concatenate text files

        Write a program that concatenates two text files into another text file.
    */

    class ConcatenateTextFiles
    {
        static void Main()
        {
            StreamReader readerOne = new StreamReader(@"..\..\Files\textOne.txt");
            StreamReader readerTwo = new StreamReader(@"..\..\Files\textTwo.txt");

            StreamWriter writer = new StreamWriter(@"..\..\Files\result.txt");
            Console.WriteLine("Concatenaiting files in result...");
            using (readerOne)
            {
                using (readerTwo)
                {
                    using (writer)
                    {
                        writer.Write(readerOne.ReadLine());
                        writer.Write(readerTwo.ReadLine());
                    }
                }
            }
            Console.WriteLine("Writing in file completed!");
        }
    }
}