using ConsoleCalculator;

namespace ConsoleCalculator
{
    public class Program
    {
        static void Main(string [] args)
        {
            AppDomain currentAppDomain = AppDomain.CurrentDomain;
            currentAppDomain.UnhandledException += new UnhandledExceptionEventHandler(HandleException);

            Console.WriteLine("Enter the first number");
            int number1 = int.Parse(Console.ReadLine()!);

            Console.WriteLine("Enter second number");
            int number2 = int.Parse(Console.ReadLine()!);

            Console.WriteLine("Enter operation");
            string operation = Console.ReadLine()!.ToUpperInvariant();

            var calculator = new Calculator();
            try
            {
                int result = calculator.Calculate(number1, number2, operation);
                DisplayResult(result);
            }
            catch (ArgumentNullException ex) when (ex.ParamName == "operation")
            {
                Console.WriteLine($"Operation was not supported.{ex}");
            }
            catch (ArgumentNullException ex)
            {
                //Log.ex
                Console.WriteLine($"an argument was nnull. {ex}");
            }
            catch (CalculationOperationNotSupportedException ex)
            {
                //log.ex
                Console.WriteLine($"CalculationOperationNotSupportedException caught {ex.Operation}");
                Console.WriteLine(ex);
            }
            catch (CalculatorException ex)
            {
                Console.WriteLine("CalculationException caught");
                Console.WriteLine(ex);
            }
            catch (Exception ex)
            {

                Console.WriteLine($"Sorry, something went wrong. {ex}");
            }
            finally
            {
                Console.WriteLine("....finally...");
            }
           

            Console.WriteLine("\nPress enter to exit");
            Console.ReadLine();
        }

        private static void HandleException(object sender, UnhandledExceptionEventArgs e)
        {
            Console.WriteLine($"Sorry, there was a problem and we need to close. Details: {e.ExceptionObject}");
        }

        private static void DisplayResult(int result) => Console.WriteLine($"Result is: {result}");
    }
}




