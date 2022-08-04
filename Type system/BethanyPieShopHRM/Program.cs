using System;
using System.Globalization;
using System.Text;

namespace BethanyPieShopHRM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string firstName = "Bethany";
            //string lastName = "Smith";
            //string employeeIdentification = string.Concat(firstName, lastName);

            //string displayName = $"Welcome \n{firstName}\t{lastName}";
            //Console.WriteLine(displayName);
            //string name1 = "Bethany";
            //string name2 = "BETHANY";
            //Console.WriteLine("Are both names equal? " + (name1 == name2));

            //StringBuilder stringBuilder = new StringBuilder();
            //stringBuilder.Append("Employee list");
            //stringBuilder.AppendLine("Bethany Smith");
            //stringBuilder.AppendLine("Papi Jones");
            //stringBuilder.AppendLine("Papi Chochi");
            //string list = stringBuilder.ToString();
            //Console.WriteLine(list);

            //Console.WriteLine("Enter the wage:");
            //string wage = Console.ReadLine();
            ////int wageValue = int.Parse(wage);

            //int wageValue;
            //if (int.TryParse(wage, out wageValue))
            //    Console.WriteLine("Parsing Success: " + wageValue);
            //else
            //    Console.WriteLine("Parsing failed!");

            //string hireDateString = "12/12/2020";
            //DateTime hireDate = DateTime.Parse(hireDateString);
            //Console.WriteLine("Parsed date: " + hireDate);

            //var cultureInfo = new CultureInfo("nl-BE");
            //string birthDateString = "28 Maart 1984";
            //var birthDate = DateTime.Parse(birthDateString, cultureInfo);
            //Console.WriteLine("Birth date: " + birthDate);


            //UsingValueParameters();
            //UsingRefParameters();
            //UsingOutParameters();
            //UsingParams();
            //UsingExpressionBodiedSyntax();
            //UsingOptionalParameters();
            UsingNamedArguments();
            

            Console.ReadLine();
        }
        private static void UsingNamedArguments()
        {
            int monthlyWage = 1234;
            int months = 12;
            int bonus = 500;
            
            int yearlyWageForEmployee1 = CalculateYearlyWageWithNamed(bonus: bonus, numberOfMonthWorked: months, monthlyWage: monthlyWage);
        }
        public static int CalculateYearlyWageWithNamed(int monthlyWage, int numberOfMonthWorked, int bonus)
        {
            Console.WriteLine($"The Yearly Wage is: {monthlyWage * numberOfMonthWorked + bonus}");
            return monthlyWage * numberOfMonthWorked + bonus;
        }
        private static void UsingExpressionBodiedSyntax()
        {
            int monthlywage = 1234;
            int months = 12;
            int bonus = 500;
            int yearlyWageForEmployee1 = CalculateYearlyWageExpressionBodied(monthlywage, months, bonus);
            Console.WriteLine($"Yearly Wage for employee 1 (Bethany): {yearlyWageForEmployee1}");
        }
        public static int CalculateYearlyWageExpressionBodied(int monthlyWage, int numberOfMonthWorked, int bonus) =>
            monthlyWage * numberOfMonthWorked + bonus;
        public static void UsingValueParameters()
        {
            int monthlyWage1 = 1234;
            int monthlyWage2 = 2000;
            int months1 = 12;
            int months2 = 8;
            int bonus = 300;

            int yearlyWageForEmployee1 = CalculateYearlyWage(monthlyWage1, months1, bonus);
            Console.WriteLine($"Yearly wage for employee 1 (Bethany): {yearlyWageForEmployee1}");

            int yearlyWageForEmployee2 = CalculateYearlyWage(monthlyWage2, months2, bonus);
            Console.WriteLine($"Yearly wage for enployee 2 (John): {yearlyWageForEmployee2}");


        }
        public static int CalculateYearlyWage(int monthlyWage, int numberOfMonthsWorked, int bonus)
        {
            if (monthlyWage < 2000)
                bonus *= 2;
            Console.WriteLine($"Yearly wage: #{monthlyWage * numberOfMonthsWorked + bonus}");
            Console.WriteLine($"The employee got a bonus of: #{bonus}");
            return monthlyWage * numberOfMonthsWorked + bonus;
        }
        private static void UsingRefParameters()
        {
            int monthlyWage1 = 1234;
            int monthlyWage2 = 2000;
            int months1 = 12;
            int months2 = 8;
            int bonus = 300;

            int yearlyWageForEmployee1ByRef = CalculateYearlyWageByRef(monthlyWage1, months1, ref bonus);
            Console.WriteLine($"Yearly wage for employee 1 (Bethany): {yearlyWageForEmployee1ByRef}");
            Console.WriteLine($"Employee 1 received a bonus of {bonus}");

            int yearlyWageForEmployee2ByRef = CalculateYearlyWageByRef(monthlyWage2, months2, ref bonus);
            Console.WriteLine($"Yearly wage for enployee 2 (John): {yearlyWageForEmployee2ByRef}");
            Console.WriteLine($"Employee 2 received a bonus of {bonus}");
        }
        public static int CalculateYearlyWageByRef(int monthlyWage, int numberOfMonthsWorked, ref int bonus)
        {
            if (monthlyWage < 2000)
            {
                bonus *= 2;
                Console.WriteLine("Yay! Bonus doubled!");
            }
            Console.WriteLine($"Yearly wage is #{monthlyWage * numberOfMonthsWorked + bonus}");
            return monthlyWage * numberOfMonthsWorked + bonus;
        }
        private static void UsingOutParameters()
        {
            int monthlyWage1 = 1234;
            int months1 = 12;
            int bonus;

            int yearlyWageForEmployee1WithOut = CalculateYearlyWageWithOut(monthlyWage1, months1, out bonus);
            Console.WriteLine($"Yearly wage for employee 1 (Bethany): {yearlyWageForEmployee1WithOut}");
            Console.WriteLine($"Employee 1 received a bonus of {bonus}");
        }
        public static int CalculateYearlyWageWithOut(int monthlyWage, int numberOfMonthsWorked, out int bonus)
        {
            bonus = new Random().Next(1000);
            if (bonus < 500)
            {
                bonus *= 2;
                Console.WriteLine("Bonus Doubled!! Yay!!");
            }
            Console.WriteLine($"Yearly wage is #{monthlyWage * numberOfMonthsWorked + bonus}");
            return monthlyWage * numberOfMonthsWorked + bonus;
        }
        private static void UsingParams()
        {
            int monthlyWage1 = 1000, monthlyWage2 = 1234, monthlyWage3 = 1500, monthlyWage4 = 2500;
            int average = CalculateAverageWage(monthlyWage1, monthlyWage2, monthlyWage3, monthlyWage4);
            Console.WriteLine($"The average wage is {average}");
        }
        private static void UsingOptionalParameters()
        {
            int monthlyWage1 = 1234;
            int months1 = 12;
            int yearlyWageForEmployee1 = CalculateYearlyWageWithOptional(monthlyWage1, months1);
            Console.WriteLine($"Yearly wage for Employee 1 is: {yearlyWageForEmployee1}");
        }
        public static int CalculateYearlyWageWithOptional(int monthlywage, int numberOfMonthsWorked, int bonus = 0)
        {
            Console.WriteLine($"The Yearly Wage is: {monthlywage * numberOfMonthsWorked + bonus}");
            return monthlywage * numberOfMonthsWorked + bonus;
        }
        public static int CalculateAverageWage(params int[] wages)
        {
            int total = 0;
            int numberOfWages = wages.Length;
            for (int i = 0; i < numberOfWages; i++)
            {
                total += wages[i];
            }
            return total / numberOfWages;
        }
    }
    
}
