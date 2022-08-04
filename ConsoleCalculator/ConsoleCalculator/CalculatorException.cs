using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCalculator
{
    public class CalculatorException : Exception
    {
        private const string DefaultMessage = "An error occured during calculation. Ensure that the operation is supported and that the values are \n" +
            "within the range for the requested operation";
        /// <summary>
        /// Creates a new <see cref="CalculatorException"/> with a predefined message.
        /// </summary>
        public CalculatorException() : base(DefaultMessage)
        {

        }
        /// <summary>
        /// Creates a new <see cref="CalculatorException"/> with a user supplied message.
        /// </summary>
        /// <param name="message"></param>
        public CalculatorException(string message) : base(message)
        {

        }
        /// <summary>
        /// Creates a new <see cref="CalculatorException"/> with a predefined message and a wrapped inner exception
        /// </summary>
        /// <param name="innerException"></param>
        public CalculatorException(Exception innerException) : base(DefaultMessage, innerException)
        {

        }
        /// <summary>
        /// Creates a new <see cref="CalculatorException"/> with a user-suppllied message and a wrapped inner exception
        /// </summary>
        /// <param name="message"></param>
        /// <param name="innerException"></param>
        public CalculatorException(string message, Exception innerException) : base(message, innerException)
        {

        }
    }
}
