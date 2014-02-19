using System;
using System.Collections.Generic;

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
            int length = max - min + 1;
            int[] result = new int[length];

            for (int i = 0; i < length; i++)
            {
                result[i] = min + i;
            }
            return result;
        }

        public int[] CountFromToByWithForLoop(int min, int max, int iterator)
        {

            int length = ((max - min) / iterator) + 1;
            int[] result = new int[length];

            for (int i = 0; i < length; i++)
            {
                result[i] = min + (i * iterator);
            }
            return result;
        }

        public int[] CountFromToByWithWhileLoop(int min, int max, int iterator)
        {
            int length = ((max - min) / iterator) + 1;
            int[] result = new int[length];
            int i = 0;

            while (i < length)
            {
                result[i] = min + (i * iterator);
                i++;
            }
            return result;

        }

        public int[] BackFromBy(int start, int decrementBy)
        {
	            int length = (start / decrementBy) + 1;
                int[] result = new int[length];

                for (int i = 0; i < length; i++)
	            {
                    result[i] = start - (i * decrementBy);
//	                result[i] = start;
//	                start -= decrementBy;
	            }
	            return result;

        }
    }
}
