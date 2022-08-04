using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCalculator
{
    public class Calculator
    {
        public int Calculate(int num1, int num2, string operation)
        {
            string nonNullOperator = operation ?? throw new ArgumentNullException(nameof(operation));
            //if (operation is null)
            //    throw new ArgumentNullException(nameof(operation));
            if (nonNullOperator == "/")
            {
                try
                {
                return Divide(num1, num2);
                }
                catch (DivideByZeroException ex)
                {
                    Console.WriteLine("....logging...");
                    //throw new ArithmeticException("An error occured during calculation", ex);
                    throw new CalculatorException(ex);
                }
            }
            else
            {
                throw new CalculationOperationNotSupportedException(nonNullOperator);
                //throw new ArgumentOutOfRangeException(nameof(operation), "The mathematical operator is not supported");
                //Console.WriteLine("Unknown operation");
                //return 0;
            }
        }
        private int Divide(int number, int divisor) => number / divisor;
    }
}
