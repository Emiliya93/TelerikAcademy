using System;
using System.Globalization;
using System.Threading;

/*
    Problem 9. Trapezoids

    Write an expression that calculates trapezoid's area by given sides a and b and height h.
*/

class Trapezoids
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

        Console.Write("Enter side a: ");
        double sideA = double.Parse(Console.ReadLine());

        Console.Write("Enter side b: ");
        double sideB = double.Parse(Console.ReadLine());

        Console.Write("Enter height: ");
        double height = double.Parse(Console.ReadLine());

        double area = ((sideA + sideB) / 2) * height;

        Console.WriteLine("Area: {0}", area);
    }
}