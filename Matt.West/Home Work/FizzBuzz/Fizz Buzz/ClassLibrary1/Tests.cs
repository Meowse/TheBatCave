using Fizz_Buzz;
using NUnit.Framework;

namespace ClassLibrary1
{
    public class Tests
    {
         [TestFixture]
	    public class FizzBuzzTests
	    {
             private readonly FizzBuzzCalc _fizzBuzzCalc = new FizzBuzzCalc();

	        [Test]
	        public void TestFizzBuzz()
	        {
                Assert.That(_fizzBuzzCalc.Calc(1), Is.EqualTo("1"));
                Assert.That(_fizzBuzzCalc.Calc(3), Is.EqualTo("Fizz"));
                Assert.That(_fizzBuzzCalc.Calc(5), Is.EqualTo("Buzz"));
                Assert.That(_fizzBuzzCalc.Calc(15), Is.EqualTo("FizzBuzz"));

	        }



	    }
    }
}

