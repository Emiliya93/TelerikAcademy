namespace Abstraction
{
    using System;

    internal class Circle : Figure
    {
        private double radius;

        public Circle()
        {
        }

        public Circle(double radius)
        {
            this.Radius = radius;
        }

        /// <summary>
        /// Circle's radius property
        /// </summary>
        /// <exception cref="ArgumentOutOfRangeException">Radius must be positive number</exception>
        public double Radius
        {
            get
            {
                return this.radius;
            }

            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Radius of circle is incorrect (must be positive number)!");
                }

                this.radius = value;
            }
        }

        internal override double CalcPerimeter()
        {
            double perimeter = 2 * Math.PI * this.Radius;
            return perimeter;
        }

        internal override double CalcSurface()
        {
            double surface = Math.PI * this.Radius * this.Radius;
            return surface;
        }
    }
}
