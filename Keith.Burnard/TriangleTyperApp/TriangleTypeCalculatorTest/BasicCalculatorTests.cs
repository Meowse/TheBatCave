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

            // Moved to input validation
            // Assert.That(_calculator.GetTriangleType("3", "3", "3.0"), Is.EqualTo("Equilateral"));
        }

        [Test]
        public void TestIsosceles()
        {
            Assert.That(_calculator.GetTriangleType("3", "4", "4"), Is.EqualTo("Isosceles"));
        }

        [Test]
        public void TestScalene()
        {
            Assert.That(_calculator.GetTriangleType("3", "4", "5"), Is.EqualTo("Scalene"));
        }

        [Test]
        public void TestWorkingWithLargeNumbers()
        {
            Assert.That(_calculator.GetTriangleType("2147483647", "2147483647", "2147483647"), Is.EqualTo("Equilateral"));
            Assert.That(_calculator.GetTriangleType("2147483647", "2147483647", "1"), Is.EqualTo("Isosceles"));
            Assert.That(_calculator.GetTriangleType("2147483645", "2147483646", "2147483647"), Is.EqualTo("Scalene"));
        }
    }


}
