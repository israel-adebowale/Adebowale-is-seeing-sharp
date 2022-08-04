using Acme.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Acme.CommonTest
{
    [TestClass]
    public class StringHandlerTest
    {
        [TestMethod]
        public void InsertSpacesTestValid()
        {
            //Arrange
            var source = "SonicScrewdriver";
            var expected = "Sonic Screwdriver";
            

            //Act
            var actual = source.InsertSpaces();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void InsertSpacesTestWithExistingSpaces()
        {
            //Arrange
            var source = "Sonic Screwdriver";
            var expected = "Sonic Screwdriver";
           

            //Act
            var actual = source.InsertSpaces();

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void AllUpperCases()
        {
            //Arrange
            var source = "SONIC SCREWDRIVER";
            var expected = "S O N I C S C R E W D R I V E R";
            

            //Act
            var actual = source.InsertSpaces();

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void EmptyString()
        {
            //Arrange
            var source = "";
            var expected = "";
            

            //Act
            var actual = source.InsertSpaces();

            //Assert
            Assert.AreEqual(expected, actual);
        }
        
    }
}
