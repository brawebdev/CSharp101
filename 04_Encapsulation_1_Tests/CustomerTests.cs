using System;
using _04_Encapsulation_1;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _04_Encapsulation_1_Tests
{
    [TestClass]
    public class CustomerTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            Customer customer = new Customer();
            customer.FirstName = "Kenn";
            Console.WriteLine(customer.FirstName);

        }
    }
}
