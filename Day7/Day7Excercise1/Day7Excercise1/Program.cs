// See https://aka.ms/new-console-template for more information

System.Console.OutputEncoding = System.Text.Encoding.UTF8;

Random rng = new Random();

List<Shapes.Shape> shapes = new List<Shapes.Shape>();

Shapes.Circle circle = new Shapes.Circle(
    Math.Round(rng.NextDouble() * 100, 2)
);
Shapes.Triangle triangle = new Shapes.Triangle(
    Math.Round(rng.NextDouble() * 100, 2), 
    Math.Round(rng.NextDouble() * 100, 2)
);
Shapes.Rectangle rectangle = new Shapes.Rectangle(
    Math.Round(rng.NextDouble() * 100, 2), 
    Math.Round(rng.NextDouble() * 100, 2)
);

shapes.InsertRange(shapes.Count, new Shapes.Shape[] 
{ 
    circle, 
    triangle, 
    rectangle 
});

Console.WriteLine(circle);
Console.WriteLine(triangle);
Console.WriteLine(rectangle);

namespace Shapes
{
    public abstract class Shape
    {
        public string ShapeID { get; set; }
        public Shape()
        {
            this.ShapeID = "BasicShape";
        }
        public Shape(string ShapeID)
        {
            if (ShapeID != null)
            {
                this.ShapeID = ShapeID;
            }
            else
            {
                this.ShapeID = "BasicShape";
            }
        }

        public abstract double CalculateArea();

    }

    public class Circle : Shape
    {
        public double radius = 0;
        public Circle(double radius)
        {
            if (radius > 0)
            {
                this.radius = radius;
            }
            ShapeID = "Circle";
        }

        public override double CalculateArea()
        {
            return Math.Round((radius * radius) * Math.PI, 2);
        }

        public override string ToString()
        {
            return "[" + ShapeID + "] Radius: " + radius + "cm, Area: " + CalculateArea() + "cm²";
        }
    }

    public class Triangle : Shape
    {
        public double baseLength = 0;
        public double height = 0;

        public Triangle(double baseLength, double height)
        {
            if (baseLength > 0 && height > 0)
            {
                this.baseLength = baseLength;
                this.height = height;
            }
            ShapeID = "Triangle";
        }

        public override double CalculateArea()
        {
            return Math.Round(0.5 * baseLength * height, 2);
        }

        public override string ToString()
        {
            return "[" + ShapeID + "] Base: " + baseLength + "cm, Height: " + height + "cm, Area: " + CalculateArea() + "cm²";
        }
    }

    public class Rectangle : Shape
    {
        public double width = 0;
        public double height = 0;

        public Rectangle(double width, double height)
        {
            if (width > 0 && height > 0)
            {
                this.width = width;
                this.height = height;
            }
            ShapeID = "Rectangle";
        }

        public override double CalculateArea()
        {
            return Math.Round(width * height, 2);
        }

        public override string ToString()
        {
            return "[" + ShapeID + "] Base: " + width + "cm, Height: " + height + "cm, Area: " + CalculateArea() + "cm²";
        }
    }

}
