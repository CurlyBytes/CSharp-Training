using Domain;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace DomainUnitTest
{
    public class DoctorTest
    {
        [Fact]
        public void TestConstructor()
        {
            Doctor doctor = new Doctor(001, "Juan dela Cruz", "Pediatrician");
            Assert.Equal(1, doctor.GetEmployeeId());
            Assert.Equal("Juan dela Cruz", doctor.GetName());
            Assert.Equal("Pediatrician", doctor.Specialization);
        }

        [Fact]
        public void TestSetSpecialization()
        {
            Doctor doctor = new Doctor();
            doctor.Specialization = "Ob-Gynecologist";
            Assert.Equal("Ob-Gynecologist", doctor.Specialization);
        }

        [Fact]
        public void TestCalculateSalary()
        {
            Doctor doctor = new Doctor(001, "Juan dela Cruz", "Pediatrician");
            double salary = doctor.CalculateSalary(15);
            Assert.Equal(30750, salary, 2);
        }

        [Fact]
        public void TestCalculateDeduction()
        {
            Doctor doctor = new Doctor(001, "Juan dela Cruz", "Pediatrician");
            double salary = doctor.CalculateSalary(15);
            double deduction = doctor.CalculateDeduction();
            Assert.Equal(17835, deduction, 2);
        }

        [Fact]
        public void TestCalculateNetPay()
        {
            Doctor doctor = new Doctor(001, "Juan dela Cruz", "Pediatrician");
            double salary = doctor.CalculateSalary(15);
            double deduction = doctor.CalculateDeduction();
            double netPay = doctor.CalculateNetPay();
            Assert.Equal(12915, netPay, 2);
        }
    }
}
