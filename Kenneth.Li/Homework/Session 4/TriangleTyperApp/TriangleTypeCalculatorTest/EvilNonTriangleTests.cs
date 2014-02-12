using NUnit.Framework;
using TriangleTyperApp;

namespace TriangleTypeCalculatorTest
{
    [TestFixture]
    public class EvilNonTriangleTests
    {
        private readonly TriangleTypeCalculator _calculator = new TriangleTypeCalculator();

        [Test]
        public void VeryLongSidesMustMakeTriangle()
        {
            Assert.That(IsError(_calculator.ConvertTriangleValuesToDecimal("1", int.MaxValue.ToString(), "1")), Is.True);
            Assert.That(IsError(_calculator.ConvertTriangleValuesToDecimal(int.MaxValue.ToString(), "1", "1")), Is.True);
            Assert.That(IsError(_calculator.ConvertTriangleValuesToDecimal("1", "1", int.MaxValue.ToString())), Is.True);
        }

        private bool IsError(string result)
        {
            return ((result != "Equilateral") && (result != "Isosceles") && (result != "Scalene"));
        }
    }
}
