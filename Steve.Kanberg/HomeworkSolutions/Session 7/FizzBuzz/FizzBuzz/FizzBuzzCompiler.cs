using System;
using System.Collections.Generic;
using System.Runtime.Remoting.Messaging;
using System.Runtime.Serialization;

namespace FizzBuzz
{
    public class FizzBuzzCompiler
    {
        public static string[] FizzBuzzed(int CountUp)
        {
            int incrementor = 0;
            var length = CountUp;
            string[] result = new string[length];
            int num1 = 1;

            while (num1 <= 15)
            {
                if (num1 % 5 == 0 && num1 % 3 == 0)
                {
                    result[incrementor] = "FizzBuzz";
                    num1++;
                    incrementor++;
                }
                if (num1 % 3 == 0)
                {
                    result[incrementor] = "Fizz";
                    num1++;
                    incrementor++;
                }
                if (num1 %5 == 0)
                {
                    result[incrementor] = "Buzz";
                    num1++;
                    incrementor++;
                }
                else
                {
                    result[incrementor] = num1.ToString();
                    incrementor++;
                    num1++;
                }
            }
            return result;
        }
    }
}