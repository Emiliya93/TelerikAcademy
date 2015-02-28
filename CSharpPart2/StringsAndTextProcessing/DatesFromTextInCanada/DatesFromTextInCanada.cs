namespace DatesFromTextInCanada
{
    using System;
    using System.Globalization;
    using System.Text.RegularExpressions;
    using System.Threading;

    /*
        Problem 19. Dates from text in Canada

        Write a program that extracts from a given text all dates that match the format DD.MM.YYYY.
        Display them in the standard date format for Canada.
    */

    class DatesFromTextInCanada
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-CA");
            CultureInfo culture = Thread.CurrentThread.CurrentCulture;

            string input = "02.20.1994 3.2.2001 31.12.2555"; //Console.ReadLine();
            string format = "d.M.yyyy";
            string pattern = @"[\d]{1,2}.[\d]{1,2}.[\d]{2,4}";

            foreach (Match date in Regex.Matches(input, pattern))
            {
                try
                {
                    DateTime parsedDate = DateTime.ParseExact(date.ToString(), format, culture);
                    Console.WriteLine(parsedDate.ToShortDateString());
                }
                catch
                {
                    continue;
                }
            }
        }
    }
}
