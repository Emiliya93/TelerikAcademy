namespace DayOfWeek
{
    using System;

    /*
        Problem 3. Day of week

        Write a program that prints to the console which day of the week is today.
        Use System.DateTime.
    */

    class DayOfWeek
    {
        static void Main()
        {
            DateTime now = DateTime.Now;
            // now = new DateTime(2015, 02, 24);
            Console.WriteLine(now.DayOfWeek);
        }
    }
}
