using System;
using NUnit.Framework;
using TriangleTyperApp;

namespace TriangleTypeCalculatorTest
{
    [TestFixture]
    public class BasicCalculatorTests
    {
        private readonly TriangleTypeCalculator _calculator = new TriangleTypeCalculator();

        [Test]
        public void TestTriangleRules()
        {
            //Assert.That(_calculator.GetTriangleType("a", "a", "3"), Is.EqualTo("Input Must be Numeric"));
            Assert.That(_calculator.GetTriangleType("3", "3", "3"), Is.EqualTo("Equilateral"));
            Assert.That(_calculator.GetTriangleType("4", "5", "11"), Is.EqualTo("Scalene"));
            Assert.That(_calculator.GetTriangleType("4", "4", "3"), Is.EqualTo("Isosceles"));
            Assert.That(_calculator.GetTriangleType("-1", "4", "5"), Is.EqualTo("Please Enter a Positive Number"));
            Assert.That(_calculator.GetTriangleType("0", "0", "0"), Is.EqualTo("Please Enter a Positive Number"));
            Assert.That(_calculator.GetTriangleType("0", "4", "5"), Is.EqualTo("Please Enter a Positive Number"));
            Assert.That(_calculator.GetTriangleType("-1", "-1", "-1"), Is.EqualTo("Please Enter a Positive Number"));
        }
    }
}
