﻿using System;
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
            string[] expected =
            {
                "0", "1", "2", "Fizz", "4", "Buzz", "Fizz", "7", "8", "Fizz", "Buzz", "11", "Fizz", "13",
                "14", "FizzBuzz"
            };
            Assert.That(FizzBuzz.Count(15), Is.EqualTo(expected));
        }

        [Test]
        public void MultiplesOf5()
        {
            string[] expected = {"0", "1", "2", "Fizz", "4", "Buzz", "Fizz", "7", "8", "Fizz", "Buzz"};
            Assert.That((FizzBuzz.Count(2*5)), Is.EqualTo(expected));
        }
    }
}
