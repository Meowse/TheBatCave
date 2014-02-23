using NUnit.Framework;
using TriangleTyperApp;

namespace TriangleTypeCalculatorTest
{
    [TestFixture]
    public class BasicCalculatorTests
    {
        private readonly TriangleTypeCalculator _calculator = new TriangleTypeCalculator();
        private const string Equilateral = "Equilateral";
        private const string Scalene = "Scalene";
        private const string Isosceles = "Isosceles";

        [Test]
        public void TestEquilateral()
        {
            Assert.That(_calculator.GetTriangleType("3", "3", "3"), Is.EqualTo(Equilateral));
            Assert.That(_calculator.GetTriangleType("3.0", "3", "3"), Is.EqualTo("Inputs must be a positive integer"));
            Assert.That(_calculator.GetTriangleType(int.MaxValue.ToString(), int.MaxValue.ToString(), int.MaxValue.ToString()), Is.EqualTo(Equilateral));
        }

        [Test]
        public void TestScalene()
        {
            Assert.That(_calculator.GetTriangleType("3", "4", "5"), Is.EqualTo(Scalene));
        }

        [Test]
        public void TestIsosceles()
        {
            Assert.That(_calculator.GetTriangleType("3", "4", "4"), Is.EqualTo(Isosceles));
        }
    }
}
