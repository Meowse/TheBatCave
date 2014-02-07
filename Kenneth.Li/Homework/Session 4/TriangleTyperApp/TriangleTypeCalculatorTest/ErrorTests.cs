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
            Assert.That(_calculator.CheckIfTriangleIsValid("-1", "-2", "-3"), Is.EqualTo("Input must be a positive number"));
        }

        [Test]
        public void TestIsNumber()
        {
            Assert.That(_calculator.CheckIfTriangleIsValid("a", "a", "a"), Is.EqualTo("Inputs must be numeric"));
            Assert.That(_calculator.CheckIfTriangleIsValid("&", "*", "VII"), Is.EqualTo("Inputs must be numeric"));
            Assert.That(_calculator.CheckIfTriangleIsValid(" ", " ", " "), Is.EqualTo("Inputs must be numeric"));
            Assert.That(_calculator.CheckIfTriangleIsValid(" ", " ", "3"), Is.EqualTo("Inputs must be numeric"));
            Assert.That(_calculator.CheckIfTriangleIsValid("Three", "Three", "Three"), Is.EqualTo("Inputs must be numeric"));
        }

        [Test]
        public void NotATriangle()
        {
            Assert.That(_calculator.CheckIfTriangleIsValid("1", "17", "1"), Is.EqualTo("Not a triangle"));
        }
    }
}
