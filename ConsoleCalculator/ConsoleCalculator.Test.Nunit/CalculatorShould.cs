using NUnit.Framework;

namespace ConsoleCalculator.Test.Nunit
{
    public class CalculatorShould
    {

        [Test]
        public void ThrowWhenUnsupportedOperation()
        {
            var sut = new Calculator();
            TestContext.WriteLine("This is a CalculationOperationNotSupoortedException");
            Assert.That(() => sut.Calculate(10, 2, "+"), Throws.TypeOf<CalculationOperationNotSupportedException>());
            Assert.That(() => sut.Calculate(1, 2, "+"), Throws.TypeOf<CalculationOperationNotSupportedException>().With.Property("Operation").EqualTo("+"));
        }
    }
}