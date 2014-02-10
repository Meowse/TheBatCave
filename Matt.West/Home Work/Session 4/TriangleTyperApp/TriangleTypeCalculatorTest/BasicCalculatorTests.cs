using NUnit.Framework;
using TriangleTyperApp;

namespace TriangleTypeCalculatorTest
{
    [TestFixture]
    public class BasicCalculatorTests
    {
        private readonly TriangleTypeCalculator _calculator = new TriangleTypeCalculator();
        private readonly InputValidations _validations = new InputValidations();
       
//        Input verifications:
//        1.	All sides must be Int64 inputs
//        2.	All numeric inputs must be positive
//        3.	The sum of any two sides must be > the remaining side
//
//        Triangle types:
//        1.	Isosceles (All three sides are equal)
//        2.	Equilateral  (Two sides are equal)
//        3.	Scalene (No two sides are equal)


        [Test]
        public void TestInputsAsValid()
        {
            Assert.That(_validations.GetInputValidations("A", "1", "2"), Is.EqualTo("Input is not a positive 64 bit integer"));
            Assert.That(_validations.GetInputValidations("1", "2", "3"), Is.EqualTo("The sum of any two sides must be larger than the third side."));
            Assert.That(_validations.GetInputValidations("-1", "-1", "-1"), Is.EqualTo("All inputs must be integers greater than 0."));
            Assert.That(_validations.GetInputValidations("0", "0", "0"), Is.EqualTo("All inputs must be integers greater than 0."));
            Assert.That(_validations.GetInputValidations("9223372036854775807", "9223372036854775807", "9223372036854775808"), Is.EqualTo("Input is not a positive 64 bit integer"));
        }

        [Test]
        public void TestEquilateral()
        {
            Assert.That(_calculator.GetTriangleType("3", "3", "3"), Is.EqualTo("Equilateral"));
        }
        [Test]
        public void TestIsosceles()
        {
            Assert.That(_calculator.GetTriangleType("1", "3", "3"), Is.EqualTo("Isosceles"));
            Assert.That(_calculator.GetTriangleType("3", "3", "1"), Is.EqualTo("Isosceles"));
            Assert.That(_calculator.GetTriangleType("3", "1", "3"), Is.EqualTo("Isosceles"));
        }
        [Test]
        public void TestScalene()
        {
            Assert.That(_calculator.GetTriangleType("4", "2", "1"), Is.EqualTo("Scalene"));
        }

    }
}
