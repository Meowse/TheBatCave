using NUnit.Framework;

namespace FizzBuzz
{
    class TestFizzBuzz
    {
        FizzBuzzCounter _fizzBuzzCounter = new FizzBuzzCounter();

        [Test]
        public void CountFromZeroToTen()
        {
            string[] expected = { "", "1", "2", "Fizz", "4", "Buzz", "Fizz", "7", "8","Fizz","Buzz" };
            Assert.That(_fizzBuzzCounter.Counter(10), Is.EqualTo(expected));
        }

        [Test]
        public void CountFromZeroToFifteen()
        {
            string[] expected = { "", "1", "2", "Fizz", "4", "Buzz", "Fizz", "7", "8", "Fizz", "Buzz", "11", "Fizz", "13","14","FizzBuzz" };
            Assert.That(_fizzBuzzCounter.Counter(15), Is.EqualTo(expected));
        }
    }
}
