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
            Assert.That(_calculator.GetTriangleType("1", "1", "1"), Is.EqualTo("Equilateral"));
        }

        [Test]
        public void TestIsosceles()
        {
            Assert.That(_calculator.GetTriangleType("1", "3", "3"), Is.EqualTo("Isosceles"));
            Assert.That(_calculator.GetTriangleType("3", "1", "3"), Is.EqualTo("Isosceles"));
            Assert.That(_calculator.GetTriangleType("3", "3", "1"), Is.EqualTo("Isosceles"));
        }

        [Test]
        public void TestScalene()
        {
            Assert.That(_calculator.GetTriangleType("2", "3", "4"), Is.EqualTo("Scalene"));
            Assert.That(_calculator.GetTriangleType("7", "10", "15"), Is.EqualTo("Scalene"));
            Assert.That(_calculator.GetTriangleType("8", "10", "12"), Is.EqualTo("Scalene"));
        }

        [Test]
        public void TestSNonNumeric()
        {
            Assert.That(_calculator.GetTriangleType("-1", "3", "4"), Is.EqualTo("Input must be a positive whole number"));
            Assert.That(_calculator.GetTriangleType("one", "10", "15"),
                Is.EqualTo("Input must be a positive whole number"));
            Assert.That(_calculator.GetTriangleType(" ", "10", "12"),
                Is.EqualTo("Input must be a positive whole number"));
            Assert.That(_calculator.GetTriangleType(" ", "10", "12"),
                Is.EqualTo("Input must be a positive whole number"));
            Assert.That(_calculator.GetTriangleType("#", "10", "12"),
                Is.EqualTo("Input must be a positive whole number"));
            Assert.That(_calculator.GetTriangleType(".5", "10", "12"),
                Is.EqualTo("Input must be a positive whole number"));
        }
    }
}
        