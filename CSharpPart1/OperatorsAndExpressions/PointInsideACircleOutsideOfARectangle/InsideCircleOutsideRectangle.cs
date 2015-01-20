using System;

/*
    Problem 10. Point Inside a Circle & Outside of a Rectangle

    Write an expression that checks for given point (x, y) if it is 
    within the circle K({1, 1}, 1.5) and out of the rectangle R(top=1, left=-1, width=6, height=2).
*/


class InsideCircleOutsideRectangle
{
    static void Main()
    {
        Console.Write("Enter point coordinate by X: ");
        double pointX = double.Parse(Console.ReadLine());

        Console.Write("Enter point coordinate by Y: ");
        double pointY = double.Parse(Console.ReadLine());

        // Circle coordinates
        int centerX = 1;
        int centerY = 1;
        double radius = 1.5;

        //Rectangle: two points representing the opposing corners
        int bottomLeftCornerX = -1;
        int bottomLeftCornerY = -1;
        int topRightCornerX = 5;
        int topRightCornerY = 1;

        // Check if point is inside the circle K({1, 1}, 1.5)
        bool isInCircle = false;

        double dx = Math.Abs(pointX - centerX);
        double dy = Math.Abs(pointY - centerY);

        if ((dx * dx + dy * dy) <= radius * radius)
        {
            isInCircle = true;
        }
        else
        {
            isInCircle = false;
        }

        // Check if point is outside the rectangle
        bool isOutsideRectangle = false;

        if (((pointX >= bottomLeftCornerX) && (pointX <= topRightCornerX)) && ((pointY >= bottomLeftCornerY) && (pointY <= topRightCornerY)))
        {
            // The point is inside the rectangle
            isOutsideRectangle = false;
        }
        else
        {
            isOutsideRectangle = true;
        }

        if (isInCircle && isOutsideRectangle)
        {
            // given point (x, y) is within the circle and out of the rectangle
            Console.WriteLine("yes");
        }
        else
        {
            Console.WriteLine("no");
        }
    }
}