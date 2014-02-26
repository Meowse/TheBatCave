using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Counting
{
    class FizzBuzz
    {
        public string[] Count(int min, int max)
        {
            int length = (max-min)+1;

            string[] result = new string[length];
            for (int i = 0; i < length; i++)
            {
                if (i%3 != 0 && i%5 != 0)
                {
                    result[i] = Convert.ToString(min+=1);
                }
                if (i%3 == 0)
                {
                    result[i] = "Fizz";
                }
                if (i%5 == 0)
                {
                    result[i] = "Buzz";
                }
                if (i%3 == 0 && i%5 == 0)
                {
                    result[i] = "FizzBuzz";
                }
            }
            return result;
        }

    }
}
