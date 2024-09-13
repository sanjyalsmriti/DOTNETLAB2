using System;

namespace PropertyDemo
{
    // Class demonstrating different types of properties
    class Person
    {
        // Auto-Implemented Properties
        public string Name { get; set; }
        public int Age { get; set; }

        // Read-Only Property
        public string ReadOnlyProperty { get; }

        // Write-Only Property
        private string _secret;
        public string Secret
        {
            set
            {
                _secret = value;
                Console.WriteLine("Secret has been set.");
            }
        }

        // Computed Property
        public string FullDescription
        {
            get
            {
                return $"{Name} is {Age} years old.";
            }
        }

        // Constructor
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
            ReadOnlyProperty = "Initialized in constructor";
        }

        // Method to display properties
        public void DisplayProperties()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Age: {Age}");
            Console.WriteLine($"ReadOnlyProperty: {ReadOnlyProperty}");
            Console.WriteLine($"FullDescription: {FullDescription}");
        }
    }

    class Program
    {
        //static void Main(string[] args)
        //{
        //    // Create a Person object
        //    Person person = new Person("smiriti", 20);

        //    // Display properties
        //    Console.WriteLine("Initial Properties:");
        //    person.DisplayProperties();

        //    // Setting the write-only property
        //    person.Secret = "Top Secret";

        //    // Updating auto-implemented properties
        //    person.Name = "isha";
        //    person.Age = 20;

        //    // Display properties after updates
        //    Console.WriteLine("\nUpdated Properties:");
        //    person.DisplayProperties();

        //    Console.ReadLine();
        //}
    }
}
