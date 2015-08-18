namespace CohesionAndCoupling
{
    using System;

    /// <summary>
    /// Examples of using the utility classes and methods.
    /// </summary>
    public class UtilsExamples
    {
        /// <summary>
        /// The main method to test functionality.
        /// </summary>
        public static void Main()
        {
            Console.WriteLine(FileNameAndExtensionUtils.GetFileExtension("example"));
            Console.WriteLine(FileNameAndExtensionUtils.GetFileExtension("example.pdf"));
            Console.WriteLine(FileNameAndExtensionUtils.GetFileExtension("example.new.pdf"));

            Console.WriteLine(FileNameAndExtensionUtils.GetFileNameWithoutExtension("example"));
            Console.WriteLine(FileNameAndExtensionUtils.GetFileNameWithoutExtension("example.pdf"));
            Console.WriteLine(FileNameAndExtensionUtils.GetFileNameWithoutExtension("example.new.pdf"));

            Console.WriteLine(
                "Distance in the 2D space = {0:f2}",
                CalcDistanceUtils.CalcDistance2D(1, -2, 3, 4));

            Console.WriteLine(
                "Distance in the 3D space = {0:f2}",
                CalcDistanceUtils.CalcDistance3D(5, 2, -1, 3, -6, 4));

            Figure3D figure = new Figure3D(3, 4, 5);
            Console.WriteLine("Volume = {0:f2}", figure.CalcVolume());
            Console.WriteLine("Diagonal XYZ = {0:f2}", figure.CalcDiagonalXYZ());
            Console.WriteLine("Diagonal XY = {0:f2}", figure.CalcDiagonalXY());
            Console.WriteLine("Diagonal XZ = {0:f2}", figure.CalcDiagonalXZ());
            Console.WriteLine("Diagonal YZ = {0:f2}", figure.CalcDiagonalYZ());
        }
    }
}
