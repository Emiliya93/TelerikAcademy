using System;

/*
    Problem 10. Employee Data

    A marketing company wants to keep record of its employees. Each record would have the following characteristics:

    First name
    Last name
    Age (0...100)
    Gender (m or f)
    Personal ID number (e.g. 8306112507)
    Unique employee number (27560000…27569999)
    Declare the variables needed to keep the information for a single employee using appropriate primitive data types.
    Use descriptive names. Print the data at the console.
*/

class EmployeeData
{
    static void Main()
    {
        // Read from console the employee data
        Console.WriteLine("Enter Employee Data:");
        Console.Write("First Name: ");
        string firstName = Console.ReadLine();

        Console.Write("Last Name: ");
        string lastName = Console.ReadLine();

        Console.Write("Age (0 - 100): ");
        byte age = byte.Parse(Console.ReadLine());

        // Read only one character
        Console.Write("Gender (m or f): ");
        // This will take only the first character from the input
        char gender = Console.ReadLine()[0];

        Console.Write("ID Number (e.g. 8306112507): ");
        long idNumber = long.Parse(Console.ReadLine());

        Console.Write("Unique employee number (27560000…27569999): ");
        int uniqueNumber = int.Parse(Console.ReadLine());

        Console.WriteLine("Employee information");
        Console.WriteLine();
        Console.WriteLine("First name: {0}", firstName);
        Console.WriteLine("Last name: {0}", lastName);
        Console.WriteLine("Age: {0}", age);
        Console.WriteLine("Gender: {0}", gender);
        Console.WriteLine("Personal ID number: {0}", idNumber);
        Console.WriteLine("Unique employee number: {0}", uniqueNumber);
    }
}