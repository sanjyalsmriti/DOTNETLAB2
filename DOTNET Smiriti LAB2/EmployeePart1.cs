// File: EmployeePart1.cs
using System;

namespace PartialClassDemo
{
    // First part of the partial class Employee
    public partial class Employee
    {
        // Fields
        public string Name;
        public decimal Salary;

        // Constructor
        public Employee(string name, decimal salary)
        {
            Name = name;
            Salary = salary;
        }

        // Method to display basic details
        public void DisplayBasicDetails()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Salary: {Salary:C}");
        }
    }
}
