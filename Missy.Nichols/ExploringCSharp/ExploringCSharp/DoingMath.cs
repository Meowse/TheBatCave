﻿using System;

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

            return Math.Abs(number1) > Math.Abs(number2) ? number1 : number2;
        }

        public double MultiplyByTheNextLargerPowerOfTen(int number)
        {
            // Try googling "C# exponents and logarithms".  Or just "exponents and logarithms",
            // if college math was too long ago for you (I had to look it up the last time I needed
            // to do this, so don't feel bad if you do, too).

//            if (number%10 == 0)
//            {
//                return (int) Math.Pow(number, 2);
//            }
//            else
//           {
//                if (Math.Round(Math.Log10(number)) == 1)
//                {
//                    return number*10;
//                }
//                if (Math.Round(Math.Log10(number)) == 2)
//                {
//                    return number*100;
//                }
//                if (Math.Round(Math.Log10(number)) == 3)
  //              {
//                    return number*1000;
//                }
//            }
            return Math.Round(Math.Log10(number));
        }
    }
}
