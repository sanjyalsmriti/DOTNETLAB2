// File: Employee.cs
using System;

namespace CompanyNamespace
{
    public class Employee
    {
        // Fields
        public string Name;
        public string Email;
        public decimal Salary;

        // Constructor to initialize Employee object
        public Employee(string name, string email, decimal salary)
        {
            Name = name;
            Email = email;
            Salary = salary;
        }

        // Method to display employee details
        //public void DisplayEmployeeDetails()
        //{
        //    Console.WriteLine("Employee Details:");
        //    Console.WriteLine($"Name: {Name}");
        //    Console.WriteLine($"Email: {Email}");
        //    Console.WriteLine($"Salary: {Salary:C}");
        //}
    }
}
