using NUnit.Framework;

namespace FizzBuzz
{
    [TestFixture]
    class FizzBuzzCalculatorTests
    {
        private readonly FizzBuzzCalculator _calculator = new FizzBuzzCalculator();

        [Test]
        public void ReturnsFizzForMultiplesOf3ThatAreNotMultiplesOf5()
        {
            Assert.That(_calculator.Calculate(1 * 3), Is.EqualTo("Fizz"));
            Assert.That(_calculator.Calculate(2 * 3), Is.EqualTo("Fizz"));
            Assert.That(_calculator.Calculate(3 * 3), Is.EqualTo("Fizz"));
            Assert.That(_calculator.Calculate(4 * 3), Is.EqualTo("Fizz"));
            // Skipping "5 * 3", since it shouldn't return "Fizz" for that
            Assert.That(_calculator.Calculate(6 * 3), Is.EqualTo("Fizz"));
        }

        [Test]
        public void ReturnsBuzzForMultiplesOf5ThatAreNotMultiplesOf3()
        {
            Assert.That(_calculator.Calculate(1 * 5), Is.EqualTo("Buzz"));
            Assert.That(_calculator.Calculate(2 * 5), Is.EqualTo("Buzz"));
            // Skipping "3 * 5", since it shouldn't return "Buzz" for that
            Assert.That(_calculator.Calculate(4 * 5), Is.EqualTo("Buzz"));
        }

        [Test]
        public void ReturnsFizzBuzzForMultiplesOf3And5()
        {
            Assert.That(_calculator.Calculate(3*5), Is.EqualTo("FizzBuzz"));
            Assert.That(_calculator.Calculate(2 * 3 * 5), Is.EqualTo("FizzBuzz"));
            Assert.That(_calculator.Calculate(3 * 3 * 5), Is.EqualTo("FizzBuzz"));
            Assert.That(_calculator.Calculate(5 * 3 * 5), Is.EqualTo("FizzBuzz"));
        }
    }
}
