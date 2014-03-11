using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class FizzBuzzCounter
    {
        public string[] Counter(int countTo, int devisorOne, string stringOne, int devisorTwo, string stringTwo)
        {
            string[] result = new string[countTo + 1];

            for (int i = 0; i <= countTo; i++)
            {
                if (i == 0)
                {
                    result[i] = "";
                }
                else if (i % devisorOne == 0 && i % devisorTwo == 0)
                {
                    Console.WriteLine(stringOne + stringTwo);
                    result[i] = stringOne + stringTwo;
                }

                else if (i % devisorOne == 0)
                {
                    Console.WriteLine(stringOne);
                    result[i] = stringOne;
                }

                else if (i % devisorTwo == 0)
                {
                    Console.WriteLine(stringTwo);
                    result[i] = stringTwo;
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
