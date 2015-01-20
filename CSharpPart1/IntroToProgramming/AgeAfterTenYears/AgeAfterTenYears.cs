using System;
using System.Globalization;
using System.Threading;

/*
    Problem 15.* Age after 10 Years

    Write a program to read your birthday from the console and print how old you are now and how old you will be after 10 years.
*/

class AgeAfterTenYears
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

        Console.Write("Enter your birthday (MM/DD/YYYY): ");
        DateTime birthday = DateTime.Parse(Console.ReadLine());

        DateTime today = DateTime.Today;
        int age = today.Year - birthday.Year;

        // Check if the birthday is passed
        // today.AddYears(-age) goes to the birthday I have calculated
        if (birthday > today.AddYears(-age))
        {
            age--;
        }

        Console.WriteLine("Your age now: {0}", age);
        Console.WriteLine("Your age after 10 years: {0}", age + 10);
    }
}
