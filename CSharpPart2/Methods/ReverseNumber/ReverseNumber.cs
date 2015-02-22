namespace ReverseNumber
{
    using System;
    using System.Linq;
    /*
        Problem 7. Reverse number

        Write a method that reverses the digits of given decimal number.
        Example:

        input	output
        256	    652
        123.45	54.321
    */

    public class ReverseNumber
    {
        static void Main()
        {
            string number = Console.ReadLine();
            char[] reversed = ReverseDigits(number);
            for (int i = 0; i < reversed.Length; i++)
            {
                Console.Write(reversed[i]);
            }
            Console.WriteLine();
        }

        public static char[] ReverseDigits(string number)
        {
            char[] reversed = number.Reverse().ToArray();

            return reversed;
        }
    }
}