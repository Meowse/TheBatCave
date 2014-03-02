﻿using System;
using System.Text;

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

        static string ConvertStringArrayToString(string[] array)
        {
            //
            // Concatenate all the elements into a StringBuilder.
            //
            StringBuilder builder = new StringBuilder();
            foreach (string value in array)
            {
                builder.Append(value);
                builder.Append('.');
            }
            return builder.ToString();
        }

    }
}
