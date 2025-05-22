//Create an abstract class called Shape with a method called Area() and inherit it in two classes: Circle and Rectangle. 
using System;

namespace ShapeExample
{
    // Abstract class
    public abstract class Shape
    {
        // Abstract method
        public abstract double Area();
    }

    // Circle class inheriting Shape
    public class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public override double Area()
        {
            return Math.PI * Radius * Radius;
        }
    }

    // Rectangle class inheriting Shape
    public class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        public override double Area()
        {
            return Width * Height;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create a Circle object
            Shape circle = new Circle(5);
            Console.WriteLine("Area of Circle: " + circle.Area());

            // Create a Rectangle object
            Shape rectangle = new Rectangle(4, 6);
            Console.WriteLine("Area of Rectangle: " + rectangle.Area());

            Console.ReadLine();
        }
    }
}
