using System;
using _03_Defining_Classes_4;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _03_Defining_Classes_4_Unit_Tests
{
    [TestClass]
    public class ClaimRepositoryTests
    {
        private ClaimRepository _claimRepo;
        private Claim _claim1;
        private Claim _claim2;

        [TestInitialize]
        public void Arrange()
        {
            _claimRepo = new ClaimRepository();
            _claim1 = new Claim(DateTime.Now, new DateTime(2018, 10, 1), 10000m);
            _claim2 = new Claim(DateTime.Now, new DateTime(2018, 6, 1), 10001m);
        }

        [TestMethod]
        public void ClaimRepository_ValidateTimeSpanValid_IsCorrectString()
        {
            //-- Act
            var expected = "valid";
            var actual = _claimRepo.ValidateTimeSpan(_claim1);

            //-- Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ClaimRepository_ValidateTimeSpanInvalid_IsCorrectString()
        {
            //-- Act
            var expected = "invalid";
            var actual = _claimRepo.ValidateTimeSpan(_claim2);

            //-- Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ClaimRepository_CheckAmountValid_IsCorrectString()
        {
            //-- Act
            var expected = "processing";
            var actual = _claimRepo.CheckAmount(_claim1);

            //-- Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ClaimRepository_CheckAmountInvalid_IsCorrectString()
        {
            //-- Act
            var expected = "call";
            var actual = _claimRepo.CheckAmount(_claim2);

            //-- Assert
            Assert.AreEqual(expected, actual);
            Assert.IsInstanceOfType(actual, typeof(string));
        }
    }
}
