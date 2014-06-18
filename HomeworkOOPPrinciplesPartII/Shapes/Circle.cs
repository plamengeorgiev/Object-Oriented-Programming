using System;

namespace Shapes
{
    class Circle : Shape
    {
        public Circle(double radius) : base(radius) { }

        public override double CalculateSurface()
        {
            return Math.PI * this.Width * 2;
        }
    }
}
