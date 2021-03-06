﻿using System;
using System.Globalization;
using System.Threading;

/*
    Problem 4. Rectangles

    Write an expression that calculates rectangle’s perimeter and area by given width and height.
*/
class Rectangles
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

        Console.Write("Enter rectange's width: ");
        double width = double.Parse(Console.ReadLine());

        Console.Write("Enter rectange's height: ");
        double height = double.Parse(Console.ReadLine());

        double perimeter = 2 * (width + height);
        double area = width * height;

        Console.WriteLine("Perimeter = {0}", perimeter);
        Console.WriteLine("Area = {0}", area);
    }
}
