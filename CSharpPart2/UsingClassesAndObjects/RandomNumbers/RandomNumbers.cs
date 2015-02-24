namespace RandomNumbers
{
    using System;

    /*
        Problem 2. Random numbers

        Write a program that generates and prints to the console 10 random values in the range [100, 200].
    */

    class RandomNumbers
    {
        static Random rand = new Random();

        static void Main()
        {
            int numberOfRands = 10;

            for (int i = 0; i < numberOfRands; i++)
            {
                Console.WriteLine(rand.Next(100, 200 + 1));
            }
        }
    }
}
