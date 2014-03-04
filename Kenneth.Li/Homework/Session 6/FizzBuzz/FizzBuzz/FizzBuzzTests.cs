using System;
using FizzBuzz;
using NUnit.Framework;

namespace FizzBuzz
{
    [TestFixture]
    class FizzBuzzTests
    {
        private static readonly FizzBuzz FizzBuzz = new FizzBuzz();

        [Test]
        public void CountTo15()
        {
            string expected =
                "0\r\n1\r\n2\r\nFizz\r\n4\r\nBuzz\r\nFizz\r\n7\r\n8\r\nFizz\r\nBuzz\r\n11\r\nFizz\r\n13\r\n14\r\nFizzBuzz\r\n";
            Assert.That(FizzBuzz.Count(15), Is.EqualTo(expected));
        }
    }
}
