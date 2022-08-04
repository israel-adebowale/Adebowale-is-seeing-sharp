using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Reflection;
using System.Data;
using System.Data.SqlClient;
namespace MyClassesTest
{
    public class TestBase
    {
        protected void WriteDescription (Type typ)
        {
            string testName = TestContext.TestName;
            //Find the test method currently executing
            MemberInfo method = typ.GetMethod(testName)!;
            if (method != null)
            {
                //see if the [Description] attritube exists on this test
                Attribute attribute = method.GetCustomAttribute (typeof (DescriptionAttribute))!;
                if (attribute != null)
                {
                    //Cast the attribute to a DescriptionAttribute
                    DescriptionAttribute descriptionAttribute = (DescriptionAttribute)attribute;
                    //Display the test description
                    TestContext.WriteLine("Test description: " + descriptionAttribute.Description);
                }
            }
        }
        protected string? ValidFileName;
        public DataTable? TestDataTable { get; set; }
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public TestContext TestContext { get; set; }
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public DataTable LoadDataTable(string sql, string connection)
        {
            TestDataTable = null;
            try
            {
                //Create a connection
                using (SqlConnection ConnectionObject = new SqlConnection(connection))
                {
                    //Create command object
                    using (SqlCommand CommandObject = new SqlCommand(sql, ConnectionObject))
                    {
                        // create a sql data adapter
                        using (SqlDataAdapter adapter = new SqlDataAdapter(CommandObject))
                        {
                            // Fill Datatable using data adapter
                            TestDataTable = new DataTable();
                            adapter.Fill(TestDataTable);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                TestContext.WriteLine($"Error in LoadDataTable() method. {Environment.NewLine}{ex.Message}");
            }
            return TestDataTable;
        }
        protected void SetValidFileName()
        {
#pragma warning disable CS8602 // Dereference of a possibly null reference.
            ValidFileName = TestContext.Properties["ValidFileName"].ToString();
#pragma warning restore CS8602 // Dereference of a possibly null reference.
            if (ValidFileName.Contains("[AppPath]"))
            {
                ValidFileName = ValidFileName.Replace("[AppPath]",
                    Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData));
            }
        }
    }
}
