using WiredBrainCoffee.StorageApp.Data;
using WiredBrainCoffee.StorageApp.Entities;
using WiredBrainCoffee.StorageApp.Repositories;



var employeeRepository = new SqlRepository<Employee>(new StorageAppDbContext(), EmployeeAdded);
AddEmployees(employeeRepository);
GetEmployeeById(employeeRepository);
AddManagers(employeeRepository);
WriteAllToConsole(employeeRepository);

var organizationRepository = new ListRepository<Organization>();
AddOrganizations(organizationRepository);
WriteAllToConsole(organizationRepository);


Console.ReadLine();

void EmployeeAdded(Employee employee)
{
    Console.WriteLine($"Employee added => {employee.FirstName}");
}
void AddManagers(IContravariance<Manager> managerRepository)
{
    var adamsName = new Manager { FirstName = "Adams" };
    var adamsCopy = adamsName.Copy();
    managerRepository.Add(adamsName);
    if (adamsCopy is not null)
    {
        adamsCopy.FirstName += "_Copy";
        managerRepository.Add(adamsCopy); 
    }
   
    managerRepository.Add(new Manager { FirstName = "Johnzoo" });
    managerRepository.Add(new Manager { FirstName = "Toluwalase" });
    managerRepository.Save();
}

void WriteAllToConsole(IUserRepository<IEntity> repository)
{
    var items = repository.GetAll();
    foreach (var item in items)
    {
        Console.WriteLine(item);
    }
}
void GetEmployeeById(IRepository<Employee> employeeRepository)
{
    var employee = employeeRepository.GetById(2);
    Console.WriteLine($"Employee with Id 2: {employee.FirstName}");
}
static void AddOrganizations(IRepository<Organization> organizationRepository)
{
    var organizations = new[]
    {
        new Organization { Name = "PluralSight" },
        new Organization { Name = "Gbobamina" }
    };
    organizationRepository.AddBatch(organizations);

}



static void AddEmployees(IRepository<Employee> employeeRepository)
{
    var employees = new[]
    {
        new Employee { FirstName = "Papi" },
        new Employee { FirstName = "Betty" },
        new Employee { FirstName = "Tope" }
    };

    employeeRepository.AddBatch(employees);
}