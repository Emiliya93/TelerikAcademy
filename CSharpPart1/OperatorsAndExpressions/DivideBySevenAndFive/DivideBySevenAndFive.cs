using System;

/*
    Problem 3. Divide by 7 and 5

    Write a Boolean expression that checks for given integer if it can be divided (without remainder) by 7 and 5 at the same time.
*/

class DivideBySevenAndFive
{
    static void Main()
    {
        Console.WriteLine("Enter a number:");
        int number = int.Parse(Console.ReadLine());

        if (((number % 7) == 0) && ((number % 5) == 0))
        {
            Console.WriteLine("The number {0} can be divided by 7 and 5 at the same time.", number);
        }
        else
        {
            Console.WriteLine("The number {0} can NOT be divided by 7 and 5 at the same time.", number);
        }
    }
}