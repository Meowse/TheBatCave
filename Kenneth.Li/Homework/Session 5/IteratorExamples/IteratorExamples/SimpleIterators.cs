using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace IteratorExamples
{
    public class SimpleIterators
    {
        public int[] CountToTen()
        {
            return new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        }

        // TODO: Re-implement this using only string arrays.
        public string[] EveryOtherElement(string[] input)
        {
            int length = 0;
            int oddLengths = ((input.Length)/2) +1;
            int evenLengths = ((input.Length)/2);

            if ((input.Length %2) == 0)
            {
                length = evenLengths;
            }
            if ((input.Length % 2) == 1)
            {
                length = oddLengths;
            }

            string[] result = new string[length];
            for (int i = 0, j = 0; i < length; i++, j+=2 )
            {
                result[i] = input[j];
            }
            return result;
//            List<string> result = new List<string>();
//            for (int i = 0; i < input.Length; i += 2)
//            {
//                result.Add(input[i]);
//            }
//            return result.ToArray();
        }

        public int[] CountToWithWhileLoop(int max)
        {
            int[] result = new int[max];
            int i = 0;
            while (i < max)
            {
                result[i] = i + 1;
                i = i + 1;
            }
            return result;
        }

        public int[] CountToWithForLoop(int max)
        {
            int[] result = new int[max];
            //for (int i = 0; i < max; i = i + 1)
            //for (int i = 0; i < max; i += 1)
            for (int i = 0; i < max; i++)
            {
                result[i] = i + 1;
            }
            return result;
        }

        public int[] CountFromToWithWhileLoop(int min, int max)
        {
            int length = max - min + 1;
            int[] result = new int[length];
            int i = 0;
            while (i < length)
            {
                result[i] = min + i;
                i = i + 1;
            }
            return result;
        }

        public int[] CountFromToWithForLoop(int min, int max)
        {
            int length = max - min + 1;
            int[] result = new int[length];
            for (int i = 0; i < length; i++)
            {
                result[i] = (min += 1) - 1;
            }
            return result;
            //return new[] { 3, 4, 5, 6, 7 };
        }

        public int[] CountFromToByWithForLoop(int min, int max, int increment)
        {
            int length = ((max - min) / increment) + 1;
            int[] result = new int[length];
            for (int i = 0; i < length; i++)
            {
                result[i] = (min += increment) - increment;
            }
            return result;;
        }

        public int[] CountFromToByWithWhileLoop(int min, int max, int increment)
        {
            int length = ((max - min) / increment) + 1;
            int[] result = new int[length];
            int i = 0;
            while (i < length)
            {
                result[i] = (min += increment) - increment;
                i = i + 1;
            }
            return result;
        }

        public int[] BackFromBy(int max, int min)
        {
            int length = (max/min)+1;
            int[] result = new int[length];
            for (int i = 0; i < length; i++)
            {
                result[i] = (max-=min)+min;
            }
            return result;
        }
    }
}
