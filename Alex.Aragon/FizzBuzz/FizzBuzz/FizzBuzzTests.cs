using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IteratorExamples;
using NUnit.Framework;

namespace FizzBuzz
{
    [TestFixture]
    public class FizzBuzzTests
    {
        private static readonly SimpleIterators SimpleIterators = new SimpleIterators();

        [Test]
        public void CountThree()
        {
            String[] expected = { "1", "2", "3fizz" };
            Assert.That(SimpleIterators.CountThree(), Is.EqualTo(expected));
        }

       


    }
}
