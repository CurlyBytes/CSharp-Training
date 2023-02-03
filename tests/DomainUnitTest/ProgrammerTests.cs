using Domain;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace DomainUnitTest
{
    public class ProgrammerTests
    {
        [Fact]
        public void Test_ProgrammerConstructor()
        {
            // arrange
            var id = 001;
            var name = "Juan dela Cruz";
            var programmingLanguage = "Java";

            // act
            var programmer = new Programmer(id, name, programmingLanguage);

            // assert
            Assert.Equal(id, programmer.GetEmployeeId());
            Assert.Equal(name, programmer.GetName());
            Assert.Equal(programmingLanguage, programmer.Specialization);
        }

        [Fact]
        public void Test_ProgrammerCalculateSalary()
        {
            // arrange
            var id = 001;
            var name = "Juan dela Cruz";
            var programmingLanguage = "Java";
            var programmer = new Programmer(id, name, programmingLanguage);
            var daysWorked = 30;

            // act
            programmer.CalculateSalary(daysWorked);

            // assert
            Assert.Equal(daysWorked * 950, programmer.GetSalary());
        }

        [Fact]
        public void Test_ProgrammerCalculateDeduction()
        {
            // arrange
            var id = 001;
            var name = "Juan dela Cruz";
            var programmingLanguage = "Java";
            var programmer = new Programmer(id, name, programmingLanguage);
            var daysWorked = 30;
            programmer.CalculateSalary(daysWorked);

            // act
            var deduction = programmer.CalculateDeduction();

            // assert
            Assert.Equal((programmer.GetSalary() * 5 / 100) + (programmer.GetSalary() * 3 / 100) +
                (programmer.GetSalary() * 8 / 100) + (programmer.GetSalary() * 3 / 100), deduction);
        }

        [Fact]
        public void Test_ProgrammerCalculateNetPay()
        {
            // arrange
            var id = 001;
            var name = "Juan dela Cruz";
            var programmingLanguage = "Java";
            var programmer = new Programmer(id, name, programmingLanguage);
            var daysWorked = 30;
            programmer.CalculateSalary(daysWorked);

            // act
            var netPay = programmer.CalculateNetPay();

            // assert
            Assert.Equal(programmer.GetSalary() - programmer.CalculateDeduction(), netPay);
        }
    }
}
