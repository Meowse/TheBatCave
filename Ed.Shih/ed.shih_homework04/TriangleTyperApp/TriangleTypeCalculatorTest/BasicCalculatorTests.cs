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
            Assert.That(_calculator.GetTriangleType("go", "#", "blue"), Is.EqualTo("Make sure all sides are Integers"));
        }
        [Test]
        public void TestInteger2()
        {
            Assert.That(_calculator.GetTriangleType("tuba", "10", "42"), Is.EqualTo("Make sure all sides are Integers"));
        }
        [Test]
        public void TestInteger3()
        {
            Assert.That(_calculator.GetTriangleType("four", "IV", "4"), Is.EqualTo("Make sure all sides are Integers"));
        }
        [Test]
        public void TestIntRange1()
        {
            Assert.That(_calculator.GetTriangleType("0", "0", "0"), Is.EqualTo("Sides must be greater than 0 and less than 2,000,000,000"));
        }
        [Test]
        public void TestIntRange2()
        {
            Assert.That(_calculator.GetTriangleType("-4", "4", "20"), Is.EqualTo("Sides must be greater than 0 and less than 2,000,000,000"));
        }
        [Test]
        public void TestIntRange3()
        {
            Assert.That(_calculator.GetTriangleType("2000000001", "2000000001", "2000000001"), Is.EqualTo("Sides must be greater than 0 and less than 2,000,000,000"));
        }
        [Test]
        public void TestIntRange4()
        {
            Assert.That(_calculator.GetTriangleType("2000000001", "0", "2000000001"), Is.EqualTo("Sides must be greater than 0 and less than 2,000,000,000"));
        }
        [Test]
        public void TestIsTriangle1()
        {
            Assert.That(_calculator.GetTriangleType("1", "10", "1"), Is.EqualTo("The sides do not form a triangle"));
        }
        [Test]
        public void TestIsTriangle2()
        {
            Assert.That(_calculator.GetTriangleType("2000000000", "1", "1"), Is.EqualTo("The sides do not form a triangle"));
        }
        [Test]
        public void TestIsTriangle3()
        {
            Assert.That(_calculator.GetTriangleType("1", "1", "2000000000"), Is.EqualTo("The sides do not form a triangle"));
        }
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
            Assert.That(_calculator.GetTriangleType("2000000000", "2000000000", "2000000000"), Is.EqualTo("Equilateral"));
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
