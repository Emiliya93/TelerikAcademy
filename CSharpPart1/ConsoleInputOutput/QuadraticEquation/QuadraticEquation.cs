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
        Console.Write("Enter coefficient a (different from 0): ");
        double a;
        string input = Console.ReadLine().Replace(',', '.');
        bool isParsable = double.TryParse(input, out a);

        while ((isParsable == false) || (a == 0))
        {
            Console.WriteLine("Input was not in correct format! You must enter real number!");
            Console.Write("Enter coefficient a (different from 0): ");
            input = Console.ReadLine().Replace(',', '.');
            isParsable = double.TryParse(input, out a);
        }

        // Get coefficient b
        Console.Write("Enter coefficient b: ");
        double b;
        input = Console.ReadLine().Replace(',', '.');
        isParsable = double.TryParse(input, out b);

        while (isParsable == false)
        {
            Console.WriteLine("Input was not in correct format! You must enter real number!");
            Console.Write("Enter coefficient b: ");
        }

        // Get coefficient c
        Console.Write("Enter coefficient c: ");
        double c;
        input = Console.ReadLine().Replace(',', '.');
        isParsable = double.TryParse(input, out c);

        while (isParsable == false)
        {
            Console.WriteLine("Input was not in correct format! You must enter real number!");
            Console.Write("Enter coefficient c: ");
            input = Console.ReadLine().Replace(',', '.');
            isParsable = double.TryParse(input, out c);
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
