using System;
using System.Globalization;
using System.Threading;

/*
    Problem 10.* Beer Time

    A beer time is after 1:00 PM and before 3:00 AM.
    Write a program that enters a time in format “hh:mm tt” (an hour in range [01...12], a minute in range [00…59] and AM / PM designator)
    and prints beer time or non-beer time according to the definition above or invalid time if the time cannot be parsed.
    Note: You may need to learn how to parse dates and times.
    Examples:

    time	    |result
    1:00 PM	    |beer time
    4:30 PM	    |beer time
    10:57 PM	|beer time
    8:30 AM	    |non-beer time
    02:59 AM	|beer time
    03:00 AM	|non-beer time
    03:26 AM	|non-beer time
*/

class BeerTime
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

        Console.WriteLine("Enter time in format \"hh:mm tt\"");
        Console.WriteLine("An hour in range [01...12], a minute in range [00…59] and AM / PM designator: ");
        DateTime timeNow;

        while (!(DateTime.TryParse(Console.ReadLine(), out timeNow)))
        {
            Console.WriteLine("Input was not in correct format!");
            Console.Write("Enter time in format \"hh:mm tt\" (an hour in range [01...12], a minute in range [00…59] and AM / PM designator): ");
        }

        Console.WriteLine(timeNow);

        DateTime after = DateTime.Parse("1:00 pm");
        DateTime before = DateTime.Parse("3:00 am");

        Console.WriteLine(after);
        Console.WriteLine(before);

        if ((timeNow.CompareTo(after) >= 0) || (timeNow.CompareTo(before) < 0))
        {
            Console.WriteLine("beer time");
        }
        else
        {
            Console.WriteLine("non-beer time");
        }
    }
}