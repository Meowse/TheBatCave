using NUnit.Framework;
using TriangleTyperApp;

namespace TriangleTypeCalculatorTest
{
    [TestFixture]
    public class ErrorTests
    {
        private readonly TriangleTypeCalculator _calculator = new TriangleTypeCalculator();

        [Test]
        public void TestIsPositiveNumber()
        {
            Assert.That(_calculator.ConvertTriangleValuesToDecimal("-1", "-2", "-3"), Is.EqualTo("Input must be a positive number"));
            Assert.That(_calculator.ConvertTriangleValuesToDecimal("0", "0", "0"), Is.EqualTo("Input must be a positive number"));
        }

        [Test]
        public void TestIsNumber()
        {
            Assert.That(_calculator.ConvertTriangleValuesToDecimal("a", "a", "a"), Is.EqualTo("Inputs must be numeric"));
            Assert.That(_calculator.ConvertTriangleValuesToDecimal("&", "*", "VII"), Is.EqualTo("Inputs must be numeric"));
            Assert.That(_calculator.ConvertTriangleValuesToDecimal(" ", " ", " "), Is.EqualTo("Inputs must be numeric"));
            Assert.That(_calculator.ConvertTriangleValuesToDecimal(" ", " ", "3"), Is.EqualTo("Inputs must be numeric"));
            Assert.That(_calculator.ConvertTriangleValuesToDecimal("Three", "Three", "Three"), Is.EqualTo("Inputs must be numeric"));
        }

        [Test]
        public void NotATriangle()
        {
            Assert.That(_calculator.ConvertTriangleValuesToDecimal("1", "17", "1"), Is.EqualTo("Not a triangle"));
            Assert.That(_calculator.ConvertTriangleValuesToDecimal("3", "2", "1"), Is.EqualTo("Not a triangle"));
        }

        [Test]
        public void EasterEgg()
        {
            Assert.That(_calculator.ConvertTriangleValuesToDecimal("open", "podbay", "door"), Is.EqualTo("I'm sorry, Dave, I can't allow you to do that."));
            Assert.That(_calculator.ConvertTriangleValuesToDecimal("open", "podbay", "3"), Is.EqualTo("Inputs must be numeric"));
            Assert.That(_calculator.ConvertTriangleValuesToDecimal("Go", "UW", "Huskies"), Is.EqualTo("HUSKIES FOREVER"));
            Assert.That(_calculator.ConvertTriangleValuesToDecimal("Go", "podbay", "Huskies"), Is.EqualTo("Inputs must be numeric"));
        }
    }
}
