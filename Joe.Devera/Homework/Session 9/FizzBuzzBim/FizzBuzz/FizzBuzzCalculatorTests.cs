using System.Net.NetworkInformation;
using NUnit.Framework;

namespace FizzBuzz
{
    [TestFixture]
    class FizzBuzzCalculatorTests
    {
        private readonly FizzBuzzCalculator _calculator = new FizzBuzzCalculator();

        [Test]
        public void ReturnsBuzzForMultiplesOf2ThatAreNotMultiplesOf3Or5()
        {
            Assert.That(_calculator.Calculate(1 * 2), Is.EqualTo("Fizz"));
            Assert.That(_calculator.Calculate(2 * 2), Is.EqualTo("Fizz"));
            // Skipping "3 * 2", since it shouldn't return "FizzBuzz" for that
        }

        [Test]
        public void ReturnsBuzzForMultiplesOf3ThatAreNotMultiplesOf2Or5()
        {
            Assert.That(_calculator.Calculate(1 * 3), Is.EqualTo("Buzz"));
            Assert.That(_calculator.Calculate(3 * 3), Is.EqualTo("Buzz"));

        }

        [Test]
        public void ReturnsBimForMultiplesOf5ThatAreNotMultipleOf2Or3()
        {
            Assert.That(_calculator.Calculate(1 * 5), Is.EqualTo("Bim"));
            Assert.That(_calculator.Calculate(5 * 5), Is.EqualTo("Bim"));
        }

        [Test]
        public void FizzBuzz57ReturnsFizzBimForMultiplesOf5ThatAreMultiplesOf2()
        {
            var fizzBuzz57 = new FizzBuzzCalculator(2,3,5);
            Assert.That(fizzBuzz57.Calculate(2 * 5), Is.EqualTo("FizzBim"));
            Assert.That(fizzBuzz57.Calculate(4 * 5), Is.EqualTo("FizzBim"));
            Assert.That(fizzBuzz57.Calculate(8 * 5), Is.EqualTo("FizzBim"));
            Assert.That(fizzBuzz57.Calculate(10 * 5), Is.EqualTo("FizzBim"));

        }

        [Test]
        public void FizzBuzz57ReturnsBuzzBimForMultiplesOf5ThatAreMultiplesOf3()
        {
            var fizzBuzz57 = new FizzBuzzCalculator(2,3,5);
            Assert.That(fizzBuzz57.Calculate(3 * 5), Is.EqualTo("BuzzBim"));
            Assert.That(fizzBuzz57.Calculate(9 * 5), Is.EqualTo("BuzzBim"));
        }

        [Test]
        public void FizzBuzz57ReturnsFizzBuzzBimForMultiplesOf2And3And5()
        {
            var fizzBuzz57 = new FizzBuzzCalculator(2, 3, 5);
            Assert.That(fizzBuzz57.Calculate(2*3*5), Is.EqualTo("FizzBuzzBim"));
        }
    }
}
