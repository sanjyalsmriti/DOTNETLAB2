using System;

namespace ShapeDemo
{
    // Base class Shape
    class Shape
    {
        // Properties
        public double Length { get; set; }
        public double Breadth { get; set; }

        // Default constructor
        public Shape()
        {
            Length = 0;
            Breadth = 0;
        }

        // Parameterized constructor
        public Shape(double length, double breadth)
        {
            Length = length;
            Breadth = breadth;
        }
    }

    // Derived class Rectangle from Shape
    class Rectangle : Shape
    {
        // Constructor that uses the base class constructor
        public Rectangle(double length, double breadth) : base(length, breadth)
        {
        }

        // Method to calculate the area of the rectangle
        public double CalculateArea()
        {
            return Length * Breadth;
        }
    }

    class Program
    {
        //static void Main(string[] args)
        //{
        //    // Create a Rectangle object using the parameterized constructor
        //    Rectangle rectangle = new Rectangle(10, 5);

        //    // Display the area of the rectangle
        //    double area = rectangle.CalculateArea();
        //    Console.WriteLine($"Length: {rectangle.Length}");
        //    Console.WriteLine($"Breadth: {rectangle.Breadth}");
        //    Console.WriteLine($"Area of the Rectangle: {area}");

        //    Console.ReadLine();
        //}
    }
}
