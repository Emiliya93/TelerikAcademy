namespace ReverseString
{
    using System;
    using System.Diagnostics;
    using System.Linq;

    /*
        Problem 2. Reverse string

        Write a program that reads a string, reverses it and prints the result at the console.
        Example:

        input	output
        sample	elpmas
     */

    class ReverseString
    {
        static void Main()
        {
            // Count how much time the program does it's job 
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            string input = Console.ReadLine();
            char[] reversed = input.Reverse().ToArray();

            // Print time elapsed
            stopwatch.Stop();
            Console.WriteLine("Time elapsed: {0:ss\\.fffff}", stopwatch.Elapsed);

            Console.WriteLine(string.Join("", reversed));
        }
    }
}
