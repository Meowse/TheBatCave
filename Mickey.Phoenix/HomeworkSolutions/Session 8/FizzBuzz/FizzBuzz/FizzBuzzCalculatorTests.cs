using NUnit.Framework;

namespace FizzBuzz
{
    [TestFixture]
    class FizzBuzzCalculatorTests
    {
        private readonly FizzBuzzCalculator _calculator = new FizzBuzzCalculator();

        [Test]
        public void ReturnsFizzForMultiplesOf3()
        {
            Assert.That(_calculator.Calculate(3), Is.EqualTo("Fizz"));
            Assert.That(_calculator.Calculate(6), Is.EqualTo("Fizz"));
            Assert.That(_calculator.Calculate(9), Is.EqualTo("Fizz"));
        }
    }
}
