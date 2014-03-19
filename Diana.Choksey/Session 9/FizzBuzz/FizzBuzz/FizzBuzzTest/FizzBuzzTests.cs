using FizzBuzz;
using NUnit.Framework;

namespace FizzBuzzTest
{
    [TestFixture]
    public class FizzBuzzTests
    {

        [Test]
        public void CanDoFizzBuzz()
        {
            string[] expected = { "1", "fizz", "buzz", "fizz", "bim", "fizzbuzz", "7", "fizz", "buzz", "fizzbim", "11", "fizzbuzz", "13", "fizz", "buzzbim", "fizz" };
            Assert.That(Fuzzy.FizzBuzz(13, 2, 3, 5), Is.EqualTo(expected));
        }
    }

}
