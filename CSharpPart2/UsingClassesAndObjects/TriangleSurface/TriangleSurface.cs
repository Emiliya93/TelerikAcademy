namespace TriangleSurface
{
    using System;

    /*
        Problem 4. Triangle surface

        Write methods that calculate the surface of a triangle by given:
        Side and an altitude to it;
        Three sides;
        Two sides and an angle between them;
        Use System.Math.
    */

    class TriangleSurface
    {
        static void Main()
        {
            Console.WriteLine("Please choose an option to calculate the surface of a triangle");
            Console.WriteLine("1 -> by given side and an altitude to it");
            Console.WriteLine("2 -> by given three sides");
            Console.WriteLine("3 -> by given two sides and an angle between them");
            Console.WriteLine();
            Console.Write("Your choice: ");

            int choice = int.Parse(Console.ReadLine());
            while (choice < 1 || choice > 3)
            {
                Console.WriteLine("Incorrect input!");
                Console.Write("Enter choice: ");
                choice = int.Parse(Console.ReadLine());
            }
            Console.WriteLine();

            switch (choice)
            {
                case 1: TriangleSurfaceSideAndAltitude(); break;
                case 2: TriangleSurfaceThreeSides(); break;
                case 3: TriangleSurfaceTwoSidesAndAngle(); break;
                default:  break;
            }
        }

        private static void TriangleSurfaceTwoSidesAndAngle()
        {
            Console.Write("Enter side 1: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Enter side 2: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Enter angle between them: ");
            double angle = double.Parse(Console.ReadLine());

            double sin = Math.Sin(angle * Math.PI / 180);
            double area = (1.0 / 2.0) * a * b * sin;

            Console.WriteLine("Surface of the triangle: {0:F2}", area);
        }

        private static void TriangleSurfaceThreeSides()
        {
            Console.Write("Enter side 1: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Enter side 2: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Enter side 3: ");
            double c = double.Parse(Console.ReadLine());

            double semiPerim = (a + b + c) / 2;
            double area = Math.Sqrt(semiPerim * (semiPerim - a) * (semiPerim - b) * (semiPerim - c));

            Console.WriteLine("Surface of the triangle: {0:F2}", area);
        }

        private static void TriangleSurfaceSideAndAltitude()
        {
            Console.Write("Enter side (base): ");
            double side = double.Parse(Console.ReadLine());
            Console.Write("Enter altitude (height): ");
            double height = double.Parse(Console.ReadLine());
            
            double area = (1.0 / 2.0) * (side * height);

            Console.WriteLine("Surface of the triangle: {0:F2}", area);
        }
    }
}
