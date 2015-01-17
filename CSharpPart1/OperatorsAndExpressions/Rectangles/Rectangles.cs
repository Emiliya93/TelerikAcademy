using System;

/*
    Problem 4. Rectangles

    Write an expression that calculates rectangle’s perimeter and area by given width and height.
*/
class Rectangles
{
    static void Main()
    {
        Console.WriteLine("Enter rectange's width:");
        double width = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter rectange's height:");
        double height = double.Parse(Console.ReadLine());

        double perimeter = 2 * (width + height);
        double area = width * height;

        Console.WriteLine("Rectangle wit width = {0} and height = {1} has:", width, height);
        Console.WriteLine("Perimeter = {0}", perimeter);
        Console.WriteLine("Area = {0}", area);
    }
}
