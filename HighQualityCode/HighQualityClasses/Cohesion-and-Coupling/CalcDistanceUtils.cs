namespace CohesionAndCoupling
{
    using System;

    /// <summary>
    /// Calculate distance between two points in 2D or 3D space.
    /// </summary>
    public class CalcDistanceUtils
    {
        /// <summary>
        ///  Calculate distance between two points in 2D space.
        /// </summary>
        /// <param name="x1">First point X coordinate.</param>
        /// <param name="y1">First point Y coordinate.</param>
        /// <param name="x2">Second point X coordinate.</param>
        /// <param name="y2">Second point Y coordinate.</param>
        /// <returns>The distance between the given two points.</returns>
        public static double CalcDistance2D(double x1, double y1, double x2, double y2)
        {
            double differenceByXCordinate = (x2 - x1) * (x2 - x1);
            double differenceByYCoordinate = (y2 - y1) * (y2 - y1);

            double distance = Math.Sqrt(differenceByXCordinate + differenceByYCoordinate);
            return distance;
        }

        /// <summary>
        ///  Calculate distance between two points in 3D space.
        /// </summary>
        /// <param name="x1">First point X coordinate.</param>
        /// <param name="y1">First point Y coordinate.</param>
        /// <param name="z1">First point Z coordinate.</param>
        /// <param name="x2">Second point X coordinate.</param>
        /// <param name="y2">Second point Y coordinate.</param>
        /// <param name="z2">Second point Z coordinate.</param>
        /// <returns>The distance between the given two points.</returns>
        public static double CalcDistance3D(double x1, double y1, double z1, double x2, double y2, double z2)
        {
            double differenceByXCordinate = (x2 - x1) * (x2 - x1);
            double differenceByYCoordinate = (y2 - y1) * (y2 - y1);
            double differenceByZCoordinate = (z2 - z1) * (z2 - z1);

            double distance = Math.Sqrt(differenceByXCordinate + differenceByYCoordinate + differenceByZCoordinate);
            return distance;
        }
    }
}
