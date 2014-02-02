using System;

namespace ExploringCSharp
{
    public class DoingMath
    {
        public int ReturnTheLargerNumber(int number1, int number2)
        {
            // Type "Math.", and look at the various mathematical functions that are defined for you.
            // Notice that you'll have to say "using System.Math" at the top, or type "System.Math.",
            // in order to see it.
            // Notice also that ReSharper is *too* helpful, here, and keeps trying to turn "Math." into 
            // "DoingMath.".  Play with it until you figure out how to type "Math." without ReSharper
            // changing it into "DoingMath." on you.
           return Math.Max(number1, number2);
        }

        public int GetBiggestMagnitude(int number1, int number2)
        {
            // Try googling "C# absolute value of a number"
            var bigger = Math.Max(Math.Abs(number1), Math.Abs(number2));
            return bigger == Math.Abs(number1) ? number1 : number2;
        }

        public int MultiplyByTheNextLargerPowerOfTen(int number)
        {
            // Try googling "C# exponents and logarithms".  Or just "exponents and logarithms",
            // if college math was too long ago for you (I had to look it up the last time I needed
            // to do this, so don't feel bad if you do, too).


            var scale = (Math.Pow(10, (int)Math.Log10(number)))*10;
            return number != 1 ? ((scale/10) == number ? number*number : (int) (number*scale)) : number;


//
//
//                   [Test]
//        public void ShouldMultiplyNumbersByTheirPowerOfTen()
//        {
//            Assert.That(_doingMath.MultiplyByTheNextLargerPowerOfTen(9), Is.EqualTo(90));
//            Assert.That(_doingMath.MultiplyByTheNextLargerPowerOfTen(88), Is.EqualTo(8800));
//            Assert.That(_doingMath.MultiplyByTheNextLargerPowerOfTen(101), Is.EqualTo(101000));
//        }
//
//        [Test]
//        public void ShouldMultiplyPowersOfTenByThemselves()
//        {
//            Assert.That(_doingMath.MultiplyByTheNextLargerPowerOfTen(10), Is.EqualTo(100));
//            Assert.That(_doingMath.MultiplyByTheNextLargerPowerOfTen(100), Is.EqualTo(10000));
//            Assert.That(_doingMath.MultiplyByTheNextLargerPowerOfTen(1000), Is.EqualTo(1000000));
//        }
//
//        [Test]
//        public void OneShouldReturnOneSinceOneIsTheNextLargerPowerOfTen()
//        {
//            Assert.That(_doingMath.MultiplyByTheNextLargerPowerOfTen(1), Is.EqualTo(1));
//        }
        }
    }
}
