using NUnit.Framework;
using TriangleTyperApp;

namespace TriangleTypeCalculatorTest
{
    [TestFixture]
    public class BasicCalculatorTests
    {
        private readonly TriangleTypeCalculator _calculator = new TriangleTypeCalculator();

        [Test]
        public void TestEquilateral1()
        {
            Assert.That(_calculator.GetTriangleType("3", "3", "3"), Is.EqualTo("Equilateral"));
        }
        [Test]
        public void TestEquilateral2()
        {
            Assert.That(_calculator.GetTriangleType("1", "1", "1"), Is.EqualTo("Equilateral"));
        }
        [Test]
        public void TestEquilateral3()
        {
            Assert.That(_calculator.GetTriangleType("2,147,483,647", "2,147,483,647", "2,147,483,647"), Is.EqualTo("Equilateral"));
        }
        [Test]
        public void TestIsoscoles1()
        {
            Assert.That(_calculator.GetTriangleType("1", "3", "3"), Is.EqualTo("Isoscoles"));
        }
        [Test]
        public void TestIsoscoles2()
        {
            Assert.That(_calculator.GetTriangleType("25", "1", "25"), Is.EqualTo("Isoscoles"));
        }
        [Test]
        public void TestIsoscoles3()
        {
            Assert.That(_calculator.GetTriangleType("2,147,483,647", "2,147,483,647", "1"), Is.EqualTo("Isoscoles"));
        }
        [Test]
        public void TestScalene1()
        {
            Assert.That(_calculator.GetTriangleType("1", "2", "4"), Is.EqualTo("Scalene"));
        }
        [Test]
        public void TestScalene2()
        {
            Assert.That(_calculator.GetTriangleType("3", "4", "5"), Is.EqualTo("Scalene"));
        }
        [Test]
        public void TestScalene3()
        {
            Assert.That(_calculator.GetTriangleType("2,147,483,647", "2,147,483,646", "2"), Is.EqualTo("Scalene"));
        }
    }
}
