using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class FizzBuzzCounter
    {
        public string[] Counter(int countTo)
        {
            string[] result = new string[countTo + 1];

            for (int i = 0; i <= countTo; i++)
            {
                if (i == 0)
                {
                    result[i] = "";
                }
                else if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                    result[i] = "FizzBuzz";
                }

                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                    result[i] = "Fizz";
                }

                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                    result[i] = "Buzz";
                }

                else
                {
                    Console.WriteLine(i.ToString());
                    result[i] = i.ToString();
                }
            }

            return result;
        }
    }
}
