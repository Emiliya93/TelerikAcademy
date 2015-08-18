namespace CohesionAndCoupling
{
    using System;

    /// <summary>
    /// Figure in 3D space.
    /// </summary>
    public class Figure3D
    {
        /// <summary>
        /// Encapsulated private field for width.
        /// </summary>
        private double width;

        /// <summary>
        /// Encapsulated private field for height.
        /// </summary>
        private double height;

        /// <summary>
        /// Encapsulated private field for depth.
        /// </summary>
        private double depth;

        /// <summary>
        /// Initializes a new instance of the <see cref="Figure3D"/> class, that creates an instance of figure with given width, height and depth.
        /// </summary>
        /// <param name="width">The width of the instance.</param>
        /// <param name="height">The height of the instance.</param>
        /// <param name="depth">The depth of the instance.</param>
        public Figure3D(double width, double height, double depth)
        {
            this.Width = width;
            this.Height = height;
            this.Depth = depth;
        }

        /// <summary>
        /// Gets the width of the instance.
        /// </summary>
        /// <exception cref="ArgumentOutOfRangeException">The width must be positive number.</exception>
        public double Width
        {
            get
            {
                return this.width;
            }

            private set
            {
                this.CheckIfPositive(value, "Width");

                this.width = value;
            }
        }

        /// <summary>
        /// Gets the height of the instance.
        /// </summary>
        /// <exception cref="ArgumentOutOfRangeException">The width must be positive number.</exception>
        public double Height
        {
            get
            {
                return this.height;
            }

            private set
            {
                this.CheckIfPositive(value, "Height");

                this.height = value;
            }
        }

        /// <summary>
        /// Gets the depth of the instance.
        /// </summary>
        /// <exception cref="ArgumentOutOfRangeException">The width must be positive number.</exception>
        public double Depth
        {
            get
            {
                return this.depth;
            }

            private set
            {
                this.CheckIfPositive(value, "Depth");

                this.depth = value;
            }
        }

        /// <summary>
        /// Calculate the volume of the figure.
        /// </summary>
        /// <returns>The calculated volume.</returns>
        public double CalcVolume()
        {
            double volume = this.Width * this.Height * this.Depth;
            return volume;
        }

        /// <summary>
        /// Calculate distance of the point from the beginning of the 3D coordinate system.
        /// </summary>
        /// <returns>The calculated distance.</returns>
        public double CalcDiagonalXYZ()
        {
            double distance = CalcDistanceUtils.CalcDistance3D(0, 0, 0, this.Width, this.Height, this.Depth);
            return distance;
        }

        /// <summary>
        /// Calculate distance of the point from the beginning of the 2D coordinate system.
        /// </summary>
        /// <returns>The calculated distance.</returns>
        public double CalcDiagonalXY()
        {
            double distance = CalcDistanceUtils.CalcDistance2D(0, 0, this.Width, this.Height);
            return distance;
        }

        /// <summary>
        /// Calculate distance of the point from the beginning of the 3D coordinate system.
        /// </summary>
        /// <returns>The calculated distance.</returns>
        public double CalcDiagonalXZ()
        {
            double distance = CalcDistanceUtils.CalcDistance2D(0, 0, this.Width, this.Depth);
            return distance;
        }

        /// <summary>
        /// Calculate distance of the point from the beginning of the 3D coordinate system.
        /// </summary>
        /// <returns>The calculated distance.</returns>
        public double CalcDiagonalYZ()
        {
            double distance = CalcDistanceUtils.CalcDistance2D(0, 0, this.Height, this.Depth);
            return distance;
        }

        /// <summary>
        /// Validates if the given value is positive.
        /// </summary>
        /// <param name="value">The value to be checked.</param>
        /// <param name="msg">Message to appear in exception. It is followed by " cannot be negative or 0."</param>
        /// <exception cref="ArgumentOutOfRangeException">The width must be positive number.</exception>
        private void CheckIfPositive(double value, string msg)
        {
            if (value <= 0)
            {
                throw new System.ArgumentOutOfRangeException(msg + " cannot be negative or 0.");
            }
        }
    }
}
