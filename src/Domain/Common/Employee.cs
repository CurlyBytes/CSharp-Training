using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Common
{
    abstract class Employee
    {
        private int employeeId;
        private string name;
        private double salary;
        private double deduction;

        public Employee()
        {
        }

        public Employee(int employeeId, string name)
        {
            this.employeeId = employeeId;
            this.name = name;
        }

        public int EmployeeId
        {
            get { return employeeId; }
            set { employeeId = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public double Salary
        {
            get { return salary; }
            set { salary = value; }
        }

        public double Deduction
        {
            get { return deduction; }
            set { deduction = value; }
        }

        public void Display()
        {
            Console.WriteLine("Employee ID: " + employeeId);
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Salary: " + salary);
        }
        public abstract double CalculateSalary(double daysWorked);

        public abstract double CalculateDeduction();

        public abstract double CalculateNetPay();

    }
}
