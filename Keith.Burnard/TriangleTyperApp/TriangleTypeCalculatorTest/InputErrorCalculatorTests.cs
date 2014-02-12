using NUnit.Framework;
using TriangleTyperApp;

namespace TriangleTypeCalculatorTest
{
    class InputErrorCalculatorTests
    {
        private readonly InputValidator _inputValidator = new InputValidator();
        private readonly  ValidatingCalculator _validatingCalculator = new ValidatingCalculator();

        [Test]
        public void TestEndToEnd()
        {
            Assert.That(_validatingCalculator.GetValidatedTriangleType("3", "3", "3"), Is.EqualTo("Equilateral"));
        }

        [Test]
        public void TestValidInput()
        {

            Assert.That(_inputValidator.TestInputValues("3", "3", "3"), Is.EqualTo("Good"));
            Assert.That(_inputValidator.TestInputValues("3", "4", "4"), Is.EqualTo("Good"));
            Assert.That(_inputValidator.TestInputValues("3", "4", "5"), Is.EqualTo("Good"));
        }

        [Test]
        public void TestNeedABetterMessage()
        {
            // Need a better error message for these
            Assert.That(_inputValidator.TestInputValues("three", "three", "three"), Is.EqualTo("Each side must be a positive integer written as an unformatted number"));
            Assert.That(_inputValidator.TestInputValues("2,147", "2,147", "2,147"), Is.EqualTo("Each side must be a positive integer written as an unformatted number"));
            Assert.That(_inputValidator.TestInputValues("3", "3", "3.0"), Is.EqualTo("Each side must be a positive integer written as an unformatted number"));

        }

        [Test]
        public void TestPositiveInteger()
        {            
            Assert.That(_inputValidator.TestInputValues("", "", ""), Is.EqualTo("Each side must be a positive integer"));
            Assert.That(_inputValidator.TestInputValues("", "", "3"), Is.EqualTo("Each side must be a positive integer"));

            Assert.That(_inputValidator.TestInputValues("a", "a", "20"), Is.EqualTo("Each side must be a positive integer"));
            Assert.That(_inputValidator.TestInputValues("&", "*", "VII"), Is.EqualTo("Each side must be a positive integer"));
            Assert.That(_inputValidator.TestInputValues("1f", "2f", "2f"), Is.EqualTo("Each side must be a positive integer"));
            Assert.That(_inputValidator.TestInputValues("3.5", "3.5", "3.5"), Is.EqualTo("Each side must be a positive integer"));

            Assert.That(_inputValidator.TestInputValues("-1", "-2", "-3"), Is.EqualTo("Each side must be a positive integer"));
            Assert.That(_inputValidator.TestInputValues("0", "0", "0"), Is.EqualTo("Each side must be a positive integer"));
        }

        [Test]
        public void TestTheSidesMakeATriangle()
        {
            Assert.That(_inputValidator.TestInputValues("3", "2", "1"), Is.EqualTo("The sides do not make a triangle"));
            Assert.That(_inputValidator.TestInputValues("1", "17", "1"), Is.EqualTo("The sides do not make a triangle"));
        }

        [Test]
        public void TestOutOfRange()
        {
            //Assert.That(_inputValidator.TestInputValues("2147483648", "2147483648", "2147483648"), Is.EqualTo("Input out of range (cannot be more than 2,147,483,647)"));
            Assert.That(_inputValidator.TestInputValues("2147483647", "2147483647", "2147483647"), Is.EqualTo("Input out of range (cannot be more than 2,147,483,647)"));
        }

        [Test]
        public void TestEasterEgg()
        {
            Assert.That(_inputValidator.TestInputValues("open the", "pod bay", "doors, HAL"), Is.EqualTo("I'm sorry, Dave. I'm afraid I can't do that."));

        }
    }
}
