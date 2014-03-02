using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FizzBuzz;
using NUnit.Framework;


namespace FizzBuzz
{
    [TestFixture]
    public class FizzBuzzTests
    {
        private readonly FizzBuzz _fizzbuzz = new FizzBuzz();

        [Test]
        public void CountThree()
        {
            String[] expected = {"1", "2", "Fizz"};
            Assert.That(_fizzbuzz.GetNums(3), Is.EqualTo(expected));
        }

        [Test]
        public void CountTen()
        {
            String[] expected = { "1", "2", "Fizz", "4","Buzz","Fizz","7","8","Fizz","Buzz" };
            Assert.That(_fizzbuzz.GetNums(10), Is.EqualTo(expected));
        }

       


    }
}
