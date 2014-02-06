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
            Assert.That(_calculator.GetTriangleType("-1", "-2", "-3"), Is.EqualTo("Input must be a positive number"));
        }

        [Test]
        public void TestIsNumber()
        {
            Assert.That(_calculator.GetTriangleType("a", "a", "a"), Is.EqualTo("Inputs must be numeric"));
            Assert.That(_calculator.GetTriangleType("*", "*", "*"), Is.EqualTo("Inputs must be numeric"));
        }
    }
}
