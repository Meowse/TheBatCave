﻿using NUnit.Framework;
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
        public void TestIsoceles()
        {
            Assert.That(_calculator.GetTriangleType("5", "5", "3"), Is.EqualTo("Isosceles"));
        }

        [Test]
        public void TestScalene()
        {
            Assert.That(_calculator.GetTriangleType("3", "4", "5"), Is.EqualTo("Scalene"));
        }
    }
}
