namespace Structure
{
    using System;
    using System.Collections.Generic;

    public class Path
    {
        private List<Point3D> pathOfPoints3D;

        public Path()
        {
            this.PathOfPoints3D = new List<Point3D>();
        }

        public List<Point3D> PathOfPoints3D
        {
            get
            {
                return this.pathOfPoints3D;
            }

            set
            {
                this.pathOfPoints3D = value;
            }
        }

        public void Add(Point3D newPoint)
        {
            //TODO: Check if is nessecary to use property
            this.PathOfPoints3D.Add(newPoint);
        }

        public void Clear()
        {
            this.pathOfPoints3D.Clear();
        }

        public int Count()
        {
            return this.pathOfPoints3D.Count;
        }
    }
}
