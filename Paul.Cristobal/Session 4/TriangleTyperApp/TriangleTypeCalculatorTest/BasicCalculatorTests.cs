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
            Assert.That(_calculator.GetTriangleType("3", "3", "3.0"), Is.EqualTo("Equilateral"));
            Assert.That(_calculator.GetTriangleType("1", "1", "1"), Is.EqualTo("Equilateral"));
        }

        [Test]
        public void TestIsosceles()
        {
            Assert.That(_calculator.GetTriangleType("3", "3", "1"), Is.EqualTo("Isosceles"));
            Assert.That(_calculator.GetTriangleType("1", "3", "3"), Is.EqualTo("Isosceles"));
            Assert.That(_calculator.GetTriangleType("3", "1", "3"), Is.EqualTo("Isosceles"));
        }

        [Test]
        public void TestScalene()
        {
            Assert.That(_calculator.GetTriangleType("2", "4", "3"), Is.EqualTo("Scalene"));
            Assert.That(_calculator.GetTriangleType("4", "2", "3"), Is.EqualTo("Scalene"));
            Assert.That(_calculator.GetTriangleType("3", "4", "2"), Is.EqualTo("Scalene"));
        }
    }
}
