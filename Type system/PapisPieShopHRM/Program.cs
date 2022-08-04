using System;
using System.Collections.Generic;

namespace PapisPieShopHRM
{
    public class Program
    {
        private static List<Employee> employees = new List<Employee>();
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("*****************************************");
            Console.WriteLine("* Papi's Pie Shop Employee App *");
            Console.WriteLine("******************************************");
            Console.ForegroundColor= ConsoleColor.White;

            string userSelection;

            do
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("*********************************");
                Console.WriteLine("* Select an option *");
                Console.WriteLine("*********************************");
                Console.ForegroundColor = ConsoleColor.White;

                Console.WriteLine("1: Register Employee");
                Console.WriteLine("2: Register work hours for employee");
                Console.WriteLine("3. Pay Employee");
                Console.WriteLine("4. Change the hourly rate");
                Console.WriteLine("9: Quit Application");
                userSelection = Console.ReadLine();

                switch (userSelection)
                {
                    case "1": RegisterEmployee();
                        break;
                    case "2": RegisterWork();
                        break;
                    case "3": PayEmployee();
                        break;
                    
                        break;
                    case "9": break;
                    default: Console.WriteLine("Invalid selection, please try again!");
                        break;

                }


            }
            while (userSelection != "9");
            Console.WriteLine("Thanks for using this application");

            Console.Read();
        }
        private static void RegisterEmployee()
        {
            Console.WriteLine("Creating an employee");
            Console.Write("Enter the first name:");
            string firstName = Console.ReadLine();

            Console.Write("Enter the last name:");
            string lastName = Console.ReadLine();

            Console.Write("Enter the hourly rate:");
            string hourlyRate = Console.ReadLine();

            double rate = double.Parse(hourlyRate);

            Employee employee = new Employee(firstName, lastName, rate);
            employees.Add(employee);

            Console.WriteLine("Employees created \n\n");
        }
        private static void RegisterWork()
        {
            Console.WriteLine("Select an employee");
            for (int i = 1; i <= employees.Count; i++)
            {
                Console.WriteLine($"{i}. {employees[i-1].FirstName} {employees[i-1].LastName}");
            }
            int selection = int.Parse(Console.ReadLine());
            Console.Write("Enter the number of hours worked: ");

            int hours = int.Parse(Console.ReadLine());

            Employee selectedEmployee = employees[selection-1];
            int numberOfHoursWorked = selectedEmployee.PerformWork(hours);
            Console.WriteLine($"{selectedEmployee.FirstName} {selectedEmployee.LastName} has now worked for {numberOfHoursWorked} hours in total.\n\n");
        }

        private static void PayEmployee()
        {
            Console.WriteLine("Select an employee:");
            for (int i = 1; i <= employees.Count; i++)
            {
                Console.WriteLine($"{i}. {employees[i-1].FirstName} {employees[i-1].LastName}");
            }
            int selection = int.Parse(Console.ReadLine());
            Employee selectedEmployee = employees[selection - 1];
            int hoursWorked;
   
            double receiveWage = selectedEmployee.ReceiveWage(out hoursWorked);
            Console.WriteLine($"{selectedEmployee.FirstName} {selectedEmployee.LastName} has received a wage of {receiveWage}. The hours worked is reset to {hoursWorked}.\n\n");
        }
        
    }
}
