using System.Security.Cryptography.X509Certificates;
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
        public void TestIsoceles()
        {
            Assert.That(_calculator.GetTriangleType("8", "7", "8"), Is.EqualTo("Isoceles"));
            Assert.That(_calculator.GetTriangleType("10", "10", "82"), Is.EqualTo("Isoceles"));
        }

        [Test]
        public void TestScalene()
        {
            Assert.That(_calculator.GetTriangleType("8", "9", "10"), Is.EqualTo("Scalene"));
            Assert.That(_calculator.GetTriangleType("800", "90", "201"), Is.EqualTo("Scalene"));
        }