using System;
using System.Globalization;
using System.Threading;

/*
    Problem 3. Circle Perimeter and Area

    Write a program that reads the radius r of a circle and prints its perimeter and area formatted with 2 digits after the decimal point.

    Examples:

    r	|perimeter|area
    2	|12.57	  |12.57
    3.5	|21.99	  |38.48
*/

class CirclePerimeterAndArea
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

        Console.Write("Enter circle radius: ");
        double radius;
        string input = Console.ReadLine().Replace(',','.');
        bool isParsable = double.TryParse(input, out radius);

        // Check if input can be parsed to double
        while (isParsable == false)
        {
            Console.WriteLine("Input was not in correct format. You must enter real number!");
            Console.Write("Enter circle radius: ");
            input = Console.ReadLine().Replace(',', '.');
            isParsable = double.TryParse(input, out radius);
        }

        double perimeter = 2 * Math.PI * radius;
        double area = Math.PI * radius * radius;

        Console.WriteLine("Perimeter: {0:0.00}", perimeter);
        Console.WriteLine("Area: {0:F2}", area);
    }
}