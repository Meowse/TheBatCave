using System.Collections.Generic;
using NUnit.Framework;


namespace FizzBuzzInfinite
{
    [TestFixture]
    class FizzBuzzInfiniteTest
    {
        readonly FizzBuzzCalculator _fizzBuzzCalculator = new FizzBuzzCalculator();

        [Test]
        public void ThreeFizzFiveBuzzCountToFifteen()
        {
            var listOfFizzBuzzObjects = CreateListOfFizzBuzzObjects();

            string expected = "\r\n1\r\n2\r\nFizz\r\n4\r\nBuzz\r\nFizz\r\n7\r\n8\r\nFizz\r\nBuzz\r\n11\r\nFizz\r\n13\r\n14\r\nFizzBuzz\r\n";
            Assert.That(_fizzBuzzCalculator.Calculate(listOfFizzBuzzObjects,15), Is.EqualTo(expected));
        }

        [Test]
        public void ThreeFizzFiveBuzzTwoBimCountToFifteen()
        {
            var listOfFizzBuzzObjects = CreateListOfFizzBuzzBimObjects();

            string expected = "\r\n1\r\nBim\r\nFizz\r\nBim\r\nBuzz\r\nFizzBim\r\n7\r\nBim\r\nFizz\r\nBuzzBim\r\n11\r\nFizzBim\r\n13\r\nBim\r\nFizzBuzz\r\n";
            Assert.That(_fizzBuzzCalculator.Calculate(listOfFizzBuzzObjects, 15), Is.EqualTo(expected));
        }

        private static List<FizzBuzzObject> CreateListOfFizzBuzzObjects()
        {
            List<FizzBuzzObject> listOfFizzBuzzObjects = new List<FizzBuzzObject>();
            FizzBuzzObject fizzBuzzObjectOne = new FizzBuzzObject { Denominator = 3, Message = "Fizz" };
            FizzBuzzObject fizzBuzzObjectTwo = new FizzBuzzObject { Denominator = 5, Message = "Buzz" };
            listOfFizzBuzzObjects.Add(fizzBuzzObjectOne);
            listOfFizzBuzzObjects.Add(fizzBuzzObjectTwo);
            return listOfFizzBuzzObjects;
        }
        private static List<FizzBuzzObject> CreateListOfFizzBuzzBimObjects()
        {
            List<FizzBuzzObject> listOfFizzBuzzObjects = new List<FizzBuzzObject>();
            FizzBuzzObject fizzBuzzObjectOne = new FizzBuzzObject { Denominator = 3, Message = "Fizz" };
            FizzBuzzObject fizzBuzzObjectTwo = new FizzBuzzObject { Denominator = 5, Message = "Buzz" };
            FizzBuzzObject fizzBuzzObjectThree = new FizzBuzzObject { Denominator = 2, Message = "Bim" };
            listOfFizzBuzzObjects.Add(fizzBuzzObjectOne);
            listOfFizzBuzzObjects.Add(fizzBuzzObjectTwo);
            listOfFizzBuzzObjects.Add(fizzBuzzObjectThree);
            return listOfFizzBuzzObjects;
        }
    }
}
