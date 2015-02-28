namespace CorrectBrackets
{
    using System;

    /*
        Problem 3. Correct brackets

        Write a program to check if in a given expression the brackets are put correctly.
        Example of correct expression: ((a+b)/5-d). Example of incorrect expression: )(a+b)).
    */

    class CorrectBrackets
    {
        static void Main()
        {
            string input = Console.ReadLine();
            bool isCorrectExpression = IsCorrectExpression(input);
            Console.WriteLine("Is the expression correct? -> {0}", isCorrectExpression);
        }

        private static bool IsCorrectExpression(string input)
        {
            bool isCorrect = false;
            int counter = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '(')
                {
                    counter++;
                }
                if (input[i] == ')')
                {
                    counter--;
                }
                if (counter < 0)
                {
                    isCorrect = false;
                    break;
                }
            }

            if (counter == 0)
            {
                isCorrect = true;
            }
            return isCorrect;
        }
    }
}