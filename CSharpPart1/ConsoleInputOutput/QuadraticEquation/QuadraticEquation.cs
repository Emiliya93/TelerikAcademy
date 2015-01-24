using System;

/*
    Problem 6. Quadratic Equation

    Write a program that reads the coefficients a, b and c of a quadratic equation ax2 + bx + c = 0 and solves it (prints its real roots).
*/

class QuadraticEquation
{
    static void Main()
    {
        Console.WriteLine("Enter coefficients of a quadratic equation ax2 + bx + c = 0");
        // Get coefficient a
        Console.Write("Enter coefficient a: ");
        double a;

        while (!(double.TryParse(Console.ReadLine().Replace(',', '.'), out a)))
        {
            Console.WriteLine("Input was not in correct format! You must enter real number!");
            Console.Write("Enter coefficient a: ");
        }

        // Get coefficient b
        Console.Write("Enter coefficient b: ");
        double b;

        while (!(double.TryParse(Console.ReadLine().Replace(',', '.'), out b)))
        {
            Console.WriteLine("Input was not in correct format! You must enter real number!");
            Console.Write("Enter coefficient b: ");
        }

        // Get coefficient c
        Console.Write("Enter coefficient c: ");
        double c;

        while (!(double.TryParse(Console.ReadLine().Replace(',', '.'), out c)))
        {
            Console.WriteLine("Input was not in correct format! You must enter real number!");
            Console.Write("Enter coefficient c: ");
        }

        double discriminant = (b * b) - (4 * a * c);
        double x1;
        double x2;

        if (discriminant > 0)
        {
            x1 = (-b - Math.Sqrt(discriminant)) / (2 * a);
            x2 = (-b + Math.Sqrt(discriminant)) / (2 * a);
            Console.WriteLine("x1 = {0}; x2 = {1}", x1, x2);
        }
        else if (discriminant == 0)
        {
            x1 = (-b) / (2 * a);
            x2 = x1;
            Console.WriteLine("x1=x2={0}", x1);
        }
        else
        {
            Console.WriteLine("No real roots!");
        }
    }
}
