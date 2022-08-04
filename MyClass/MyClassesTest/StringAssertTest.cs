using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text.RegularExpressions;

namespace MyClassesTest
{
    [TestClass]
    public class StringAssertTest : TestBase
    {
        [TestMethod]
        public void ContainsTest()
        {
            string str1 = "Automation Testing";
            string str2 = "Testing";
            StringAssert.Contains(str1, str2);
        }
        [TestMethod]
        public void StartsWith()
        {
            string a = "All Lower Case";
            string b = "All Lower";
            StringAssert.StartsWith(a, b);
        }
        [TestMethod]
        public void IsAllLowerCaseTest()
        {
            Regex regex = new Regex(@"^([^A-Z])+$");
            StringAssert.Matches("all lower case", regex);
        }
    }
}
