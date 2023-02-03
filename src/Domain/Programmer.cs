using Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class Programmer : Employee
    {
        const double programmersDailyRate = 950;

        private string specialization;

        public Programmer()
        {
        }

        public Programmer(int employeeId, string name, string specialization) : base(employeeId, name)
        {
            this.specialization = specialization;
        }

        public string Specialization
        {
            get { return specialization; }
            set { specialization = value; }
        }

        public override double CalculateSalary(double numberOfDays)
        {
            base.SetSalary(programmersDailyRate * numberOfDays);
            return base.GetSalary();
        }

        public override double CalculateDeduction()
        {
            double sssDeduction = 0.05 * base.GetSalary();
            double pagIbigDeduction = 0.03 * base.GetSalary();
            double wtaxDeduction = 0.08 * base.GetSalary();
            double philHealthDeduction = 0.03 * base.GetSalary();
            double TotalDeduction = sssDeduction + pagIbigDeduction + wtaxDeduction + philHealthDeduction;

            return TotalDeduction;
        }

        public override double CalculateNetPay()
        {
            return base.GetSalary() - CalculateDeduction();
        }

        public new void Display()
        {
            base.Display();
            Console.WriteLine("Specialization " + Specialization);
            Console.WriteLine("Deduction " + CalculateDeduction());
            Console.WriteLine("Net Pay " + CalculateNetPay());
        }

    }
}
