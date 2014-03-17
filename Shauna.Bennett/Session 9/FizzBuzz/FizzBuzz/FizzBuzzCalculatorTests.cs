using NUnit.Framework;

namespace FizzBuzzBim
{
    [TestFixture]
    class FizzBuzzBimCalculatorTests
    {
        private readonly FizzBuzzBimCalculator _calculator = new FizzBuzzBimCalculator();

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

        [Test]
        public void FizzBuzz57ReturnsFizzForMultiplesOf5ThatAreNotMultiplesOf7()
        {
            var fizzBuzz57 = new FizzBuzzCalculator(5,7);
            Assert.That(fizzBuzz57.Calculate(1 * 5), Is.EqualTo("Fizz"));
            Assert.That(fizzBuzz57.Calculate(2 * 5), Is.EqualTo("Fizz"));
            Assert.That(fizzBuzz57.Calculate(3 * 5), Is.EqualTo("Fizz"));
            Assert.That(fizzBuzz57.Calculate(4 * 5), Is.EqualTo("Fizz"));
            Assert.That(fizzBuzz57.Calculate(5 * 5), Is.EqualTo("Fizz"));
            Assert.That(fizzBuzz57.Calculate(6 * 5), Is.EqualTo("Fizz"));
            // Skipping "7 * 5", since it shouldn't return "Fizz" for that
            Assert.That(fizzBuzz57.Calculate(8 * 5), Is.EqualTo("Fizz"));
        }

        [Test]
        public void FizzBuzz57ReturnsBuzzForMultiplesOf7ThatAreNotMultiplesOf5()
        {
            var fizzBuzz57 = new FizzBuzzCalculator(5, 7);
            Assert.That(fizzBuzz57.Calculate(1 * 7), Is.EqualTo("Buzz"));
            Assert.That(fizzBuzz57.Calculate(2 * 7), Is.EqualTo("Buzz"));
            Assert.That(fizzBuzz57.Calculate(3 * 7), Is.EqualTo("Buzz"));
            Assert.That(fizzBuzz57.Calculate(4 * 7), Is.EqualTo("Buzz"));
            // Skipping "5 * 7", since it shouldn't return "Buzz" for that
            Assert.That(fizzBuzz57.Calculate(6 * 7), Is.EqualTo("Buzz"));
        }

        [Test]
        public void FizzBuzz57ReturnsFizzBuzzForMultiplesOf5And7()
        {
            var fizzBuzz57 = new FizzBuzzCalculator(5, 7);
            Assert.That(fizzBuzz57.Calculate(5 * 7), Is.EqualTo("FizzBuzz"));
            Assert.That(fizzBuzz57.Calculate(2 * 5 * 7), Is.EqualTo("FizzBuzz"));
            Assert.That(fizzBuzz57.Calculate(3 * 5 * 7), Is.EqualTo("FizzBuzz"));
            Assert.That(fizzBuzz57.Calculate(4 * 5 * 7), Is.EqualTo("FizzBuzz"));
        }
    }

    internal class FizzBuzzBimCalculator
    {
        public object Calculate(int p0)
        {
            throw new System.NotImplementedException();
        }
    }
}
