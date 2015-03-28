namespace Structure
{
    using System;

    public static class MathMethodsPoint
    {
        private static readonly Point3D pointO = new Point3D(0, 0, 0);

        public static Point3D Point0 
        {
            get
            {
                return MathMethodsPoint.pointO;
            }
        }

        public static double CalculateDistance(Point3D firstPoint, Point3D secondPoint)
        {
            double distance = Math.Sqrt(Math.Pow(firstPoint.X - secondPoint.X, 2) + Math.Pow(firstPoint.Y - secondPoint.Y, 2) + Math.Pow(firstPoint.Z - secondPoint.Z, 2));

            return distance;
        }
    }
}
