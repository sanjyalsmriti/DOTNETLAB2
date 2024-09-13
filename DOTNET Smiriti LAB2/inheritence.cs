using System;

namespace InheritanceDemo
{
    // Base class for all inheritance examples
    class Person
    {
        public string Name;
        public int Age;

        // Base class method
        public void DisplayPersonDetails()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}");
        }
    }

    // Single Inheritance Example
    class Employee : Person  // Employee inherits from Person (Single Inheritance)
    {
        public decimal Salary;

        // Derived class method
        public void DisplayEmployeeDetails()
        {
            Console.WriteLine($"Salary: {Salary:C}");
        }
    }

    // Multilevel Inheritance Example
    class Manager : Employee  // Manager inherits from Employee (Multilevel Inheritance)
    {
        public int TeamSize;

        // Further derived class method
        public void DisplayManagerDetails()
        {
            Console.WriteLine($"Team Size: {TeamSize}");
        }
    }

    // Hierarchical Inheritance Example
    class Developer : Person  // Developer also inherits from Person (Hierarchical Inheritance)
    {
        public string ProgrammingLanguage;

        // Derived class method
        public void DisplayDeveloperDetails()
        {
            Console.WriteLine($"Programming Language: {ProgrammingLanguage}");
        }
    }

    class InheritanceDemoProgram
    {
        //static void Main(string[] args)
        //{
        //    // Single Inheritance Example
        //    Console.WriteLine("Single Inheritance Example:");
        //    Employee employee = new Employee { Name = "smiriti", Age = 20, Salary = 500000 };
        //    employee.DisplayPersonDetails();    // Accessing base class method
        //    employee.DisplayEmployeeDetails();  // Accessing derived class method

        //    // Multilevel Inheritance Example
        //    Console.WriteLine("\nMultilevel Inheritance Example:");
        //    Manager manager = new Manager { Name = "smith", Age = 25, Salary = 90000, TeamSize = 5 };
        //    manager.DisplayPersonDetails();    // Accessing base class method
        //    manager.DisplayEmployeeDetails();  // Accessing derived class method (from Employee)
        //    manager.DisplayManagerDetails();   // Accessing Manager's own method

        //    // Hierarchical Inheritance Example
        //    Console.WriteLine("\nHierarchical Inheritance Example:");
        //    Developer developer = new Developer { Name = "Sijan", Age = 25, ProgrammingLanguage = "C#" };
        //    developer.DisplayPersonDetails();    // Accessing base class method
        //    developer.DisplayDeveloperDetails(); // Accessing derived class method (from Developer)

        //    Console.ReadLine();
        //}
    }
}
