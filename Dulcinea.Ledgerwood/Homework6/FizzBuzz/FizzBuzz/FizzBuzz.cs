using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FizzBuzz
{
    public class FizzBuzz
    {
        public string[] fizzBuzzCount(int max)
        {
            string[] result = new string[max];

            for (int i = 0; i < max; i++)
            {
                string fizzBuzz = string.Empty;

                if ((i%3 != 0) && (i%5 != 0))
                {
                    result[i] = i.ToString();

                }
                else
                {
                    if (i%3 == 0)
                    {
                        fizzBuzz = "Fizz";
                    }
                    if (i%5 == 0)
                    {
                        fizzBuzz += "Buzz";
                    }
                    result[i] = fizzBuzz;
                }
            }
            return result;
        }
    }
}
