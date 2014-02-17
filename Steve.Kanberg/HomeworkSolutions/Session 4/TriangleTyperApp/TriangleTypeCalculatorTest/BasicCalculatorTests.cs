using System.Runtime.Serialization.Formatters;
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
        public void TestEquilateralFloat()
        {
            Assert.That(_calculator.GetTriangleType(((float) 3.0).ToString(), ((float) 3.0).ToString(), ((float) 3.0).ToString()), Is.EqualTo("Equilateral"));
        }

        [Test]
        public void TestIsosceles()
        {
            Assert.That(_calculator.GetTriangleType("10", "10", "5"), Is.EqualTo("Isosceles"));
        }

        [Test]
        public void TestTriangleNotNumeric()
        {
            Assert.That(_calculator.GetTriangleType("a", "a", "a"), Is.EqualTo("Non-Numeric Values"));
        }

        [Test]
        public void TestTrianglePositiveNumber()
        {
            Assert.That(_calculator.GetTriangleType((-3).ToString(), 3.ToString(), 3.ToString()), Is.EqualTo("Positive Numbers Only"));
        }

    }
}
