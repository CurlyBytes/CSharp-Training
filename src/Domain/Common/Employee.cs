using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Common
{
    public abstract class Employee
    {
        private int employeeId;
        private String name;
        private double salary;

        public Employee()
        {
        }

        public Employee(int employeeId, String name)
        {
            this.employeeId = employeeId;
            this.name = name;
        }

        public int GetEmployeeId()
        {
            return employeeId;
        }

        public void SetEmployeeId(int employeeId)
        {
            this.employeeId = employeeId;
        }

        public String GetName()
        {
            return name;
        }

        public void SetName(String name)
        {
            this.name = name;
        }

        public double GetSalary()
        {
            return salary;
        }

        public void SetSalary(double salary)
        {
            this.salary = salary;
        }

        public abstract double CalculateDeduction();

        public abstract double CalculateNetPay();

        public abstract double CalculateSalary(double numberOfDaysWorked);

        public void Display()
        {
            Console.WriteLine("Employee Id: " + employeeId);
            Console.WriteLine("Employee Name: " + name);
            Console.WriteLine("Salary: " + salary);
        }
    }
}
