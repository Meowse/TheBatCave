using NUnit.Framework;
using TriangleTyperApp;

namespace TriangleTypeCalculatorTest
{
    [TestFixture]
    public class EvilNonTriangleTests
    {
       
        private readonly InputValidations _validations = new InputValidations();
        [Test]
        public void VeryLongSidesMustMakeTriangle()
        {
            Assert.That(IsError(_validations.GetInputValidations("1", int.MaxValue.ToString(), "1")), Is.True);
            Assert.That(IsError(_validations.GetInputValidations(int.MaxValue.ToString(), "1", "1")), Is.True);
            Assert.That(IsError(_validations.GetInputValidations("1", "1", int.MaxValue.ToString())), Is.True);
        }

        private bool IsError(string result)
        {
            return ((result != "Equilateral") && (result != "Isosceles") && (result != "Scalene"));
        }
    }
}
