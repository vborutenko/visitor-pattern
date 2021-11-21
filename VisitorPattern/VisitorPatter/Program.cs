using System;
using System.Collections.Generic;
using System.Text;
using VisitorPattern.Shapes;

namespace VisitorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var shapes = new List<Shape>
            {
                new Triangle
                {
                    A = 5,
                    B = 8,
                    C = 10
                },
                new Circle{Radius = 10},
                new Circle{Radius = 15},
                new Rectangle{Width = 10,Height = 15},
                new Rectangle{Width = 25,Height = 5}
            };

            var customExport = new CustomExport();
            shapes.ForEach(s => s.Accept(customExport));

            Console.WriteLine(customExport.GetResult());
            Console.ReadKey();


        }
    }

    public interface IShapeVisitor
    {
        public void VisitCircle(Circle circle);
        public void VisitTriangle(Triangle triangle);
        public void VisitRectangle(Rectangle rectangle);
    }

    public class CustomExport : IShapeVisitor
    {
        private StringBuilder _export = new();

        public void VisitCircle(Circle circle)
        {
            _export.AppendLine($"Radius = {circle.Radius}");
        }

        public void VisitTriangle(Triangle triangle)
        {
            _export.AppendLine($"Side 1 = {triangle.A},Side 2 = {triangle.B},Side 3 = {triangle.C}");
        }

        public void VisitRectangle(Rectangle rectangle)
        {
            _export.AppendLine($"Width 1 = {rectangle.Width} Width 2 = {rectangle.Width}");
        }

        public string GetResult() => _export.ToString();

    }
}
