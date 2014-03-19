using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using FizzBuzz;

namespace FizzBuzz
{
    [TestFixture]
    class TestFizzBuzz
    {
        [Test]
        public void IsFizzBuzz()
        {
            string[] expected = {"1", "2", "Fizz", "4", "Buzz", "Fizz", "7", "8", "Fizz", "Buzz", "11", "Fizz", "13", "14", "FizzBuzz"};
            Assert.That(FizzBuzzCompiler.FizzBuzzed(15), Is.EqualTo(expected));
        }
    }
}
