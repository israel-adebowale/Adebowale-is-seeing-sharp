using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClassesTest
{   [TestClass]
    public class FileProcessOtherTest : TestBase
    {
       
        [ClassInitialize()]
        public static void ClassInitialize(TestContext tc)
        {
            tc.WriteLine("In a ClassInitialize() method");
        }
        [ClassCleanup()]
        public static void ClassCleanUp()
        {

        }
        [TestInitialize]
        public void Testinitialize()
        {
            TestContext.WriteLine("In TestInitialize() method");
            WriteDescription(this.GetType());
            if (TestContext.TestName.StartsWith("FileNameExists"))
            {
                SetValidFileName();
                if (!string.IsNullOrEmpty(ValidFileName))
                {
                    //Create the valid file
                    File.AppendAllText(ValidFileName, "Some Text");
                }
            }
        }
        [TestCleanup]
        public void TestCleanUp()
        {
            TestContext.WriteLine("In TestInitialize() method");
            if (TestContext.TestName.StartsWith("FileNameExists"))
            {
                //Delete file
                if (File.Exists(ValidFileName))
                {
                    TestContext.WriteLine("Deleting file: " + ValidFileName);
                    File.Delete(ValidFileName);
                }
            }
        }

        [TestMethod]
        public void AreEqualTest()
        {
            string str1 = "Paul";
            string str2 = "paul";
            Assert.AreEqual(str1, str2, true);
        }
        [TestMethod]
        public void AreNotEqualTest()
        {
            string str1 = "Paul";
            string str2 = "Jack";
            Assert.AreNotEqual(str1, str2);
        }
    }
}
