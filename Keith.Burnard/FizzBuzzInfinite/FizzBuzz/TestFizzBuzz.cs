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
            Assert.That(_fizzBuzzCounter.Counter(10, 3, "Fizz", 5, "Buzz"), Is.EqualTo(expected));
        }

        [Test]
        public void CountFromZeroToFifteen()
        {
            string[] expected = { "", "1", "2", "Fizz", "4", "Buzz", "Fizz", "7", "8", "Fizz", "Buzz", "11", "Fizz", "13","14","FizzBuzz" };
            Assert.That(_fizzBuzzCounter.Counter(15, 3, "Fizz", 5, "Buzz"), Is.EqualTo(expected));
        }

        [Test]
        public void CountFromZeroToFifteenStarTrek()
        {
            string[] expected = { "", "1", "2", "Star", "4", "Trek", "Star", "7", "8", "Star", "Trek", "11", "Star", "13", "14", "StarTrek" };
            Assert.That(_fizzBuzzCounter.Counter(15, 3, "Star", 5, "Trek"), Is.EqualTo(expected));
        }
    }
}
