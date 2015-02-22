namespace AddingPolynomials
{
    using System;
    using System.Linq;

    /*
        Problem 11. Adding polynomials

        Write a method that adds two polynomials.
        Represent them as arrays of their coefficients.
        Example:

        x^2 + 5 = 1x^2 + 0x + 5 => {5, 0, 1}
    */

    public class AddingPolynomials
    {
        static void Main()
        {
            double[] coefFirstPolynom = GetCoefficients(1);
            double[] coefSecondPolynom = GetCoefficients(2);
           
            double[] resultOfAdding = AddTwoPolynomials(coefFirstPolynom, coefSecondPolynom);

            Console.WriteLine("Coeficients (c, b, a) of sum of the polynomials");
            Console.WriteLine("a*x^2 + b*x + c");
            Console.WriteLine(string.Join(" ", resultOfAdding));
            //Console.WriteLine("{0}*x^2 + {1}*x + {2}", coefFirstPolynom[2], coefFirstPolynom[1], coefFirstPolynom[0]);
            //Console.WriteLine("+");
            //Console.WriteLine("{0}*x^2 + {1}*x + {2}", coefSecondPolynom[2], coefSecondPolynom[1], coefSecondPolynom[0]);
            //Console.WriteLine("=");
            //Console.WriteLine("{0}*x^2 + {1}*x + {2}", resultOfAdding[2], resultOfAdding[1], resultOfAdding[0]);
        }

        private static double[] AddTwoPolynomials(double[] coefFirstPolynom, double[] coefSecondPolynom)
        {
            double[] result = new double[coefFirstPolynom.Length];
            for (int i = 0; i < coefFirstPolynom.Length; i++)
            {
                result[i] = coefFirstPolynom[i] + coefSecondPolynom[i]; 
            }
            return result;
        }

        public static double[] GetCoefficients(int i)
        {
            Console.WriteLine("Enter coeficients (c, b, a) of polynomial {0} (separated by space):", i);
            Console.WriteLine("a*x^2 + b*x + c");
            //Console.Write("c: ");
            //double c = double.Parse(Console.ReadLine());
            //Console.Write("b: ");
            //double b = double.Parse(Console.ReadLine());
            //Console.Write("a: ");
            //double a = double.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            string[] coefString = input.Split(new char[]{' ', ','}, StringSplitOptions.RemoveEmptyEntries);

            double[] coefficients = coefString.Select(double.Parse).ToArray();

            return coefficients;
        }
    }
}
