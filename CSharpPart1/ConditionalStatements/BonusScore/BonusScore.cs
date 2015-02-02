using System;

/*
    Problem 2. Bonus Score

    Write a program that applies bonus score to given score in the range [1…9] by the following rules:
    If the score is between 1 and 3, the program multiplies it by 10.
    If the score is between 4 and 6, the program multiplies it by 100.
    If the score is between 7 and 9, the program multiplies it by 1000.
    If the score is 0 or more than 9, the program prints “invalid score”.

    Examples:

    score	|result
    2	    |20
    4	    |400
    9	    |9000
    -1	    |invalid score
    10	    |invalid score
*/

class BonusScore
{
    static void Main()
    {
        Console.Write("Enter your score (from 1 to 9): ");
        int score;

        while (!(int.TryParse(Console.ReadLine(), out score)))
        {
            Console.WriteLine("Invalid score! Please enter integer number (1 to 9): ");
        }

        if (score >= 1 && score <= 3)
        {
            score *= 10;
            Console.WriteLine(score);
        }
        else if (score >= 4 && score <= 6)
        {
            score *= 100;
            Console.WriteLine(score);
        }
        else if (score >= 7 && score <= 9)
        {
            score *= 1000;
            Console.WriteLine(score);
        }
        else
        {
            Console.WriteLine("Invalid score!");
        }
    }
}