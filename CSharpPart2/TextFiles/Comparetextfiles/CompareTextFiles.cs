namespace Comparetextfiles
{
    using System;
    using System.IO;

    /*
        Problem 4. Compare text files

        Write a program that compares two text files line by line and prints the number of lines that are the same and the number of lines that are different.
        Assume the files have equal number of lines.
    */

    class CompareTextFiles
    {
        static void Main()
        {

            StreamReader readerOne = new StreamReader(@"..\..\Files\textOne.txt");
            StreamReader readerTwo = new StreamReader(@"..\..\Files\textTwo.txt");

            int sameLines = 0;
            int diffLines = 0;
            using (readerOne)
            {
                using (readerTwo)
                {
                    string lineTextOne = readerOne.ReadLine();
                    string lineTextTwo = readerTwo.ReadLine();
                    while (lineTextOne != null)
                    {
                        if (lineTextOne.CompareTo(lineTextTwo) == 0)
                        {
                            sameLines++;
                        }
                        else
                        {
                            diffLines++;
                        }
                        lineTextOne = readerOne.ReadLine();
                        lineTextTwo = readerTwo.ReadLine();
                    }
                }
            }
            Console.WriteLine("Number of same lines in two files: {0}", sameLines);
            Console.WriteLine("Number of lines that are different: {0}", diffLines);
        }
    }
}
