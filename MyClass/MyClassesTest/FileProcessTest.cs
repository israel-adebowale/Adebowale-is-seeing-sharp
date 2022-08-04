using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyClass;
using System;
using System.IO;

namespace MyClassesTest
{
    [TestClass]
    public class FileProcessTest : TestBase
    {       
        private const string BADFILENAME = @"C:\NotExists.bad";
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
        [DataRow(1,1, DisplayName = "First test (1,1)")]
        [DataRow(42,42, DisplayName = "Second test (42,42)")]
        public void AreNumbersEqual(int num1, int num2)
        {
            Assert.AreEqual(num1, num2);
        }
        [TestMethod]
        [DeploymentItem("FileToDeploy.txt")]
        [DataRow(@"C:\Windows\Regedit.exe", DisplayName = "Regedit.exe")]
        [DataRow("FileToDeploy.txt", DisplayName = "Deployment Item: FileToDeploy.txt")]
        public void FileNameUsingDataRow(string fileName)
        {
            FileProcess process = new FileProcess();
            bool fromCall;
            if (!fileName.Contains(@"\"))
            {
                fileName = TestContext.DeploymentDirectory + @"\" + fileName;
            }
            TestContext.WriteLine("Checking file" + fileName);
            fromCall = process.FileExists(fileName);
            Assert.IsTrue(fromCall);
        }
        [TestMethod]
        [Description("Check to see if a file exist?")]
        [Owner("Papi Choco")]
        [Priority(1)]
        public void FileNameExists()
        {
            //Arrange
            FileProcess process = new FileProcess();
            bool fromCall;

            
            TestContext.WriteLine("Checking File " + ValidFileName);

            //Act
            fromCall = process.FileExists(ValidFileName);

                     

            //Assert
            Assert.IsTrue(fromCall);
        }
        //[TestMethod]
        //[Timeout(3000)]
        //public void SimulateTimeOut()
        //{
        //    System.Threading.Thread.Sleep(4000);
        //}
        [TestMethod]
        [Description("Check to see if the file does not exist")]
        [Owner("Papi Choco")]
        [Priority(2)]
        //[Ignore]
        public void FileNameDoesNotExists()
        {
            //Arrange
            FileProcess process = new FileProcess();
            bool fromCall;
            TestContext.WriteLine("Checking File " + BADFILENAME);
            //Act
            fromCall = process.FileExists(BADFILENAME);

            //Assert
            Assert.IsFalse(fromCall);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        [Description("Check for an argument null exception using expectedexecution")]
        [Owner("Yankos")]
        [Priority(3)]
        public void FileNameNullOrEmptyUsingAttribute()
        {
            FileProcess process = new FileProcess();
            TestContext.WriteLine("Checking for a null file");

            process.FileExists("");

        }
        [TestMethod]
        [Description("Check for an argument null exception using try and catch")]
        [Owner("Yankos")]
        [Priority(3)]
        public void FileNameNullOrEmptyUsingTryCatch()
        {
            FileProcess process = new FileProcess();
            try
            {
                TestContext.WriteLine("Checking for a null file");
                process.FileExists("");
            }
            catch (ArgumentNullException)
            {
                //Test was a success
                return;
            }
            //Fail the test
            Assert.Fail("Call to FileExists() did not throw the ArgumentNullException");
        }
    }
}