using System;

namespace FizzBuzz
{
    class FizzBuzz
    {
        public string[] Count(int max)
        {
            int min = 1;
            int length = (max / min) + 1;

            string[] result = new string[length];
            for (int i = 0; i < length; i++)
            {
                result[i] = Convert.ToString((i + 1) - 1);

                if (i % 3 == 0)
                {
                    result[i] = "Fizz";
                }
                if (i % 5 == 0)
                {
                    result[i] = "Buzz";
                }
                if (i % 3 == 0 && i % 5 == 0)
                {
                    result[i] = "FizzBuzz";
                }
                if (i == 0)
                {
                    result[i] = "0";
                }
            }
            return result;
        }

    }
}
