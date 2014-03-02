using System;
using System.Collections.Generic;
using System.Runtime.Remoting.Messaging;
using System.Runtime.Serialization;

namespace FizzBuzz
{
    public class FizzBuzzCompiler
    {
        public static string FizzBuzzed(string answer)
        {
            string ans1 = "Fizz";
            string ans2 = "Buzz";
            string ans3 = "FizzBuzz";
            int num1 = 0;

            while (num1 <= 15)
            {
                string result = null;
                num1 = num1 + 1;

                if (num1 % 5 == 0 && num1 % 3 == 0)
                {
                    result = ans3;
                    return result;
                }
                if (num1 % 3 == 0)
                {
                    result = ans1;
                    return result;
                }
                if (num1 % 5 == 0)
                {
                    result = ans2;
                    return result;
                }
            }
            answer = "Done";
            return answer;
        }
    }
}