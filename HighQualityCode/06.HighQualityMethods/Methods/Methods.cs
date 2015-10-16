namespace Methods
{
    using System;

    public class Methods
    {
        public static double CalcTriangleArea(double firstSide, double secondSide, double thirdSide)
        {
            if (firstSide <= 0 || secondSide <= 0 || thirdSide <= 0)
            {
                throw new ArgumentOutOfRangeException("Sides should be positive.");
            }

            if (firstSide + secondSide < thirdSide ||
                firstSide + thirdSide < secondSide ||
                secondSide + thirdSide < firstSide)
            {
                throw new ArgumentOutOfRangeException("No side can be longer than the sum of the other two sides");
            }

            double semiperimeter = (firstSide + secondSide + thirdSide) / 2;
            double semiperimeterMinusSidesFormula = semiperimeter * (semiperimeter - firstSide) * (semiperimeter - secondSide) * (semiperimeter - thirdSide);
            double area = Math.Sqrt(semiperimeterMinusSidesFormula);
            return area;
        }

        public static string NumberToDigit(int number)
        {
            switch (number)
            {
                case 0: return "zero";
                case 1: return "one";
                case 2: return "two";
                case 3: return "three";
                case 4: return "four";
                case 5: return "five";
                case 6: return "six";
                case 7: return "seven";
                case 8: return "eight";
                case 9: return "nine";
                default: throw new ArgumentException("Invalid number.");
            }
        }

        public static int FindMax(params int[] elements)
        {
            if (elements == null || elements.Length == 0)
            {
                throw new ArgumentException("Invalid elements passed.");
            }

            int max = elements[0];
            for (int i = 1; i < elements.Length; i++)
            {
                if (elements[i] > max)
                {
                    max = elements[i];
                }
            }

            return max;
        }

        public static void PrintNumberWithPrecision(double number)
        {
            Console.WriteLine("{0:f2}", number);
        }

        public static void PrintNumberAsPercentage(double number)
        {
            Console.WriteLine("{0:p0}", number);
        }

        public static void PrintNumberAlignedRight(double number)
        {
            Console.WriteLine("{0,8}", number);
        }

        public static double CalcDistance(double x1, double y1, double x2, double y2)
        {
            double differenceByXCordinate = (x2 - x1) * (x2 - x1);
            double differenceByYCoordinate = (y2 - y1) * (y2 - y1);
            double distance = Math.Sqrt(differenceByXCordinate + differenceByYCoordinate);

            return distance;
        }

        public static bool IsLineVertical(double x1, double x2)
        {
            bool isVertical = x1 == x2;
            return isVertical;
        }

        public static bool IsLineHorizontal(double y1, double y2)
        {
            bool isHorizontal = y1 == y2;
            return isHorizontal;
        }
    }
}
