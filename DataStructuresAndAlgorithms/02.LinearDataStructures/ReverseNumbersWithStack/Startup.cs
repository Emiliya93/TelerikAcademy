namespace ReverseNumbersWithStack
{
    using System;
    using System.Collections.Generic;

    using Helpers.InputParsers;

    public class Startup
    {
        /// <summary>
        /// Write a program that reads N integers from the console and reverses them using a stack.
        /// Use the Stack&lt;int&gt; class.
        /// </summary>
        public static void Main()
        {
            Console.WriteLine("Task 2");
            Console.WriteLine("Enter sequence of integer numbers: ");
            string input = Console.ReadLine();

            Stack<int> numbersStack = SequenceParser.ParseIntegerNumbersToStack(input);

            while (numbersStack.Count > 0)
            {
                Console.WriteLine(numbersStack.Pop());
            }
        }
    }
}
