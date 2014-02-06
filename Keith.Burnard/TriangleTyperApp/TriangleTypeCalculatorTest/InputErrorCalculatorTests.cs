using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using TriangleTyperApp;

namespace TriangleTypeCalculatorTest
{
    class InputErrorCalculatorTests
    {
        private readonly TriangleTypeCalculator _calculator = new TriangleTypeCalculator();

        [Test]
        public void TestThatValuesWereInput()
        {
            Assert.That(_calculator.GetTriangleType("", "", ""), Is.EqualTo("Please enter a length for each side"));
            Assert.That(_calculator.GetTriangleType("", "", "3"), Is.EqualTo("Please enter a length for each side"));

        }
        [Test]
        public void TestPositiveInteger()
        {
            Assert.That(_calculator.GetTriangleType("a", "a", "20"), Is.EqualTo("Input must be a positive integer"));
            Assert.That(_calculator.GetTriangleType("three", "three", "three"), Is.EqualTo("Input must be a positive integer"));
            Assert.That(_calculator.GetTriangleType("&", "*", "VII"), Is.EqualTo("Input must be a positive integer"));
            Assert.That(_calculator.GetTriangleType("1f", "2f", "2f"), Is.EqualTo("Input must be a positive integer"));

            Assert.That(_calculator.GetTriangleType("-1", "-2", "-3"), Is.EqualTo("Input must be a positive integer"));
            Assert.That(_calculator.GetTriangleType("0", "0", "0"), Is.EqualTo("Input must be a positive integer"));
            Assert.That(_calculator.GetTriangleType("3.5", "3.5", "3.5"), Is.EqualTo("Input must be a positive integer"));
            
        }

        [Test]
        public void TestTheSidesMakeATriangle()
        {
            
            Assert.That(_calculator.GetTriangleType("3", "2", "1"), Is.EqualTo("Not a triangle"));
            Assert.That(_calculator.GetTriangleType("1", "17", "1"), Is.EqualTo("Not a triangle"));

        }

        [Test]
        public void TestCornerCases()
        {

            Assert.That(_calculator.GetTriangleType("2,147,483,648", "2,147,483,648", "2,147,483,648"), Is.EqualTo("Input out of range (cannot be more than 2,147,483,647)"));
            
        }

        [Test]
        public void TestEasterEgg()
        {
            Assert.That(_calculator.GetTriangleType("open the", "pod bay", "doors, HAL"), Is.EqualTo("I'm sorry, Dave. I'm afraid I can't do that."));

        }
    }
}
