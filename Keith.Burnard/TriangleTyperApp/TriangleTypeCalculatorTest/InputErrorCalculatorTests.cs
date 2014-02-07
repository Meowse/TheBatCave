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
        private readonly InputValidation _inputValidation = new InputValidation();
        
        [Test]
        public void TestPositiveInteger()
        {
            Assert.That(_inputValidation.TestInputValues("", "", ""), Is.EqualTo("Each side must be a positive integer"));
            Assert.That(_inputValidation.TestInputValues("", "", "3"), Is.EqualTo("Each side must be a positive integer"));

            Assert.That(_inputValidation.TestInputValues("a", "a", "20"), Is.EqualTo("Each side must be a positive integer"));
            Assert.That(_inputValidation.TestInputValues("three", "three", "three"), Is.EqualTo("Each side must be a positive integer"));
            Assert.That(_inputValidation.TestInputValues("&", "*", "VII"), Is.EqualTo("Each side must be a positive integer"));
            Assert.That(_inputValidation.TestInputValues("1f", "2f", "2f"), Is.EqualTo("Each side must be a positive integer"));
            Assert.That(_inputValidation.TestInputValues("3.5", "3.5", "3.5"), Is.EqualTo("Each side must be a positive integer"));

            Assert.That(_inputValidation.TestInputValues("-1", "-2", "-3"), Is.EqualTo("Each side must be a positive integer"));
            Assert.That(_inputValidation.TestInputValues("0", "0", "0"), Is.EqualTo("Each side must be a positive integer"));
             
        }

        [Test]
        public void TestTheSidesMakeATriangle()
        {

            Assert.That(_inputValidation.TestInputValues("3", "2", "1"), Is.EqualTo("The sides do not make a triangle"));
            Assert.That(_inputValidation.TestInputValues("1", "17", "1"), Is.EqualTo("The sides do not make a triangle"));

        }

        [Test]
        public void TestOutOfRange()
        {

            Assert.That(_inputValidation.TestInputValues("2,147,483,648", "2,147,483,648", "2,147,483,648"), Is.EqualTo("Input out of range (cannot be more than 2,147,483,647)"));
            
        }

        [Test]
        public void TestEasterEgg()
        {
            Assert.That(_inputValidation.TestInputValues("open the", "pod bay", "doors, HAL"), Is.EqualTo("I'm sorry, Dave. I'm afraid I can't do that."));

        }
    }
}
