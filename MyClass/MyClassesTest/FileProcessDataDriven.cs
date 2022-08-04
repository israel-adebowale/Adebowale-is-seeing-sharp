using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Data;
using MyClass;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;

namespace MyClassesTest
{
    [TestClass]
    public class FileProcessDataDriven : TestBase
    {

        [TestMethod()]
        public void FileExistsFromDB()
        {
            FileProcess fp = new FileProcess();
            bool fromCall = false;
            bool testFailed = false;
            string fileName;
            bool expectedValue;
            bool causesException;
            string sql = "SELECT * FROM tests.FileProcessTest";
            string conn = TestContext.Properties["connectionString"].ToString()!;

            //Load data from sql table
            LoadDataTable(sql, conn);

            if (TestDataTable != null)
            {
                //Loop through all rows in table
                foreach (DataRow row  in TestDataTable.Rows)
                {
                    //Get values from data row
                    fileName = row["FileName"].ToString()!;
                    expectedValue = Convert.ToBoolean(row["ExpectedValue"]);
                    causesException = Convert.ToBoolean(row["CausesException"]);

                    try
                    {
                        //see if the file exists
                        fromCall = fp.FileExists(fileName);
                    }
                    catch (ArgumentNullException)
                    {
                        // Set if a null value was expected
                        if (!causesException)
                            testFailed = true;
                    }
                    catch (Exception)
                    {
                        testFailed = true;
                    }
                    TestContext.WriteLine($"Testing file:{fileName}, Expected Value: {expectedValue}, Actual Value: {fromCall}, Result:{(expectedValue == fromCall ? "Success" : "Failed")}");

                    //Check assertion
                    if (expectedValue != fromCall)
                        testFailed = true;
                }
                if (testFailed)
                    Assert.Fail("Data Driven Tests have Failed, Check additional output");
           }
        }
    }
}
