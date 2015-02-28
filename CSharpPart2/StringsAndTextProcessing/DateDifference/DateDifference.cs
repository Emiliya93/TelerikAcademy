namespace DateDifference
{
    using System;
    using System.Globalization;

    /*
        Problem 16. Date difference

        Write a program that reads two dates in the format: day.month.year and calculates the number of days between them.
        Example:

        Enter the first date: 27.02.2006
        Enter the second date: 3.03.2006
        Distance: 4 days
    */

    class DateDifference
    {
        static void Main()
        {
            Console.WriteLine("Enter first date (in format: dd.MM.yyyy): ");
            string inputDate = Console.ReadLine();
            DateTime dateOne = DateTime.ParseExact(inputDate, "dd.MM.yyyy", CultureInfo.InvariantCulture);

            Console.WriteLine("Enter second date(in format: dd.MM.yyyy): ");
            inputDate = Console.ReadLine();
            DateTime dateTwo = DateTime.ParseExact(inputDate, "dd.MM.yyyy", CultureInfo.InvariantCulture);

            double diff = Math.Abs((dateOne - dateTwo).TotalDays);
            Console.WriteLine("Distance: {0} day/s", diff);
        }
    }
}
