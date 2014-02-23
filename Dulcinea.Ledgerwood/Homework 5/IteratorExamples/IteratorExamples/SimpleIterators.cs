using System;
using System.Collections.Generic;
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
            int length;
            if ((input.Length % 2) == 0)
            {
                length = (input.Length / 2);
            }
            else
            {
                length = ((input.Length + 1) / 2);
            }

            string[] result = new string[length];
            int count = 0;
            for (int i = 0; i < result.Length; i++)
            {
                result[i] = input[count];
                count += 2;
            }
            return result;
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
            int length = (max - min) + 1;
            int[] result = new int[length];
            for (int i = 0; i < length; i++)
            {
                result[i] = min + i;
            }
            return result;
        }

        public int[] CountFromToByWithForLoop(int p0, int p1, int p2)
        {
            int length = ((p1 - p0) / p2) +1; 
            int[] result = new int[length];
            
            for (int i = 0; i < length; i++)
            {
                result[i] = (p0 += p2) - p2;
            }
            return result;
        }

        public int[] CountFromToByWithWhileLoop(int p0, int p1, int p2)
        {
            int length = ((p1 - p0) / p2) + 1;
            int[] result = new int[length];
            int count = 0;

            do
            {
                result[count] = (p0 += p2) - p2;
                count += 1;

            } while (count < length);

            return result;
        }

        public int[] BackFromBy(int from, int by)
        {
            int length = (from / by) + 1;
            int[] result = new int[length];

            for (int i = 0; i < length; i++)
            {
                result[i] = (from -= by) + by;

            }
            return result;
        }
    }
}
