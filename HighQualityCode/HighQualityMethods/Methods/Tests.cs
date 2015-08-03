namespace Methods
{
    using System;

    public class Tests
    {
        public static void Main()
        {
            Console.WriteLine(Methods.CalcTriangleArea(3, 4, 5));

            Console.WriteLine(Methods.NumberToDigit(5));

            Console.WriteLine(Methods.FindMax(5, -1, 3, 2, 14, 2, 3));

            Methods.PrintNumberWithPrecision(1.3);
            Methods.PrintNumberAsPercentage(0.75);
            Methods.PrintNumberAlignedRight(2.30);
            
            double x1 = 3,
                   y1 = -1,
                   x2 = 3,
                   y2 = 2.5;
            Console.WriteLine(Methods.CalcDistance(x1, y1, x2, y2));

            bool horizontal = Methods.IsLineHorizontal(y1, y2),
                 vertical = Methods.IsLineVertical(x1, x2);

            Console.WriteLine("Horizontal? " + horizontal);
            Console.WriteLine("Vertical? " + vertical);

            Student peter = new Student("Peter", "Ivanov", new DateTime(1992, 03, 17), "From Sofia, born at ");

            Student stella = new Student("Stella", "Markova", new DateTime(1993, 11, 03), "From Vidin, gamer, high results, born at 03.11.1993");

            Console.WriteLine("{0} older than {1} -> {2}", peter.FirstName, stella.FirstName, peter.IsOlderThan(stella));
        }
    }
}
