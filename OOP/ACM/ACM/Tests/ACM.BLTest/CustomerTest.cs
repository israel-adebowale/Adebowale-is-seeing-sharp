using Acm.BLNew;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ACM.BLTest
{
    [TestClass]
    public class CustomerTest
    {
        [TestMethod]
        public void ValidateValid()
        {
            // Arrange 
            Customer customer = new Customer
            {
                LastName = "Baggins",
                EmailAddress = "fbaggins@hobbiton.me"
            };

            var expected = true;

            //Act
            var actual = customer.Validate();

            //Assert 
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ValidMissingLastName()
        {
            // Arrange 
            Customer customer = new Customer
            {
                EmailAddress = "fbaggins@hobbiton.me"
            };

            var expected = false;

            //Act
            var actual = customer.Validate();

            //Assert 
            Assert.AreEqual(expected, actual);
        }
    }
}
