namespace LeapYear
{
    using System;

    /*
        Problem 1. Leap year

        Write a program that reads a year from the console and checks whether it is a leap one.
        Use System.DateTime.
    */

    class LeapYear
    {
        static void Main()
        {
            Console.Write("Enter year to check: ");
            int year = int.Parse(Console.ReadLine());

            bool isLeapYear = DateTime.IsLeapYear(year);

            Console.WriteLine("Is {0} leap year? -> {1}", year, isLeapYear);
        }
    }
}
