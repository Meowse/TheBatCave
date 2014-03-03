using NUnit.Framework;

namespace FizzBuzz
{
    [TestFixture]
    public class FizzBuzzTests
    {
        private static readonly FizzBuzz FizzBuzz = new FizzBuzz();
        [Test]
        public void TestFizzBuzz()
        {
            string[] expected = {"1", "2", "Fizz", "4", "Buzz", "Fizz", "7", "8", "Fizz", "Buzz", "11", "Fizz", "13", "14", "FizzBuzz"};
            Assert.That(FizzBuzz.FizzBuzzCount(15), Is.EqualTo(expected));
        }
    }
}
