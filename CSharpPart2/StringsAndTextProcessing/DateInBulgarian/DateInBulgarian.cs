namespace DateInBulgarian
{
    using System;
    using System.Globalization;
    using System.Text;
    using System.Threading;

    /*
        Problem 17. Date in Bulgarian

        Write a program that reads a date and time given in the format: day.month.year hour:minute:second and prints the date and time 
        after 6 hours and 30 minutes (in the same format) along with the day of week in Bulgarian.
     * My example:
     * input                output
     * 23.03.2003 12:24:22
    */

    class DateInBulgarian
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.Unicode;
            Thread.CurrentThread.CurrentCulture = new CultureInfo("bg-BG");
            CultureInfo culture = CultureInfo.GetCultureInfo("bg-BG");

            Console.WriteLine("Enter date in format: dd.MM.yyyy HH:mm:ss");
            string dateString = Console.ReadLine();
            DateTime date = DateTime.ParseExact(dateString, "dd.MM.yyyy HH:mm:ss", culture);

            TimeSpan timeToAdd = new TimeSpan(6, 30, 0);
            DateTime newDate = date.Add(timeToAdd);
            Console.Write(newDate);
            switch (newDate.DayOfWeek)
            {
                case DayOfWeek.Friday: Console.WriteLine(" петък"); break;
                case DayOfWeek.Monday: Console.WriteLine(" понеделник"); break;
                case DayOfWeek.Saturday: Console.WriteLine(" събота"); break;
                case DayOfWeek.Sunday: Console.WriteLine(" неделя"); break;
                case DayOfWeek.Thursday: Console.WriteLine(" четвъртък"); break;
                case DayOfWeek.Tuesday: Console.WriteLine(" вторник"); break;
                case DayOfWeek.Wednesday: Console.WriteLine(" сряда"); break;
                default: break;
            }
        }
    }
}
