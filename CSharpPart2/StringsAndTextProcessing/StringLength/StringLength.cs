namespace StringLength
{
    using System;
    using System.Text;

    /*
        Problem 6. String length

        Write a program that reads from the console a string of maximum 20 characters.
        If the length of the string is less than 20, the rest of the characters should be filled with *.
        Print the result string into the console.
    */

    class StringLength
    {
        static void Main()
        {
            Console.Write("Enter string: ");
            string input = Console.ReadLine();
            while (input.Length > 20)
            {
                Console.WriteLine("The string must be maximum 20 characters!");
                Console.Write("Enter string: ");
                input = Console.ReadLine();
            }
            if (input.Length < 20)
            {
                StringBuilder result = new StringBuilder(20);
                result.Append(input);
                int diff = 20 - input.Length;
                result.Append(new string('*', diff));
                //for (int i = input.Length; i <= 20; i++)
                //{
                //    result.Append("*");
                //}
                Console.WriteLine("Result:");
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine(input);
            }
        }
    }
}
