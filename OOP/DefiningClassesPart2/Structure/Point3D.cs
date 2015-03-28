namespace Structure
{
    using System;
    using System.Text;

    public struct Point3D
    {
        public Point3D (double x, double y, double z) : this()
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }

        public double X { get; set; }

        public double Y { get; set; }

        public double Z { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(string.Format("X: {0}{1}Y: {2}{1}Z: {3}{1}", this.X, Environment.NewLine, this.Y, this.Z));

            return sb.ToString();
        }
    }
}
