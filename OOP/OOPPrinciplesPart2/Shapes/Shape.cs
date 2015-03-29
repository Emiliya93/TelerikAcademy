namespace Shapes
{
    using System;

    public abstract class Shape
    {
        private double width;
        private double height;

        public Shape(double width, double height)
        {
            this.Width = width;
            this.Height = height;

        }

        public double Width
        {
            get
            {
                return this.width;
            }

            private set
            {
                CheckIfValueLessOrEqualToZero(value, "Width cannot be less than or equal to zero!");

                this.width = value;
            }
        }

        public double Height
        {
            get
            {
                return this.height;
            }
            
            private set
            {
                CheckIfValueLessOrEqualToZero(value, "Height cannot be less than or equal to zero!");

                this.height = value;
            }
        }

        private void CheckIfValueLessOrEqualToZero(double value, string message)
        {
            if (value <= 0)
            {
                throw new ArgumentOutOfRangeException(message);
            }
        }

        public abstract double CalculateSurface();
    }
}