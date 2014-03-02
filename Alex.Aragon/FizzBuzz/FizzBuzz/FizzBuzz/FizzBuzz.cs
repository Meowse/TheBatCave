using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class FizzBuzz
    {
        public String[] GetNums(int max)
        {
            string[] result = new string[max];
            for (int i = 0; i < result.Length; i++)
            {
                int count = i+1;
                if (count % 3 == 0 && count % 5 == 0)
                {
                    result[i] = "FizzBuzz";
                }
                else if (count % 3 == 0)
                {
                    result[i] = "Fizz";
                }
                else if (count % 5 == 0)
                {
                    result[i] = "Buzz";
                }
                else {
                    result[i] = count.ToString();
                }
            }
            return result;
        }


        public string ConvertStringArrayToString(string[] array)
        {
            //
            // Concatenate all the elements into a StringBuilder.
            //
            StringBuilder builder = new StringBuilder();
            foreach (string value in array)
            {
                builder.Append(value);
                builder.Append(Environment.NewLine);
            }
            return builder.ToString();
        }
    }
}
