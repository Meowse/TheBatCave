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
        public void TestIsosceles()
        {
            Assert.That(_calculator.GetTriangleType("3", "3", "5"), Is.EqualTo("Isosceles"));
        }
        [Test]
        public void TestScalene()
        {
            Assert.That(_calculator.GetTriangleType("3", "4", "5"), Is.EqualTo("Scalene"));
        }
        [Test]
        public void TestPositiveNumber()
        {
            Assert.That(_calculator.GetTriangleType("-1", "-2", "-3"), Is.EqualTo("Input must be a positive number"));
            Assert.That(_calculator.GetTriangleType("-1", "-2", "-3"), Is.EqualTo("Input must be a positive number"));
            Assert.That(_calculator.GetTriangleType("0", "0", "0"), Is.EqualTo("Input must be a positive number"));
        }
        [Test]
        public void NotATriangle()
        {
            Assert.That(_calculator.GetTriangleType("1", "17", "1"), Is.EqualTo("Not a triangle. Please reenter inputs."));
            Assert.That(_calculator.GetTriangleType("3", "2", "1"), Is.EqualTo("Not a triangle. Please reenter inputs."));
        }

        [Test]
        public void TestIsNumber()
        {
            Assert.That(_calculator.GetTriangleType("a", "a", "20"), Is.EqualTo("Input value must be an integer"));
            Assert.That(_calculator.GetTriangleType(" ", " ", " "), Is.EqualTo("Input value must be an integer"));
            Assert.That(_calculator.GetTriangleType(" ", " ", "3"), Is.EqualTo("Input value must be an integer"));
            Assert.That(_calculator.GetTriangleType("three", "three", "three"), Is.EqualTo("Input value must be an integer"));
        }

        [Test]
        public void SpaceOdyssey()
        {
            Assert.That(_calculator.GetTriangleType("open", "podbay", "door"), Is.EqualTo("I'm sorry, Dave, I can't allow you to do that."));
        }
    }
}
