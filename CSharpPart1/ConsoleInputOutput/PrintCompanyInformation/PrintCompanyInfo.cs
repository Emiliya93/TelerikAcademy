using System;

/*
    Problem 2. Print Company Information

    A company has name, address, phone number, fax number, web site and manager.
    The manager has first name, last name, age and a phone number.
    Write a program that reads the information about a company and its manager and prints it back on the console.

    Example output:

    Telerik Academy
    Address: 231 Al. Malinov, Sofia
    Tel. +359 888 55 55 555
    Fax: (no fax)
    Web site: http://telerikacademy.com/
    Manager: Nikolay Kostov (age: 25, tel. +359 2 981 981) 
*/

class PrintCompanyInfo
{
    static void Main()
    {
        // Get company information
        Console.WriteLine("Enter company information:");
        Console.Write("Company name: ");
        string companyName = Console.ReadLine();

        Console.Write("Company address: ");
        string companyAddress = Console.ReadLine();

        Console.Write("Phone number: ");
        string companyPhoneNumber = Console.ReadLine();

        Console.Write("Fax number: ");
        string companyFaxNumber = Console.ReadLine();

        // Fax number check
        if (companyFaxNumber.Length < 10)
        {
            companyFaxNumber = "no fax";
        }

        Console.Write("Enter web site: ");
        string webSite = Console.ReadLine();

        Console.WriteLine("Manager information:");
        Console.Write("Manager first name: ");
        string managerFirstName = Console.ReadLine();

        Console.Write("Manager last name: ");
        string managerLastName = Console.ReadLine();

        string managerName = managerFirstName + " " + managerLastName;

        Console.Write("Manager age: ");
        byte managerAge;

        // Is correct input for age
        while (!(byte.TryParse(Console.ReadLine(), out managerAge)))
        {
            Console.WriteLine("Input was not in correct format. You must enter real age!");
            Console.Write("Manager age: ");
        }

        Console.Write("Manager phone: ");
        string managerPhone = Console.ReadLine();

        // Print the information
        Console.WriteLine();
        Console.WriteLine(companyName);
        Console.WriteLine("Address: {0}", companyAddress);
        Console.WriteLine("Tel. {0}", companyPhoneNumber);
        Console.WriteLine("Fax: ({0})", companyFaxNumber);
        Console.WriteLine("Web-site: {0}", webSite);
        Console.WriteLine("Manager: {0} (age: {1}, tel. {2})", managerName, managerAge, managerPhone);
    }
}