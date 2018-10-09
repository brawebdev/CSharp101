using System;
using _03_Defining_Classes_1;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _03_Defining_Classes_1_Unit_Tests
{
    [TestClass]
    public class EmployeeTests
    {
        //-- Field
        private Employee _employee;

        [TestInitialize]
        public void Arrange()
        {
            //-- Arrange
            _employee = new Employee();
            _employee.EmployeeID = 1;
            _employee.EmployeeLastName = "Pascascio";
            _employee.HoursWorked = 4000;
            _employee.EmployeeAge = 27;
        }

        [TestMethod]
        public void Employee_EmployeeID_IsCorrectInt()
        {
            //-- Act
            var expected = 1;
            var actual = _employee.EmployeeID;

            //-- Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Employee_EmployeeLastName_IsCorrectString()
        {
            //-- Act
            var expected = "Pascascio";
            var actual = _employee.EmployeeLastName;

            //-- Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Employee_EmployeeAge_IsCorrectInt()
        {
            //-- Act
            var expected = 27;
            var actual = _employee.EmployeeAge;

            //-- Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Employee_HoursWorked_IsCorrectInt()
        {
            //-- Act
            var expected = 4000;
            var actual = _employee.HoursWorked;

            //-- Assert
            Assert.AreEqual(expected, actual);
        }
    }
}