using System;

/*
    Problem 7. Point in a Circle

    Write an expression that checks if given point (x, y) is inside a circle K({0, 0}, 2).
*/

class PointInACircle
{
    static void Main()
    {
        int centerX = 0;
        int centerY = 0;
        int radius = 2;

        Console.WriteLine("Enter a point coordinate by x:");
        double x = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter a point coordinate by y:");
        double y = double.Parse(Console.ReadLine());

        double dx = Math.Abs(x - centerX);
        double dy = Math.Abs(y - centerY);

        if ((dx*dx + dy*dy) <= radius*radius)
        {
            Console.WriteLine("True");
        }
        else
        {
            Console.WriteLine("False");
        }
    }
}
