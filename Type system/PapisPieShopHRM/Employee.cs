using System;

namespace PapisPieShopHRM
{
   public class Employee
    {
        private string firstName;
        private string lastName;
        private int numberOfHoursWorked;
        private double hourlyRate;
        private double wage;

        public static int bonus = 250;

        public string FirstName { get { return firstName; } set { firstName = value; } }
        public string LastName { get { return lastName; } set { lastName = value; } }
        public int NumberOfHoursWorked { get { return numberOfHoursWorked; } set { numberOfHoursWorked = value; } }
        public double Wage { get { return wage; } set { wage = value; } }   
        public double HourlyRate { get { return hourlyRate; } set { hourlyRate = value; } }
       
        public Employee (string first, string last, double rate)
        {
            FirstName = first;
            LastName = last;
            HourlyRate = rate;
        }
       
        public int PerformWork(int hours)
        {
            NumberOfHoursWorked += hours;
            return NumberOfHoursWorked;
        }
        public double ReceiveWage(out int hoursWorked)
        {
          
            Wage = NumberOfHoursWorked * HourlyRate + bonus;
            Console.WriteLine($"The Wage for {NumberOfHoursWorked} hours worked is {Wage}");
          
            NumberOfHoursWorked = 0;
            hoursWorked = NumberOfHoursWorked;
            return Wage;

        }

    }
}
