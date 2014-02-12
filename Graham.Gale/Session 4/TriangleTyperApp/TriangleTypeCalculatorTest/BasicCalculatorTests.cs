using NUnit.Framework;
using TriangleTyperApp;

namespace TriangleTypeCalculatorTest
{
    [TestFixture]
    public class BasicCalculatorTests
    {
        private readonly TriangleTypeCalculator _calculator = new TriangleTypeCalculator();

        [Test]
        public void TestEquilateral()
        {
            Assert.That(_calculator.GetTriangleType("3", "3", "3"), Is.EqualTo("Equilateral"));
        }

        [Test]
        public void GetTriangleTypeValidTriangleTypes()
        {
            Assert.That(_calculator.GetTriangleType("4", "4", "4"), Is.EqualTo("Equilateral"));
            Assert.That(_calculator.GetTriangleType("4", "5", "4"), Is.EqualTo("Isosceles"));
            Assert.That(_calculator.GetTriangleType("2", "3", "4"), Is.EqualTo("Scalene"));
        }

        [Test]
        public void GetTriangleTypeErrorTriangleTypes()
        {
            Assert.That(_calculator.GetTriangleType("1", "2", "3"), Is.EqualTo("Not a triangle"));
            Assert.That(_calculator.GetTriangleType("A", "B", "C"), Is.EqualTo("Inputs must be integers"));
            Assert.That(_calculator.GetTriangleType("-2", "-3", "-4"), Is.EqualTo("Input must be a positive number"));
        }

    }
}
