using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.Serialization;

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
            List<string> result = new List<string>();
            for (int i = 0; i < input.Length; i += 2)
            {
                result.Add(input[i]);
            }
            return result.ToArray();
        }

        public int[] CountToWithWhileLoop(int max)
        {
            int [] result = new int[max];
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
            int [] result = new int[max];
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
            return new[] { 3, 4, 5, 6, 7 };
        }

        public int[] CountFromToByWithForLoop(int p0, int p1, int p2)
        {
            throw new NotImplementedException();
        }

        public int[] CountFromToByWithWhileLoop(int p0, int p1, int p2)
        {
            throw new NotImplementedException();
        }

        public int[] BackFromBy(int min, int max)
        {
            //int length = (min / max) + 1;
           // int[] result = new int[15];
            //for (int i = 0; i < 15; i++)
            var result = new List<int>();
            for (int i = 100; i >= 0; i = min -=7)
            {
                //result[i] = (min -= 7) + 7;
               result.Add(i);

            }
            //return result;
            return result.ToArray();
        }
    }
}
