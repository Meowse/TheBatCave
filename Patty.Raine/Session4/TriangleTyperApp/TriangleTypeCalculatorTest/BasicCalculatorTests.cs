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
            Assert.That(_calculator.GetTriangleType("6", "6", "6"), Is.EqualTo("Equilateral"));
        }
        [Test]
        public void TestScalene()
        {
            Assert.That(_calculator.GetTriangleType("2", "3", "4"), Is.EqualTo("Scalene"));
            Assert.That(_calculator.GetTriangleType("10", "12", "16"), Is.EqualTo("Scalene"));
        }
        [Test]
        public void TestIsosceles()
        {
            Assert.That(_calculator.GetTriangleType("3", "3", "5"), Is.EqualTo("Isosceles"));
            Assert.That(_calculator.GetTriangleType("3", "5", "3"), Is.EqualTo("Isosceles"));
            Assert.That(_calculator.GetTriangleType("5", "3", "3"), Is.EqualTo("Isosceles"));
        }
        [Test]
        public void TestCharacters()
        {
            Assert.That(_calculator.GetTriangleType("open", "3", "3"), Is.EqualTo("Input must be numeric"));
            Assert.That(_calculator.GetTriangleType("5", "3", "L"), Is.EqualTo("Input must be numeric"));
        }
        [Test]
        public void TestPositive()
        {
            Assert.That(_calculator.GetTriangleType("-1", "3", "3"), Is.EqualTo("Positive numbers greater than 0 are required"));
            Assert.That(_calculator.GetTriangleType("-120", "100", "130"), Is.EqualTo("Positive numbers greater than 0 are required"));
            Assert.That(_calculator.GetTriangleType("0", "3", "3"), Is.EqualTo("Positive numbers greater than 0 are required"));
            Assert.That(_calculator.GetTriangleType("0", "0", "0"), Is.EqualTo("Positive numbers greater than 0 are required"));
        }
        [Test]
        public void TestEasterEgg()
        {
            Assert.That(_calculator.GetTriangleType("open", "podbay", "doors"), Is.EqualTo("I'm sorry Dave, I'm afraid I can't do that"));
        }
    }
}
