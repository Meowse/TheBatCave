using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzBim
{
    public class Class1
    {

        public string FizzBuzzBim(int input, int input5, int input3, int input2, string result)
        {

            for (int input = 0; input < 101; input++)
            {
                if ((input % input5 == 0) && (input % input3 == 0) && (input % input2 == 0))
                {
                    result = "FizzBuzzBim";
                }
                else if ((input % input5 == 0) && (input % input3 == 0))
                {
                    result = "BuzzBim";
                }
                else if ((input % input2 == 0) && (input % input5 == 0))
                {
                    result = "FizzBim";
                }
                else if ((input % input2 == 0) && (input % input3 == 0))
                {
                    result = "FizzBuzz";
                }
                else if ((input % input5 == 0))
                {
                    result = "Bim";
                }
                else if ((input % input3 == 0))
                {
                    result = "Buzz";
                }
                else if ((input % input2 == 0))
                {
                    result = "Fizz";
                }
                else
                {
                    result = input.ToString();
                }

                
            }

            //return result[i];

        }



        

    }

}
