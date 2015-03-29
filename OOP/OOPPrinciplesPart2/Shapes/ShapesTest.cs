namespace Shapes
{
    using System;

    class ShapesTest
    {
        static void Main()
        {
            Shape[] shapes = 
            {
                new Triangle(12, 23),
                new Rectangle(12, 23),
                new Square(12)
            };

            foreach (var shape in shapes)
            {
                Console.WriteLine("{0, -9} -> Width: {1}; Height: {2} -> Surface: {3}", shape.GetType().Name, shape.Width, shape.Height, shape.CalculateSurface());
            }
        }
    }
}