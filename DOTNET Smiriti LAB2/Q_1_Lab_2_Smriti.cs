using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOTNET_Smiriti_LAB2
{
    internal class Q_1_Lab_2_Smriti
    {
        // Fields
        public string Name;
        public string Email;
        public decimal Salary;

        // Constructor to initialize Employee object
        public Q_1_Lab_2_Smriti(string name, string email, decimal salary)
        {
            Name = name;
            Email = email;
            Salary = salary;
        }

        // Method to display employee details
        public void DisplayEmployeeDetails()
        {
            Console.WriteLine("Employee Details:");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Email: {Email}");
            Console.WriteLine($"Salary: {Salary}");
        }
    }

    class EmployeeApp // Renamed from Program to EmployeeApp
    {
        //static void Main(string[] args)
        //{
        //    // Creating an Employee object
        //    Q_1_Lab_2_Smriti emp1 = new Q_1_Lab_2_Smriti("Smriti Sanjyal", "smriti@gmail.com", 50000);

        //    // Display employee details
        //    emp1.DisplayEmployeeDetails();

        //    // Prevent console from closing immediately
        //    Console.ReadLine();
        //}
    }
}
