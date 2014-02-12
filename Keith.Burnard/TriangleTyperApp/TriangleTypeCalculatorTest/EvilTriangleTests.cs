using NUnit.Framework;
using TriangleTyperApp;

namespace TriangleTypeCalculatorTest
{
    [TestFixture]
    public class EvilTriangleTests
    {
        private readonly InputValidator _inputValidator = new InputValidator();
        private readonly ValidatingCalculator _validatingCalculator = new ValidatingCalculator();

        private readonly TriangleTypeCalculator _calculator = new TriangleTypeCalculator();
        private readonly string _maxInt = int.MaxValue.ToString();
        private readonly string _maxIntMinus1 = (int.MaxValue - 1).ToString();
        private readonly string _maxIntMinus2 = (int.MaxValue - 2).ToString();
        
        [Test]
        public void VeryLongSidesEquilateral()
        {
            Assert.That(_calculator.GetTriangleType(_maxInt, _maxInt, _maxInt), Is.EqualTo("Equilateral"));
            //Assert.That(_validatingCalculator.GetValidatedTriangleType(_maxInt, _maxInt, _maxInt), Is.EqualTo("Equilateral"));
            //Assert.That(_calculator.GetTriangleType(_maxInt, _maxInt, _maxInt), Is.EqualTo("Equilateral"));
        }

        [Test]
        public void VeryLongSidesIsosceles()
        {
            Assert.That(_calculator.GetTriangleType("1", _maxInt, _maxInt), Is.EqualTo("Isosceles"));
            Assert.That(_calculator.GetTriangleType(_maxInt, _maxInt, "1"), Is.EqualTo("Isosceles"));
            Assert.That(_calculator.GetTriangleType(_maxInt, "1", _maxInt), Is.EqualTo("Isosceles"));

            Assert.That(_calculator.GetTriangleType(_maxIntMinus1, _maxInt, _maxInt), Is.EqualTo("Isosceles"));
            Assert.That(_calculator.GetTriangleType(_maxInt, _maxInt, _maxIntMinus1), Is.EqualTo("Isosceles"));
            Assert.That(_calculator.GetTriangleType(_maxInt, _maxIntMinus1, _maxInt), Is.EqualTo("Isosceles"));

            Assert.That(_calculator.GetTriangleType(_maxIntMinus1, _maxIntMinus1, _maxInt), Is.EqualTo("Isosceles"));
            Assert.That(_calculator.GetTriangleType(_maxIntMinus1, _maxInt, _maxIntMinus1), Is.EqualTo("Isosceles"));
            Assert.That(_calculator.GetTriangleType(_maxInt, _maxIntMinus1, _maxIntMinus1), Is.EqualTo("Isosceles"));
        }

        [Test]
        public void VeryLongSidesScalene()
        {
            Assert.That(_calculator.GetTriangleType(_maxInt, _maxIntMinus1, _maxIntMinus2), Is.EqualTo("Scalene"));
            Assert.That(_calculator.GetTriangleType(_maxInt, _maxIntMinus2, _maxIntMinus1), Is.EqualTo("Scalene"));
            Assert.That(_calculator.GetTriangleType(_maxIntMinus1, _maxInt, _maxIntMinus2), Is.EqualTo("Scalene"));
            Assert.That(_calculator.GetTriangleType(_maxIntMinus1, _maxIntMinus2, _maxInt), Is.EqualTo("Scalene"));
            Assert.That(_calculator.GetTriangleType(_maxIntMinus2, _maxInt, _maxIntMinus1), Is.EqualTo("Scalene"));
            Assert.That(_calculator.GetTriangleType(_maxIntMinus2, _maxIntMinus1, _maxInt), Is.EqualTo("Scalene"));
        }
    }
}
