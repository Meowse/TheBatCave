using NUnit.Framework;
using TriangleTyperApp;

namespace TriangleTypeCalculatorTest
{
    [TestFixture]
    public class EvilNonTriangleTests
    {
        private readonly TriangleTypeCalculator _calculator = new TriangleTypeCalculator();
        private readonly InputValidator _inputValidator = new InputValidator();
        private readonly ValidatingCalculator _validatingCalculator = new ValidatingCalculator();

        [Test]
        public void VeryLongSidesMustMakeTriangle()
        {
            //Assert.That(IsError(_calculator.GetTriangleType("1", int.MaxValue.ToString(), "1")), Is.True);
            //Assert.That(IsError(_calculator.GetTriangleType(int.MaxValue.ToString(), "1", "1")), Is.True);
            //Assert.That(IsError(_calculator.GetTriangleType("1", "1", int.MaxValue.ToString())), Is.True);
            Assert.That(IsError(_inputValidator.TestInputValues("1", int.MaxValue.ToString(), "1")), Is.True);
            Assert.That(IsError(_inputValidator.TestInputValues(int.MaxValue.ToString(), "1", "1")), Is.True);
            Assert.That(IsError(_inputValidator.TestInputValues("1", "1", int.MaxValue.ToString())), Is.True);

            Assert.That(_inputValidator.TestInputValues("1", "1", int.MaxValue.ToString()), Is.EqualTo("The sides do not make a triangle"));
        }

        private bool IsError(string result)
        {
            return ((result != "Equilateral") && (result != "Isosceles") && (result != "Scalene"));
        }
    }
}
