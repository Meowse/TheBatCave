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
        public void AreEqual()
        {
            int num1 = 1;
            int num2 = 1;

            Assert.AreEqual(num1, num2);
        }

        [Test]
        public void IsPositiveNumber()
        {
            int num = 1;

            Assert.Greater(num,0);
        }
    }
}
