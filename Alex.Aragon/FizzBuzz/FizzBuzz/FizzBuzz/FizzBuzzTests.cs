using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;


namespace FizzBuzz
{
    [TestFixture]
    public class FizzBuzzTests
    {
        private static readonly Form1 Test = new Form1();

        [Test]
        public void CountThree()
        {
            String[] expected = {"1", "2", "3fizz"};
            Assert.That(Test.FizzBuzz(), Is.EqualTo(expected));
        }

       


    }
}
