using System;

namespace Shapes
{
    abstract class Shape
    {
        private double width;
        private double height;

        public double Width
        {
            get
            {
                return this.width;
            }

            set
            {
                if (value>0)
                {
                    this.width = value;
                }
            }
        }

        public double Height
        {
            get
            {
                return this.height;
            }

            set
            {
                if (value > 0)
                {
                    this.height = value;
                }
            }
        }

        public Shape(double width)
        {
            this.Width = width;
        }
        public Shape(double width, double height) : this(width)
        {
            this.Height = height;
        }


        public abstract double CalculateSurface();
    }
}
