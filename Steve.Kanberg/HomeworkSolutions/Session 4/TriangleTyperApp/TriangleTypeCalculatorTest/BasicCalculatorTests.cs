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
            Assert.That(_calculator.GetTriangleTypeEquilateral(3.ToString(), 3.ToString(), 3.ToString()), Is.EqualTo("Equilateral"));
        }

        [Test]
        public void TestEquilateralFloat()
        {
            Assert.That(_calculator.GetTriangleTypeEquilateralFloat(((float) 3.0).ToString(), ((float) 3.0).ToString(), ((float) 3.0).ToString()), Is.EqualTo("Equilateral"));
        }

        [Test]
        public void TestEquilateralNotNumeric()
        {
            Assert.That(_calculator.GetTriangleTypeNotNumeric("a", "a", "3"), Is.EqualTo("Non-Numeric Values"));
        }

    }
}
