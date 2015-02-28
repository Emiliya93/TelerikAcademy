namespace OrderWords
{
    using System;
    using System.Linq;

    /*
        Problem 24. Order words

        Write a program that reads a list of words, separated by spaces and prints the list in an alphabetical order.
    */

    class OrderWords
    {
        static void Main()
        {
            string input = Console.ReadLine();
            string[] words = input.Split(' ');

            var result = words.OrderBy(x => x);
            foreach (var word in result)
            {
                Console.WriteLine(word);
            }
        }
    }
}
