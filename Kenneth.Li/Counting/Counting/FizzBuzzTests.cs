using System;
using Counting;
using NUnit.Framework;

namespace Counting
{
    [TestFixture]
    class FizzBuzzTests
    {
        private static readonly FizzBuzz FizzBuzz = new FizzBuzz();

        [Test]
        public void CountTo15()
        {
            string[] expected =
            {
                "1", "2", "Fizz", "4", "Buzz", "Fizz", "7", "8", "Fizz", "Buzz", "11", "Fizz", "13",
                "14", "FizzBuzz"
            };
            Assert.That(FizzBuzz.Count(1, 15), Is.EqualTo(expected));
        }
    }
}
