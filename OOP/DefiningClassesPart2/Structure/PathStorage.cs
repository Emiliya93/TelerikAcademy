namespace Structure
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    public class PathStorage
    {
        public static void Save(List<Point3D> pathOfPoints3D, string path)
        {
            StreamWriter writer = new StreamWriter(path);

            try
            {
                using (writer)
                {
                    writer.WriteLine(string.Join(Environment.NewLine, pathOfPoints3D));
                }
            }
            catch (UnauthorizedAccessException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(DirectoryNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(PathTooLongException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(IOException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(System.Security.SecurityException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static List<Point3D> Load(string filepath)
        {
            List<Point3D> result = new List<Point3D>();

            try
            {
                using (StreamReader reader = new StreamReader(filepath))
                {
                    string line = string.Empty;

                    while ((line = reader.ReadLine()) != null)
                    {
                        int[] coordinates = line.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                        Point3D currentPoint = new Point3D(coordinates[0], coordinates[1], coordinates[2]);
                        result.Add(currentPoint);
                    }
                }
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (DirectoryNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(NotSupportedException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
            return result;
        }
    }
}
