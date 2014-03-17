using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace FizzBuzz_2
{
    [TestFixture]
    class FizzBuzzCalculatorTests
    {
        private FizzBuzzCalculator _calculator = new FizzBuzzCalculator();
        [Test]
        public void ReturnsFizzForMultiplesof3()
        {
            Assert.That(_calculator.Calculate(3), Is.EqualTo("Fizz"));
            Assert.That(_calculator.Calculate(6), Is.EqualTo("Fizz"));
            Assert.That(_calculator.Calculate(9), Is.EqualTo("Fizz"));
            Assert.That(_calculator.Calculate(12), Is.EqualTo("Fizz"));
        }
        [Test]
        public void ReturnsBuzzForMultiplesof5()
        {
            Assert.That(_calculator.Calculate(5), Is.EqualTo("Buzz"));
            Assert.That(_calculator.Calculate(10), Is.EqualTo("Buzz"));
            Assert.That(_calculator.Calculate(20), Is.EqualTo("Buzz"));
        }
        [Test]
        public void ReturnsFizzBuzzForMultiplesof3And5()
        {
            Assert.That(_calculator.Calculate(15), Is.EqualTo("FizzBuzz"));
            Assert.That(_calculator.Calculate(30), Is.EqualTo("FizzBuzz"));
            Assert.That(_calculator.Calculate(45), Is.EqualTo("FizzBuzz"));
        }
    }
}
