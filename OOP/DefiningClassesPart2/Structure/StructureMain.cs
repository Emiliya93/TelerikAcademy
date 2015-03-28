namespace Structure
{
    using System;

    class StructureMain
    {
        static void Main()
        {
            //Point3D point = new Point3D(2, 0, 3);
            //Console.WriteLine(point);

            //Console.WriteLine(MathMethodsPoint.Point0);
            //Console.WriteLine(MathMethodsPoint.CalculateDistance(point, MathMethodsPoint.Point0));
            Path pathOfPoints = new Path();
            pathOfPoints.PathOfPoints3D.Add(new Point3D(2, 0, 3));
            pathOfPoints.PathOfPoints3D.Add(new Point3D(3, 5, 1));
            pathOfPoints.PathOfPoints3D.Add(new Point3D(7, 8, 9));
            pathOfPoints.PathOfPoints3D.Add(new Point3D(2, 4, 3));
            
            //foreach (Point3D pathPoint in pathOfPoints.PathOfPoints3D)
            //{
            //    Console.WriteLine(pathPoint);
            //}
            //Console.WriteLine(string.Join(Environment.NewLine, pathOfPoints.PathOfPoints3D));
            PathStorage.Save(pathOfPoints.PathOfPoints3D, "..\\..\\Files\\saved.txt");
            Console.WriteLine("List of points saved!");
        }
    }
}
