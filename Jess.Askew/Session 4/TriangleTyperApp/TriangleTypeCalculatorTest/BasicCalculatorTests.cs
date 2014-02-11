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
            Assert.That(_calculator.GetTriangleType("5", "5", "5"), Is.EqualTo("Equilateral"));
        }

        [Test]
        public void TestIsosceles()
        {
            Assert.That(_calculator.GetTriangleType("5", "5", "10"), Is.EqualTo("Isosceles"));
        }    

    }
}
