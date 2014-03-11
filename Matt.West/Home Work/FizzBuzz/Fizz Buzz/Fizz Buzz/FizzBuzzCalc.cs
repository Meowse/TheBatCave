using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fizz_Buzz
{
    public class FizzBuzzCalc
    {
        public String Calc(int currentI)
        {
            string f = "Fizz";
            string b = "Buzz";
            string stringOut = "";

            if (currentI % 3 == 0 && currentI % 5 == 0)
            {
                stringOut = f + b;
            }
            else
            {
                if (currentI % 3 == 0)
                {
                    stringOut = f;
                }
                else
                {
                    if (currentI % 5 == 0)
                    {
                        stringOut = b;
                    }
                    else stringOut = currentI.ToString();
                }
            }
            return stringOut;

        }


    }
}
