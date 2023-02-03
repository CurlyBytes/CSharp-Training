using Domain;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("MAIN MENU");
                Console.WriteLine("[1] Doctor");
                Console.WriteLine("[2] Programmer");
                Console.WriteLine("[3] Exit");
                Console.WriteLine("Enter your choice: ");

                int choice = Convert.ToInt32(Console.ReadLine());
                if (choice == 3)
                {
                    break;
                }

                Console.WriteLine("Enter Employee ID: ");
                int empId = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter Employee Name: ");
                string empName = Console.ReadLine();

                Console.WriteLine("Enter Specialization: ");
                string specialization = Console.ReadLine();

                Console.WriteLine("Enter Days Worked: ");
                int daysWorked = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Doctor doctor = new Doctor(empId, empName, specialization);
                        doctor.CalculateSalary(daysWorked);
                        doctor.Display();
                        break;

                    case 2:
                        Programmer programmer = new Programmer(empId, empName, specialization);
                        programmer.CalculateSalary(daysWorked);
                        programmer.Display();
                        break;
                }
            }
        }
    }
}
