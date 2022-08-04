namespace MyClass.PersonClasses
{
    public class PersonManager
    {
        public Person CreatePerson(string first, string last, bool isSupervisor)
        {
            Person ret = null;
            if (!string.IsNullOrEmpty(first))
            {
                if (isSupervisor)
                {
                    ret = new Supervisor();
                }
                else
                {
                    ret = new Employee();
                }
                //Assign variables
                ret.FirstName = first;
                ret.LastName = last;
            }
            return ret;
        }
        /// <summary>
        /// This method simulates retrieving a list of Person object
        /// </summary>
        /// <returns>A collection of person objects</returns>
        public List<Person> GetPeople()
        {
            List<Person> people = new List<Person>();
            people.Add(new Person() { FirstName = "Papi", LastName = "Choco" });
            people.Add(new Person() { FirstName = "Yankos", LastName = "Babawon" });
            people.Add(new Person() { FirstName = "Betty", LastName = "Omomii"});
            return people;
        }
        /// <summary>
        /// This method simulates retrieving a list of supervisor object
        /// </summary>
        /// <returns>A collection of supervisor objects</returns>
        public List<Person> GetSupervisors()
        {
            List<Person> people = new List<Person>();
            people.Add(CreatePerson("Papi", "Choco", true));
            people.Add(CreatePerson("Donlumyd", "Macholu", true));
            return people;
        }
        /// <summary>
        /// This method simulates retrieving a list of employee object
        /// </summary>
        /// <returns>A collection of employee objects</returns>
        public List<Person> GetEmployees()
        {
            List<Person> people = new List<Person>();
            people.Add(CreatePerson("TY", "Emapumpin", false));
            people.Add(CreatePerson("Yankos", "Babawon", false));
            people.Add(CreatePerson("Oliva", "Omowere", false));
            return people;
        }
        /// <summary>
        /// This method simulates retrieving a list of supervisor and employee object
        /// </summary>
        /// <returns>A collection of supervisor and empoyee objects</returns>
        public List<Person> GetSupervisorAndEmployees()
        {
            List<Person> people = new List<Person>();
            people.AddRange(GetEmployees());
            people.AddRange(GetSupervisors());
            return people;
        }
    }
   
}
