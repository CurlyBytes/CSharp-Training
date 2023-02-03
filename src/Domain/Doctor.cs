using Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class Doctor : Employee
    {
        private string specialization;

        public Doctor() { }

        public Doctor(int employeeId, string name, string specialization) : base(employeeId, name)
        {
            this.Specialization = specialization;
        }

        public string Specialization { get => specialization; set => specialization = value; }

        public override double CalculateSalary(double numberOfDaysWorked)
        {
            double rate = 0;
            switch (Specialization)
            {
                case "Pediatrician":
                    rate = 2050;
                    break;
                case "Ob-Gynecologist":
                    rate = 2650;
                    break;
                case "Neurologist":
                    rate = 6575;
                    break;
            }

            base.SetSalary(rate * numberOfDaysWorked);
            return base.GetSalary();
        }

        public override double CalculateDeduction()
        {
            double salary = base.GetSalary();
            double sssDeduction = 0;
            double pagibigDeduction = 0;
            double wtaxDeduction = 0;
            double philHealthDeduction = 0;

            if (salary <= 10000)
            {
                sssDeduction = salary * 0.03;
                pagibigDeduction = salary * 0.02;
                wtaxDeduction = salary * 0.05;
                philHealthDeduction = salary * 0.01;
            }
            else if (salary > 10000 && salary <= 20000)
            {
                sssDeduction = salary * 0.05;
                pagibigDeduction = salary * 0.04;
                wtaxDeduction = salary * 0.10;
                philHealthDeduction = salary * 0.025;
            }
            else if (salary > 20000 && salary <= 30000)
            {
                sssDeduction = salary * 0.07;
                pagibigDeduction = salary * 0.07;
                wtaxDeduction = salary * 0.15;
                philHealthDeduction = salary * 0.05;
            }
            else if (salary > 30000)
            {
                sssDeduction = salary * 0.10;
                pagibigDeduction = salary * 0.10;
                wtaxDeduction = salary * 0.30;
                philHealthDeduction = salary * 0.08;
            }

            double totalDeduction = sssDeduction + pagibigDeduction + wtaxDeduction + philHealthDeduction;

            return totalDeduction;
        }

        public override double CalculateNetPay()
        {
            return base.GetSalary() - CalculateDeduction();
        }

        public new void Display()
        {
            base.Display();
            Console.WriteLine("Specialization: " + Specialization);
            Console.WriteLine("Deduction: " + CalculateDeduction());
            Console.WriteLine("Net Pay: " + CalculateNetPay());
        }
    }
}
