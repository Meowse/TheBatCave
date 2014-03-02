using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.Serialization;


namespace FizzBuzzNs
{
    public class FizzBuzzPc
    {
        public string[] ReturnFizzBuzz(string[] input, int max)
        {
            int arraySize = max;
            List<string> result = new List<string>();
            for (int i = 1; i <= max; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                    result[i] = "FizzBuzz";
                else
                {
                    if (i % 3 == 0)
                        result[i] = "Fizz";
                    else
                        if (i % 5 == 0)
                            result[i] = "Buzz";
                        else
                            result[i] = i.ToString();
                }
            }
            return result.ToArray();
        }

    }
}
