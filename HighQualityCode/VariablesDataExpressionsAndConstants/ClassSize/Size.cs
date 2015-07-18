/* Refactor the following code to use proper variable naming and simplified expressions:

    public class Size
    {
        public double wIdTh, Viso4ina;
        public Size(double w, double h)
        {
            this.wIdTh = w;
            this.Viso4ina = h;
        }

        public static Size GetRotatedSize(
            Size s, double angleOfTheFigureThatWillBeRotaed)
        {
            return new Size(
                Math.Abs(Math.Cos(angleOfTheFigureThatWillBeRotaed)) * s.wIdTh +
                    Math.Abs(Math.Sin(angleOfTheFigureThatWillBeRotaed)) * s.Viso4ina,
                Math.Abs(Math.Sin(angleOfTheFigureThatWillBeRotaed)) * s.wIdTh +
                    Math.Abs(Math.Cos(angleOfTheFigureThatWillBeRotaed)) * s.Viso4ina);
        }
    }
*/
namespace SizeCalculator
{
    using System;

    public class Size
    {
        private double width, height;

        public Size(double width, double height)
        {
            this.width = width;
            this.height = height;
        }

        public static Size GetRotatedSize(Size size, double angleOfTheFigureThatWillBeRotaed)
        {
            double cosineOfAngle = Math.Cos(angleOfTheFigureThatWillBeRotaed),
                   sineOfAngle = Math.Sin(angleOfTheFigureThatWillBeRotaed),
                   absCosineOfAngle = Math.Abs(cosineOfAngle),
                   absSineOfAngle = Math.Abs(sineOfAngle),
                   rotatedFigureWidth = (absCosineOfAngle * size.width) + (absSineOfAngle * size.height),
                   rotatedFigureHeight = (absSineOfAngle * size.width) + (absCosineOfAngle * size.height);

            return new Size(rotatedFigureWidth, rotatedFigureHeight);
        }
    }
}