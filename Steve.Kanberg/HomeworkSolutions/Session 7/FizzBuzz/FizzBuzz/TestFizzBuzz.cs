using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace FizzBuzz
{
    [TestFixture]
    class TestFizzBuzz
    {
        [Test]
        public void IsFizzBuzz()
        {
            string expected = "Fizz";
            Assert.That(FizzBuzzCompiler.FizzBuzzed("Fizz"), Is.EqualTo(expected));

            string expected2 = "Buzz";
            Assert.That(FizzBuzzCompiler.FizzBuzzed("Buzz"), Is.EqualTo(expected2));

            string expected3 = "FizzBuzz";
            Assert.That(FizzBuzzCompiler.FizzBuzzed("FizzBuzz"), Is.EqualTo(expected3));
        }
    }
}
