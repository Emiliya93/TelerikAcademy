using System;

/*Problem 15.* Age after 10 Years

Write a program to read your birthday from the console and print how old you are now and how old you will be after 10 years.*/

class AgeAfterTenYears
{
    static void Main()
    {
        //Collecting information about user birthday
        Console.WriteLine("Please enter your date of birth (for example: DD MM YYYY):");

        Console.WriteLine("Day: ");
        int dayOfBirth = int.Parse(Console.ReadLine());

        Console.WriteLine("Month: ");
        int monthOfBirth = int.Parse(Console.ReadLine());

        Console.WriteLine("Year: ");
        int yearOfBirth = int.Parse(Console.ReadLine());

        DateTime birthday = new DateTime(yearOfBirth, monthOfBirth, dayOfBirth);
        //End of collecting information

        //Checking how old the user is
        DateTime today = DateTime.Now;
        int years;

        if ((today.Month <= birthday.Month) && (today.Day <= birthday.Day))
        {
            years = (int)today.Year - 1 - (int)birthday.Year;
            Console.WriteLine("Your age now:");
            Console.WriteLine(years);
        }
        else
        {
            years = (int)today.Year - (int)birthday.Year;
            Console.WriteLine("Your age now:");
            Console.WriteLine(years);
        }
        //End of checking the user age

        //Age after 10 years
        Console.WriteLine("Your age after 10 years:");
        Console.Write(years + 10);
        Console.WriteLine("years");
    }
}
