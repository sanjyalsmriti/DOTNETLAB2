using System;

namespace GenericDemo
{
    // Generic class definition
    class Box<T>
    {
        private T _content;

        // Constructor
        public Box(T content)
        {
            _content = content;
        }

        // Method to get the content
        public T GetContent()
        {
            return _content;
        }

        // Method to set the content
        public void SetContent(T content)
        {
            _content = content;
        }

        // Generic method to display the type and content
        public void DisplayContent()
        {
            Console.WriteLine($"Type: {typeof(T)}, Content: {_content}");
        }

        // Generic method to compare two items
        public bool Compare<TItem>(TItem item1, TItem item2)
        {
            return item1.Equals(item2);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create a Box for integers
            Box<int> intBox = new Box<int>(123);
            intBox.DisplayContent(); // Output: Type: System.Int32, Content: 123

            // Create a Box for strings
            Box<string> stringBox = new Box<string>("Hello, Generics!");
            stringBox.DisplayContent(); // Output: Type: System.String, Content: Hello, Generics!

            // Create a Box for doubles
            Box<double> doubleBox = new Box<double>(45.67);
            doubleBox.DisplayContent(); // Output: Type: System.Double, Content: 45.67

            // Use the Compare method
            bool areEqual = intBox.Compare(123, 123);
            Console.WriteLine($"Are the integers equal? {areEqual}"); // Output: Are the integers equal? True

            areEqual = stringBox.Compare("Hello, Generics!", "Hello, Generics!");
            Console.WriteLine($"Are the strings equal? {areEqual}"); // Output: Are the strings equal? True

            Console.ReadLine();
        }
    }
}
