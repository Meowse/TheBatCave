using NUnit.Framework;
using TriangleTyperApp;

namespace TriangleTypeCalculatorTest
{
    [TestFixture]
    class ErrorHandlingTests
    {
        private readonly TriangleTypeCalculator _calculator = new TriangleTypeCalculator();

        [Test]
        public void NonNumbersFail()
        {
            Assert.That(_calculator.GetTriangleType("three", "four", "five"), Is.EqualTo("Inputs must be integers"));            
        }

        [Test]
        public void NegativeNumbersFail()
        {
            Assert.That(_calculator.GetTriangleType("-3", "-4", "-5"), Is.EqualTo("A triangle cannot have sides of negative length"));
        }
    }
}
