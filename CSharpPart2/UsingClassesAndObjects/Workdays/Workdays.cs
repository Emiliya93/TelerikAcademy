namespace Workdays
{
    using System;
    using System.Collections.Generic;

    /*
        Problem 5. Workdays

        Write a method that calculates the number of workdays between today and given date, passed as parameter.
        Consider that workdays are all days from Monday to Friday except a fixed list of public holidays specified preliminary as array.
    */

    class Workdays
    {
        static void Main()
        {
            Console.WriteLine("Calculate workdays");
            Console.Write("Enter date (YYYY:MM:DD): ");
            DateTime day = DateTime.Parse(Console.ReadLine());

            int workdays = CountWorkDays(day);
            if (workdays <= 0)
            {
                Console.WriteLine("No workdays!");
            }
            else
            {
                Console.WriteLine("From {0:dd/MMM/yyyy} to {1:dd/MMM/yyyy} (inclusive) the workdays are:", DateTime.Now.Date, day.Date);
                Console.WriteLine("Workdays: {0}", workdays);
            }
        }

        static int CountWorkDays(DateTime toDate)
        {
            List<DateTime> holidays = new List<DateTime>();
            holidays.Add(new DateTime(2015, 01, 01));
            holidays.Add(new DateTime(2015, 03, 02));
            holidays.Add(new DateTime(2015, 03, 03));
            holidays.Add(new DateTime(2015, 04, 10));
            holidays.Add(new DateTime(2015, 04, 11));
            holidays.Add(new DateTime(2015, 04, 12));
            holidays.Add(new DateTime(2015, 04, 13));
            holidays.Add(new DateTime(2015, 05, 01));
            holidays.Add(new DateTime(2015, 05, 06));
            holidays.Add(new DateTime(2015, 09, 21));
            holidays.Add(new DateTime(2015, 09, 22));
            holidays.Add(new DateTime(2015, 12, 24));
            holidays.Add(new DateTime(2015, 12, 25));
            holidays.Add(new DateTime(2015, 12, 26));
            holidays.Add(new DateTime(2015, 12, 31));
            holidays.Add(new DateTime(2016, 01, 01));

            DateTime today = DateTime.Now;
            int years = 0;
            if (toDate.Year != today.Year)
            {
                if (toDate.Year > today.Year)
                {
                    years = toDate.Year - today.Year;
                }
                else if (toDate.Year < today.Year)
                {
                    return -1;
                }
            }
            int distance = toDate.DayOfYear - today.DayOfYear + years*365;
            int workdays = 0;
            for (int i = 1; i <= distance; i++)
            {
                DateTime currentDay = today.AddDays(i);

                if (currentDay.DayOfWeek == DayOfWeek.Saturday || currentDay.DayOfWeek == DayOfWeek.Sunday)
                {
                    continue;
                }

                for (int j = 0; j < holidays.Count; j++)
                {
                    if (today.AddDays(i).Date == (holidays[j]).Date)
                    {
                        workdays--;
                    }
                }
                
                workdays++;
            }

            return workdays;
        }
    }
}
