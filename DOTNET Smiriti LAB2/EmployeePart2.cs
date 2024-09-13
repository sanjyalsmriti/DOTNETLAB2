// File: EmployeePart2.cs
using System;

namespace PartialClassDemo
{
    // Second part of the partial class Employee
    public partial class Employee
    {
        // Method to display employee bonus details
        public void DisplayBonus()
        {
            decimal bonus = Salary * 0.10M; // 10% bonus
            Console.WriteLine($"Bonus: {bonus:C}");
        }
    }
}
