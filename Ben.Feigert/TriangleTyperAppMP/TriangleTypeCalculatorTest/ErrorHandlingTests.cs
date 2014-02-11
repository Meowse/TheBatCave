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
            Assert.That(_calculator.GetTriangleType("-3", "-4", "-5"), Is.EqualTo("All sides of a triangle must have positive length"));
        }

        [Test]
        public void SidesCannotHaveZeroLength()
        {
            Assert.That(_calculator.GetTriangleType("0", "0", "0"), Is.EqualTo("All sides of a triangle must have positive length"));
        }

    }
}
