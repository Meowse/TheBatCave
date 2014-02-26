using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit;

namespace FizzBuzz
{
    class TestFizzBuzz
    {
        [Test]
        public void CanCountToTen()
        {
            int[] expected = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Assert.That(SimpleIterators.CountToTen(), Is.EqualTo(expected));
        }
    }
}
