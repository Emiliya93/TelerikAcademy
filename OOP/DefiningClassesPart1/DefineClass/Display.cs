namespace DefineClass
{
    using System;

    public class Display
    {
        private double? size;
        private long? colors;

        public Display(double? size, long? colors)
        {
            this.Size = size;
            this.Colors = colors;
        }

        public double? Size
        {
            get
            {
                return this.size;
            }
            set
            {
                if (value != null && value < 0)
                {
                    throw new ArgumentException("Size of display cannot be less than zero!");
                }

                this.size = value;
            }
        }

        public long? Colors
        {
            get
            {
                return this.colors;
            }
            set
            {
                if (value != null && value < 0)
                {
                    throw new ArgumentException("Colors of display cannot be less than zero!");
                }

                this.colors = value;
            }
        }
    }
}