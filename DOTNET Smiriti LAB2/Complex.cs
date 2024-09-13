using System;

namespace OperatorOverloadingDemo
{
    // Class representing a complex number
    class Complex
    {
        public double Real { get; private set; }
        public double Imaginary { get; private set; }

        // Constructor
        public Complex(double real, double imaginary)
        {
            Real = real;
            Imaginary = imaginary;
        }

        // Overloading the + operator
        public static Complex operator +(Complex c1, Complex c2)
        {
            // Add the real and imaginary parts separately
            return new Complex(c1.Real + c2.Real, c1.Imaginary + c2.Imaginary);
        }

        // Method to display the complex number
        public void Display()
        {
            if (Imaginary >= 0)
                Console.WriteLine($"{Real} + {Imaginary}i");
            else
                Console.WriteLine($"{Real} - {-Imaginary}i");
        }
    }

    class complex
    {
        //static void Main(string[] args)
        //{
        //    // Create two Complex objects
        //    Complex c1 = new Complex(2.5, 3.0);
        //    Complex c2 = new Complex(1.5, -1.0);

        //    // Display the complex numbers
        //    Console.WriteLine("Complex Number 1:");
        //    c1.Display();

        //    Console.WriteLine("Complex Number 2:");
        //    c2.Display();

        //    // Use the overloaded + operator
        //    Complex result = c1 + c2;

        //    // Display the result of addition
        //    Console.WriteLine("\nResult of addition:");
        //    result.Display();

        //    Console.ReadLine();
        //}
    }
}
