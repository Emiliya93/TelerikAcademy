namespace SubtractingPolynomials
{
    using System;
    using AddingPolynomials;
    using System.Linq;

    /*
        Problem 12. Subtracting polynomials

        Extend the previous program to support also subtraction and multiplication of polynomials.

        My Example:
        First Polynom|Coef (c,b,a)   ||Second Polynom|Coef (c,b,a)     ||Add (Polynom)|Coef (c,b,a)   ||Subtract     |Coef (c,b,a)   ||Multyply
        2x^2 - 3     |{ -3, 0, 2 }   ||3x^2 - 2x - 3 |{ -3, -2, 3 }    ||5x^2 - 2x - 6|{ -6, -2, 5 }  ||-x^2 + 2x    |{ 0, 2, -1 }   ||6x^4 - 4x^3 - 15x^2 + 6x + 9
     * 
        2x - 3       |{ -3, 2, 0 }   ||3x^2 - 2x - 3 |{ -3, -2, 3 }    ||3x^2 - 6     |{ -6, 0, 3}    ||-3x^2 + 4x   |{ 0, 4, 3 }    ||6x^3 - 13x^2 + 9
     * 
        x^2 + 5      |{ 5, 0, 1 }    ||2x^2 - x + 3  |{ 3, -1, 2 }     ||3x^2 - x + 8 |{ 8, -1, 3 }   ||-x^2 + x + 2 |{ 2, 1, -1 }   ||2x^4 - x^3 + 13x^2 - 5x + 15
     * 
        x^2 - 3x + 1 |{ 1, -3, 1}    ||x^2 + 2x - 1  |{ -1, 2, 1}      ||2x^2 - x     |{ 0, -1, 2 }   ||-5x + 2      |{ 2, 0, -5 }   ||x^4 - x^3 - 6x^2 + 5x - 1
    */

    class SubtractingPolynomials
    {
        static void Main()
        {
            double[] coefFirstPolynom = AddingPolynomials.GetCoefficients(1);
            double[] coefSecondPolynom = AddingPolynomials.GetCoefficients(2);
            
            Console.Write("Enter operator (+,- or *): ");
            char operatorSymbol = (char)Console.Read();
            double[] result = MathPolynomials(coefFirstPolynom, coefSecondPolynom, operatorSymbol);

            bool hasSomethingInResult = false;
            for (int i = 0; i < result.Length; i++)
            {
                if (result[i] != 0)
                {
                    hasSomethingInResult = true;
                }
            }

            if (hasSomethingInResult)
            {
                PrintPolynomial(result);
            }
            else
            {
                Console.WriteLine("Invalid operator!");
            }
        }

        private static double[] MathPolynomials(double[] coefFirstPolynom, double[] coefSecondPolynom, char operatorSymbol)
        {
            double[] result = new double[coefFirstPolynom.Length + coefSecondPolynom.Length];
            switch (operatorSymbol)
            {
                case '+':
                    {
                        Console.WriteLine();
                        PrintPolynomial(coefFirstPolynom);
                        Console.WriteLine("+");
                        PrintPolynomial(coefSecondPolynom);
                        Console.WriteLine("=");
                        int size = Math.Max(coefFirstPolynom.Length, coefSecondPolynom.Length);
                        double[] result1 = new double[size];
                        for (int i = 0; i < coefFirstPolynom.Length; i++)
                        {
                            result1[i] = coefFirstPolynom[i] + coefSecondPolynom[i];
                        }
                        return result1;
                    }
                case '-':
                    {
                        Console.WriteLine();
                        PrintPolynomial(coefFirstPolynom);
                        Console.WriteLine("-");
                        PrintPolynomial(coefSecondPolynom);
                        Console.WriteLine("=");
                        int size = Math.Max(coefFirstPolynom.Length, coefSecondPolynom.Length);
                        double[] result1 = new double[size];
                        for (int i = 0; i < coefFirstPolynom.Length; i++)
                        {
                            result1[i] = coefFirstPolynom[i] - coefSecondPolynom[i];
                        }
                        return result1;
                    }
                case '*':
                    {
                        Console.WriteLine();
                        PrintPolynomial(coefFirstPolynom);
                        Console.WriteLine("*");
                        PrintPolynomial(coefSecondPolynom);
                        Console.WriteLine("=");
                        int size = coefFirstPolynom.Length + coefSecondPolynom.Length;
                        double[] result1 = new double[size];
                       // int lenght = coefFirstPolynom.Select(x => x != 0).ToArray().Length;
                        for (int i = 0; i < coefFirstPolynom.Length; i++)
                        {
                            for (int j = 0; j < coefSecondPolynom.Length; j++)
                            {
                                result1[i + j] += coefFirstPolynom[i] * coefSecondPolynom[j];
                            }
                        }
                        return result1;
                    }
            }
            return result;
        }

        //print polynomial
        static void PrintPolynomial(double[] polynomial)
        {
            for (int i = polynomial.Length - 1; i >= 0; i--)
            {
                if (polynomial[i] != 0 && i != 0)
                {
                    if (polynomial[i - 1] > 0)
                    {
                        Console.Write("{1}x^{0} +", i, polynomial[i]);
                    }
                    else
                    {
                        Console.Write("{1}x^{0} ", i, polynomial[i]);
                    }
                }
                else if (i == 0 && polynomial[i] != 0)
                {
                    Console.Write("{0}", polynomial[i]);
                }
            }

            Console.WriteLine();
        }
    }
}