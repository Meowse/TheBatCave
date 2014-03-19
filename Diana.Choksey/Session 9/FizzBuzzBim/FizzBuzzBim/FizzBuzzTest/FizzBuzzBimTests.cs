using FizzBuzzBim;
using NUnit.Framework;

namespace FizzBuzzBimTest
{
    [TestFixture]
    public class FizzBuzzBimTests
    {

        [Test]
        public void CanDoFizzBuzz()
        {
            string[] expected = { "1", "fizz", "buzz", "fizz", "bim", "fizzbuzz", "7", "fizz", "buzz", "fizzbim", "11", "fizzbuzz", "13", "fizz", "buzzbim", "fizz" };
            string[] fizzBuzz = FizzBuzzBimCalculator.FizzBuzzBim(16, 2, 3, 5);
            Assert.That(fizzBuzz, Is.EqualTo(expected));
        }
    }

}
