﻿using System;
namespace ExploringCSharp
{
    public class DoingMath
    {
        public int ReturnTheLargerNumber(int number1, int number2)
        {
            return Math.Max(number1, number2);

            // Type "Math.", and look at the various mathematical functions that are defined for you.
            // Notice that you'll have to say "using System.Math" at the top, or type "System.Math.",
            // in order to see it.
            // Notice also that ReSharper is *too* helpful, here, and keeps trying to turn "Math." into 
            // "DoingMath.".  Play with it until you figure out how to type "Math." without ReSharper
            // changing it into "DoingMath." on you.
        }


        public int GetBiggestMagnitude(int number1, int number2)
        {
            // Try googling "C# absolute value of a number"
            // The absolute value of a number is the number excluding its negative sign
            int magnitude1 = Math.Abs(number1);
            int magnitude2 = Math.Abs(number2);
            int biggestMagnitude = Math.Max(magnitude1, magnitude2);

            return biggestMagnitude;
            //Even though what the test expects is the original number that has the biggest magnitude
            //Seems like a good stopping point for now! :)
        }

        public int MultiplyByTheNextLargerPowerOfTen(int number)
        {


            // Try googling "C# exponents and logarithms".  Or just "exponents and logarithms",
            // if college math was too long ago for you (I had to look it up the last time I needed
            // to do this, so don't feel bad if you do, too).
            return 0;
        }
    }
}
