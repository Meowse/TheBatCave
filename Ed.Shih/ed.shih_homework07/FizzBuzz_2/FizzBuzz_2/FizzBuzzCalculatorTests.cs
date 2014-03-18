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
        public void fizzBuzz235ReturnsFizzBuzzBimForMultiplesof2_3_5()
        {
            var fizzBuzz235 = new FizzBuzzCalculator(2,3,5);
            Assert.That(fizzBuzz235.Calculate(1*2*3*5), Is.EqualTo("FizzBuzzBim"));
            Assert.That(fizzBuzz235.Calculate(2*2*3*5), Is.EqualTo("FizzBuzzBim"));
            Assert.That(fizzBuzz235.Calculate(3*2*3*5), Is.EqualTo("FizzBuzzBim"));
            Assert.That(fizzBuzz235.Calculate(4*2*3*5), Is.EqualTo("FizzBuzzBim"));
        }
        [Test]
        public void fizzBuzz235ReturnsFizzBimForMultiplesof2_5ThatAreNotMultOf3()
        {
            var fizzBuzz235 = new FizzBuzzCalculator(2, 3, 5);
            Assert.That(fizzBuzz235.Calculate(1*2*5), Is.EqualTo("FizzBim"));
            Assert.That(fizzBuzz235.Calculate(2*2*5), Is.EqualTo("FizzBim"));
            Assert.That(fizzBuzz235.Calculate(4*2*5), Is.EqualTo("FizzBim"));
            Assert.That(fizzBuzz235.Calculate(5*2*5), Is.EqualTo("FizzBim"));
        }
        [Test]
        public void fizzBuzz235ReturnsFizzBuzzForMultiplesof2_3ThatAreNotMultOf5()
        {
            var fizzBuzz235 = new FizzBuzzCalculator(2, 3, 5);
            Assert.That(fizzBuzz235.Calculate(1 * 2 * 3), Is.EqualTo("FizzBuzz"));
            Assert.That(fizzBuzz235.Calculate(2 * 2 * 3), Is.EqualTo("FizzBuzz"));
            Assert.That(fizzBuzz235.Calculate(3 * 2 * 3), Is.EqualTo("FizzBuzz"));
            Assert.That(fizzBuzz235.Calculate(4 * 2 * 3), Is.EqualTo("FizzBuzz"));
        }
        [Test]
        public void fizzBuzz235ReturnsBuzzBimForMultiplesof3_5ThatAreNotMultOf2()
        {
            var fizzBuzz235 = new FizzBuzzCalculator(2, 3, 5);
            Assert.That(fizzBuzz235.Calculate(1 * 3 * 5), Is.EqualTo("BuzzBim"));
            Assert.That(fizzBuzz235.Calculate(3 * 3 * 5), Is.EqualTo("BuzzBim"));
            Assert.That(fizzBuzz235.Calculate(5 * 3 * 5), Is.EqualTo("BuzzBim"));
            Assert.That(fizzBuzz235.Calculate(7 * 3 * 5), Is.EqualTo("BuzzBim"));
        }
        [Test]
        public void fizzBuzz235ReturnsFizzForMultiplesof2ThatAreNotMultOf3_5()
        {
            var fizzBuzz235 = new FizzBuzzCalculator(2, 3, 5);
            Assert.That(fizzBuzz235.Calculate(1 * 2), Is.EqualTo("Fizz"));
            Assert.That(fizzBuzz235.Calculate(2 * 2), Is.EqualTo("Fizz"));
            Assert.That(fizzBuzz235.Calculate(4 * 2), Is.EqualTo("Fizz"));
            Assert.That(fizzBuzz235.Calculate(7 * 2), Is.EqualTo("Fizz"));
        }
        [Test]
        public void fizzBuzz235ReturnsBuzzForMultiplesof3ThatAreNotMultOf2_5()
        {
            var fizzBuzz235 = new FizzBuzzCalculator(2, 3, 5);
            Assert.That(fizzBuzz235.Calculate(1 * 3), Is.EqualTo("Buzz"));
            Assert.That(fizzBuzz235.Calculate(3 * 3), Is.EqualTo("Buzz"));
            Assert.That(fizzBuzz235.Calculate(7 * 3), Is.EqualTo("Buzz"));
            Assert.That(fizzBuzz235.Calculate(9 * 3), Is.EqualTo("Buzz"));
        }
        [Test]
        public void fizzBuzz235ReturnsBimForMultiplesof5ThatAreNotMultOf2_3()
        {
            var fizzBuzz235 = new FizzBuzzCalculator(2, 3, 5);
            Assert.That(fizzBuzz235.Calculate(1 * 5), Is.EqualTo("Bim"));
            Assert.That(fizzBuzz235.Calculate(5 * 5), Is.EqualTo("Bim"));
            Assert.That(fizzBuzz235.Calculate(7 * 5), Is.EqualTo("Bim"));
            Assert.That(fizzBuzz235.Calculate(11 * 5), Is.EqualTo("Bim"));
        }
    }
}
