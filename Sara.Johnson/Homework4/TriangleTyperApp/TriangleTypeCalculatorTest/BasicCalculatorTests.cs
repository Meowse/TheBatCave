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
        public void TestEquilateralDecimal()
        {
            Assert.That(_calculator.GetTriangleType("3", "3", "3.0"), Is.EqualTo("Equilateral"));
            Assert.That(_calculator.GetTriangleType("3", "3.0", "3"), Is.EqualTo("Equilateral"));
            Assert.That(_calculator.GetTriangleType("3.0", "3", "3"), Is.EqualTo("Equilateral"));
        }

        [Test]
        public void TestIsoscelesA()
        {
            Assert.That(_calculator.GetTriangleType("7", "3", "3"), Is.EqualTo("Isosceles"));
            Assert.That(_calculator.GetTriangleType("3", "7", "3"), Is.EqualTo("Isosceles"));
            Assert.That(_calculator.GetTriangleType("3", "3", "7"), Is.EqualTo("Isosceles"));
        }

        [Test]
        public void TestIsoscelesB()
        {
            Assert.That(_calculator.GetTriangleType("3", "7", "3"), Is.EqualTo("Isosceles"));
            Assert.That(_calculator.GetTriangleType("3", "3", "7"), Is.EqualTo("Isosceles"));
            Assert.That(_calculator.GetTriangleType("7", "3", "3"), Is.EqualTo("Isosceles"));
        }


        [Test]
        public void TestScalene()
        {
            Assert.That(_calculator.GetTriangleType("3", "9", "5"), Is.EqualTo("Scalene"));
            Assert.That(_calculator.GetTriangleType("9","4", "6"),Is.EqualTo("Scalene"));
        }

        [Test]
        public void TestLargeNumber()
        {
            Assert.That(_calculator.GetTriangleType("2,147,483,647", "2,147,483,647", "2,147,483,647"), Is.EqualTo("Equilateral"));
        }

        [Test]
        public void TestNonNumeric()
        {
            Assert.That(_calculator.GetTriangleType("three", "three", "three"), Is.EqualTo("Enter a numeric value for each side"));
        }

        [Test]
        public void TestNull()
        {
            Assert.That(_calculator.GetTriangleType("","",""), Is.EqualTo("Enter a numeric value for each side"));
            Assert.That(_calculator.GetTriangleType("", "", "4"), Is.EqualTo("Enter a numeric value for each side"));
            Assert.That(_calculator.GetTriangleType("", "4", ""), Is.EqualTo("Enter a numeric value for each side"));
            Assert.That(_calculator.GetTriangleType("4", "", ""), Is.EqualTo("Enter a numeric value for each side"));
        }

        [Test]
        public void TestNegativeNumber()
        {
            Assert.That(_calculator.GetTriangleType("-3", "-3", "-3"), Is.EqualTo("Inputs must have a postive value"));
        }

    }
}
