using System;
using System.Runtime.Remoting.Messaging;

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
            var absoluteOfNumber1 = Math.Abs(number1);
            var absoluteOfNumber2 = Math.Abs(number2);
            return absoluteOfNumber1 > absoluteOfNumber2 ? number1 : number2;
        }

        public int MultiplyByTheNextLargerPowerOfTen(int number)
        {
            // Try googling "C# exponents and logarithms".  Or just "exponents and logarithms",
            // if college math was too long ago for you (I had to look it up the last time I needed
            // to do this, so don't feel bad if you do, too).
            //double logOfNumber = Math.Log(number);
            var lengthOfNumber = (number.ToString().Length);
            var multiplier = Math.Pow(10, lengthOfNumber);
            if (number == 1)
            {
                multiplier = 1;
            }
            var result = number * multiplier;
            if (multiplier == Math.Pow(10, lengthOfNumber))
            {
                result = Math.Pow(number, 2);
            }
            return (int) result;
        }
    }
}
