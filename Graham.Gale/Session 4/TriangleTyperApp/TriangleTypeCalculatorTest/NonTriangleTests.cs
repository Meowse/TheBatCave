using NUnit.Framework;
using TriangleTyperApp;

namespace TriangleTypeCalculatorTest
{
    [TestFixture]
    class NonTriangleTests
    {
        private readonly TriangleTypeCalculator _calculator = new TriangleTypeCalculator();

        [Test]
        public void NonNumbersFail()
        {
            Assert.That(IsError(_calculator.GetTriangleType("three", "four", "five")), Is.True);            
        }

        [Test]
        public void NegativeNumbersFail()
        {
            Assert.That(IsError(_calculator.GetTriangleType("-3", "-4", "-5")), Is.True);
            Assert.That(IsError(_calculator.GetTriangleType("-3", "4", "5")), Is.True);
            Assert.That(IsError(_calculator.GetTriangleType("3", "-4", "5")), Is.True);
            Assert.That(IsError(_calculator.GetTriangleType("3", "4", "-5")), Is.True);
        }

        [Test]
        public void SidesCannotHaveZeroLength()
        {
            Assert.That(IsError(_calculator.GetTriangleType("0", "0", "0")), Is.True);
        }

        [Test]
        public void SidesMustMakeTriangle()
        {
            Assert.That(IsError(_calculator.GetTriangleType("1", "7", "1")), Is.True);
            Assert.That(IsError(_calculator.GetTriangleType("7", "1", "1")), Is.True);
            Assert.That(IsError(_calculator.GetTriangleType("1", "1", "7")), Is.True);
        }

        [Test]
        public void StraightLineIsNotTriangle()
        {
            Assert.That(IsError(_calculator.GetTriangleType("1", "2", "1")), Is.True);
            Assert.That(IsError(_calculator.GetTriangleType("2", "1", "1")), Is.True);
            Assert.That(IsError(_calculator.GetTriangleType("1", "1", "2")), Is.True);
        }

        private bool IsError(string result)
        {
            return ((result != "Equilateral") && (result != "Isosceles") && (result != "Scalene"));
        }
    }
}
