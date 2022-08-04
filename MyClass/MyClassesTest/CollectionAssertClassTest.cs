using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyClass.PersonClasses;
using System.Collections.Generic;

namespace MyClassesTest
{
    [TestClass]

    public class CollectionAssertClassTest : TestBase
    {

        [TestMethod]
        public void AreCollectionsEqualWithComparerTests()
        {
            PersonManager mgr = new PersonManager();
            List<Person> peopleExpected = new List<Person>();  
            List<Person> peopleActual;

            peopleExpected.Add(new Person() { FirstName = "Papi", LastName = "Choco" });
            peopleExpected.Add(new Person() { FirstName = "Yankos", LastName = "Babawon" });
            peopleExpected.Add(new Person() { FirstName = "Betty", LastName = "Omomii" });

            peopleActual = mgr.GetPeople();
            
            //Provide your own "Comparer" to determine equality
            CollectionAssert.AreEqual(peopleActual, peopleExpected, 
                Comparer<Person>.Create((x,y) => x.FirstName == y.FirstName && x.LastName == y.LastName ? 0 : 1));
        }

        [TestMethod]
        public void AreCollectionsEqualivalentTest()
        {
            PersonManager mgr = new PersonManager();
            List<Person> peopleExpected = new List<Person>();
            List<Person> peopleActual; 
            
            //Get Person Objects
            peopleActual = mgr.GetPeople();

            //Add same person objects to new collection, but in a different order
            peopleExpected.Add(peopleActual[1]);
            peopleExpected.Add(peopleActual[2]);
            peopleExpected.Add(peopleActual[0]);

            //Checks for same objects, but in any order
            CollectionAssert.AreEquivalent(peopleActual, peopleExpected);
        }

       

        [TestMethod]
        public void IsCollectionOfType()
        {
            PersonManager mgr = new PersonManager();
            List<Person> peopleActual = new List<Person>();

            peopleActual = mgr.GetSupervisors();

            //Note by default it compares the person object to see if they are equal
            CollectionAssert.AllItemsAreInstancesOfType(peopleActual, typeof(Supervisor));
        }

        
        [TestMethod]
        public void AreCollectionsEqualTest()
        {
            PersonManager mgr = new PersonManager();
            List<Person> peopleExpected;
            List<Person> peopleActual; 

            peopleActual = mgr.GetPeople();
            peopleExpected = peopleActual;

            //Note by default it compares the person object to see if they are equal
            CollectionAssert.AreEqual(peopleActual, peopleExpected);
        }

        [TestMethod]
        public void AreCollectionsEqual()
        {
            PersonManager mgr = new PersonManager();
            List<Person> peopleExpected = new List<Person>();
            List<Person> peopleActual = new List<Person>();

            peopleExpected.Add(new Person() { FirstName = "Papi", LastName = "Choco" });
            peopleExpected.Add(new Person() { FirstName = "Yankos", LastName = "Babawon" });
            peopleExpected.Add(new Person() { FirstName = "Betty", LastName = "Omomii" });

            peopleActual = mgr.GetPeople();

            //Note by default it compares the person object to see if they are equal
            CollectionAssert.AreEqual(peopleActual, peopleExpected);
        }
    }
}
