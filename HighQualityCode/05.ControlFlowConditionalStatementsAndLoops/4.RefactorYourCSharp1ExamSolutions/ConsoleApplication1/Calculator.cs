/* Telerik Academy Exam 1 @ 3 February 2015 Morning
    Original code (sent in BGCoder) for Task 3. ConsoleApplication1:

    using System;
    using System.Numerics;

    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            BigInteger numbersCount = -1;
            BigInteger number;
            BigInteger finalProduct = 1;
            BigInteger finalProductMore10 = 1;
            BigInteger currentProduct = 1;

            while (true)
            {
                if (input == "END")
                {
                    break;
                }

                numbersCount++;

                if (numbersCount < 10)
                {
                    number = BigInteger.Parse(input);
                    if (number < 0)
                    {
                        number = -number;
                    }
                    if (number == 0)
                    {
                        number = 1;
                    }
                    if ((numbersCount % 2) != 0)
                    {
                        while (number > 0)
                        {
                            BigInteger digit = number % 10;
                            number /= 10;
                            if (digit == 0)
                            {
                                digit = 1;
                            }
                            currentProduct *= digit;
                        }
                    }
                    else
                    {
                        currentProduct = 1;
                    }
                    finalProduct *= currentProduct;
                    currentProduct = 1;
                }
                if (numbersCount == 10)
                {
                     number = BigInteger.Parse(input);
                    if (number < 0)
                    {
                        number = -number;
                    }
                    if (number == 0)
                    {
                        number = 1;
                    }
                    if ((numbersCount % 2) != 0)
                    {
                        while (number > 0)
                        {
                            BigInteger digit = number % 10;
                            number /= 10;
                            if (digit == 0)
                            {
                                digit = 1;
                            }
                            currentProduct *= digit;
                        }
                    }
                    else
                    {
                        currentProduct = 1;
                    }
                    finalProduct *= currentProduct;
                    finalProductMore10 *= currentProduct;
                    currentProduct = 1;
                }
                // More than 10
                else if (numbersCount > 10)
                {
                    number = BigInteger.Parse(input);
                    if (number < 0)
                    {
                        number = -number;
                    }
                    if (number == 0)
                    {
                        number = 1;
                    }
                    if ((numbersCount % 2) != 0)
                    {
                        while (number > 0)
                        {
                            BigInteger digit = number % 10;
                            number /= 10;
                            if (digit == 0)
                            {
                                digit = 1;
                            }
                            currentProduct *= digit;
                        }
                    }
                    else
                    {
                        currentProduct = 1;
                    }
                    finalProductMore10 *= currentProduct;
                    currentProduct = 1;
                }

                input = Console.ReadLine();
            }
            Console.WriteLine(finalProduct);
            if (finalProductMore10 > 1)
            {
                Console.WriteLine(finalProductMore10);
            }
        }
    }
*/
namespace SpecialProductOfNumbers
{
    using System;
    using System.Numerics;

    public class Calculator
    {
        public static void Main()
        {
            const string EndOfInputData = "END";

            string input = Console.ReadLine();
            BigInteger numbersCount = -1;

            BigInteger finalProduct = 1;
            BigInteger finalProductMore10 = 1;

            BigInteger currentProduct = 1;

            while (true)
            {
                if (input == EndOfInputData)
                {
                    break;
                }

                numbersCount++;
                BigInteger number = BigInteger.Parse(input);

                ConvertTheNumber(input, ref number);

                CalculateCurrentProduct(ref numbersCount, ref currentProduct, ref number);

                if (numbersCount < 10)
                {
                    finalProduct *= currentProduct;
                }

                if (numbersCount == 10)
                {
                    finalProduct *= currentProduct;
                    finalProductMore10 *= currentProduct;
                }
                else if (numbersCount > 10)
                {
                    // More than 10
                    finalProductMore10 *= currentProduct;
                }

                currentProduct = 1;

                input = Console.ReadLine();
            }

            Console.WriteLine(finalProduct);
            if (finalProductMore10 > 1)
            {
                Console.WriteLine(finalProductMore10);
            }
        }

        private static void CalculateCurrentProduct(ref BigInteger numbersCount, ref BigInteger currentProduct, ref BigInteger number)
        {
            if ((numbersCount % 2) != 0)
            {
                while (number > 0)
                {
                    BigInteger digit = number % 10;
                    number /= 10;
                    if (digit == 0)
                    {
                        digit = 1;
                    }

                    currentProduct *= digit;
                }
            }
            else
            {
                currentProduct = 1;
            }
        }

        private static void ConvertTheNumber(string input, ref BigInteger number)
        {
            if (number < 0)
            {
                number = -number;
            }

            if (number == 0)
            {
                number = 1;
            }
        }
    }
}