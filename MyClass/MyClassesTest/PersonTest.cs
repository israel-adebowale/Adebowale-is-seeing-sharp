using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyClass.PersonClasses;

namespace MyClassesTest
{
    [TestClass]
    public class PersonTest : TestBase
    {
        [TestMethod]
        public void IsInstanceTypeOf()
        {
            PersonManager mgr = new PersonManager();
            Person per;
            per = mgr.CreatePerson("Papi", "Choco", true);
            Assert.IsInstanceOfType(per, typeof(Supervisor));
        }

        [TestMethod]
        public void IsNull()
        {
            PersonManager mgr = new PersonManager();
            Person per;
            per = mgr.CreatePerson("", "Choco", true);
            Assert.IsNull(per);
        }
    }
}
