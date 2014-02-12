using NUnit.Framework;
using TriangleTyperApp;

namespace TriangleTypeCalculatorTest
{
    [TestFixture]
    public class BasicCalculatorTests
    {
        private readonly TriangleTypeCalculator _calculator = new TriangleTypeCalculator();

        [Test]
        public void TestInteger1()
        {
            Assert.That(_calculator.GetTriangleType("MEOUSE", "&", "BAA@#@$"), Is.EqualTo("Make sure all sides are Integers"));
        }

        [Test]
        public void TestForTriangle()
        {
            Assert.That(_calculator.GetTriangleType("1", "2", "3"), Is.EqualTo("Sorry Dave these sides do not a triangle make"));
        }


        [Test]
        public void TestEquilateral()
        {
            Assert.That(_calculator.GetTriangleType("3", "3", "3"), Is.EqualTo("Equilateral"));
            Assert.That(_calculator.GetTriangleType("2147483647", "2147483647", "2147483647"), Is.EqualTo("Equilateral"));
        }

        [Test]
        public void TestIsoceles()
        {
            Assert.That(_calculator.GetTriangleType("3", "3", "1"), Is.EqualTo("Isoceles"));
            Assert.That(_calculator.GetTriangleType("2147483647", "2147483647", "1"), Is.EqualTo("Isoceles"));
            Assert.That(_calculator.GetTriangleType("1","2147483647", "2147483647"), Is.EqualTo("Isoceles"));
            Assert.That(_calculator.GetTriangleType("2147483647","1", "2147483647"), Is.EqualTo("Isoceles"));
        }

        [Test]
        public void TestScalene()
        {
            Assert.That(_calculator.GetTriangleType("5", "4", "8"), Is.EqualTo("Scalene"));
            Assert.That(_calculator.GetTriangleType("2147483647", "2147483647", "1"), Is.EqualTo("Isoceles"));
            Assert.That(_calculator.GetTriangleType("1", "2147483647", "2147483647"), Is.EqualTo("Isoceles"));
            Assert.That(_calculator.GetTriangleType("2147483647", "1", "2147483647"), Is.EqualTo("Isoceles"));
        }

        
    }
}
