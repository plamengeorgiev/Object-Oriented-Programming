using System;
using System.Collections.Generic;
namespace Shapes
{
    class TestClass
    {
        static void Main(string[] args)
        {
            List<Shape> shapes = new List<Shape>();
            Triangle triangle = new Triangle(3.5,2);
            Rectangle rectangle = new Rectangle(3.5, 6);
            Circle circle = new Circle(3);
            Circle Dalia = new Circle(90);
            shapes.Add(triangle);
            shapes.Add(rectangle);
            shapes.Add(circle);
            foreach (var shape in shapes)
            {
                Console.WriteLine("Type: {0} - Surface: {1} ",shape.GetType().Name, shape.CalculateSurface());
            }

        }
    }
}
