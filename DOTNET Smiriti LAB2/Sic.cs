using System;

namespace ConstructorDemo
{
    // Class with different types of constructors
    class Person
    {
        // Fields
        public string Name;
        public int Age;

        // Default constructor
        public Person()
        {
            Name = "Smiriti";
            Age = 20;
        }

        // Parameterized constructor
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        // Copy constructor
        public Person(Person other)
        {
            Name = other.Name;
            Age = other.Age;
        }

        // Method to display person details
        public void DisplayPersonDetails()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}");
        }
    }

    class Program
    {
        //static void Main(string[] args)
        //{
        //    // Using the default constructor
        //    Person person1 = new Person();
        //    Console.WriteLine("Person 1:");
        //    person1.DisplayPersonDetails(); 

        //    // Using the parameterized constructor
        //    Person person2 = new Person("ishu", 20);
        //    Console.WriteLine("\nPerson 2:");
        //    person2.DisplayPersonDetails(); 

        //    // Using the copy constructor
        //    Person person3 = new Person(person2);
        //    Console.WriteLine("\nPerson 3 (copy of Person 2):");
        //    person3.DisplayPersonDetails(); 

        //    Console.ReadLine();
        //}
    }
}
