using System;

namespace OperatorOverloadingDemo
{
    // Class named Seven
    class Seven
    {
        public int Value { get; private set; }

        // Constructor
        public Seven(int initialValue)
        {
            Value = initialValue;
        }

        // Overloading the prefix ++ operator
        public static Seven operator ++(Seven s)
        {
            // Increment the value and return the updated instance
            s.Value++;
            return s;
        }

        // Overloading the prefix -- operator
        public static Seven operator --(Seven s)
        {
            // Decrement the value and return the updated instance
            s.Value--;
            return s;
        }

        // Method to display the value
        public void Display()
        {
            Console.WriteLine($"Current Value: {Value}");
        }
    }

    class Program
    {
        //static void Main(string[] args)
        //{
        //    // Create a Seven object
        //    Seven seven = new Seven(7);

        //    // Display initial value
        //    Console.WriteLine("Initial value:");
        //    seven.Display();

        //    // Use the overloaded prefix ++ operator
        //    ++seven;
        //    Console.WriteLine("\nAfter prefix increment:");
        //    seven.Display();

        //    // Use the overloaded prefix -- operator
        //    --seven;
        //    Console.WriteLine("\nAfter prefix decrement:");
        //    seven.Display();

        //    Console.ReadLine();
        //}
    }
}
