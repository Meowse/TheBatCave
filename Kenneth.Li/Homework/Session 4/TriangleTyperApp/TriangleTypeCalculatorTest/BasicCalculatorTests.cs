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
            Assert.That(_calculator.CheckIfTriangleIsValid("3", "3", "3"), Is.EqualTo("Equilateral"));
            Assert.That(_calculator.CheckIfTriangleIsValid("3", "3", "3.0"), Is.EqualTo("Equilateral"));
        }
        [Test]
        public void TestIsosceles()
        {
            Assert.That(_calculator.CheckIfTriangleIsValid("5", "5", "2"), Is.EqualTo("Isosceles"));
            Assert.That(_calculator.CheckIfTriangleIsValid("2,147,483,647", "2,147,483,647", "1"), Is.EqualTo("Isosceles"));
        }

        [Test]
        public void TestScalene()
        {
            Assert.That(_calculator.CheckIfTriangleIsValid("3", "6", "7"), Is.EqualTo("Scalene"));
        }
    }
}
