using System;
using _02_Reference_Types;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _02_Reference_Types_Unit_Tests
{
    [TestClass]
    public class CustomerTests
    {
        [TestMethod]
        public void Customer_SetFirstName_ShouldBeString()
        {
            //-- Arrange
            Customer customer = new Customer();
            customer.FirstName = "Joshua";

            //-- Act
            var actual = customer.FirstName;
            var expected = "Joshua";

            Console.WriteLine($"Actual: {actual}");

            //-- Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Customer_SetLastName_ShouldBeString()
        {
            //-- Arrange
            Customer customer = new Customer();
            customer.LastName = "Tucker";

            //-- Act
            var actual = customer.LastName;
            var expected = "Tucker";

            //-- Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Customer_SetFullName_ShouldBeString()
        {
            //-- Arrange
            Customer customer = new Customer();
            customer.FirstName = "Joshua";
            customer.LastName = "Tucker";

            //-- Act
            var actual = customer.GetFullName();
            var expected = "Joshua Tucker";

            //-- Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
