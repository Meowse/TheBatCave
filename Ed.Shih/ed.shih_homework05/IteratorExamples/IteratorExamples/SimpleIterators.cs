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
            // for the first call, min = 3, and max is 7, and I expect 3, 4, 5, 6, 7
            // for the second call, min = 2, and max is 4, and I expect [2, 3, 4]
            int length = max - min + 1;
            int[] result = new int[length];
            for (int i = 0; i < length; i++)
            {
                result[i] = i + min;
            }
            return result;
        }

        public int[] CountFromToByWithForLoop(int low, int high, int step)
        {
            //  changed variable names; fred = low, barney = high, wilma = step
            int length = ((high - low) / step) + 1;
            int[] result = new int[length];
            for (int i = 0; i < length; i++)
            {
                result [i] = low;
                low += step;
            }
            return result;
        }

        public int[] CountFromToByWithWhileLoop(int min, int max, int by)
        {
            // count from whatever value is in "from", to whatever value is in "to",
            // by steps of size "stepSize"

            // count from whatever value is in "min", to whatever value is in "max",
            // by steps of size whatever-value-is-in-"by"

            // So: if someone calls this method with "CountFromToByWithWhileLoop(3, 17, 2)"
            // then "min" (or "from", or "countFrom", whatever we call it) will have the value
            // 3, and "max" (or "to", or "countTo", or whatever we call it) will have the value
            // 17, and "by" (or "step", or "stepSize", or whatever we call it) will have the value
            // 2.  And we'll return [3, 5, 7, 9, 11, 13, 15, 17] as the answer, no matter what
            // we named the variables.
            int length = ((max - min)/by) + 1;
            int[] result = new int[length];
            int i = 0;
            while (i < length)
            {
                result[i] = min + (i*by);
                i = i + 1;
            }
            return result;

        }

        public int[] BackFromBy(int i, int i1)
        {
            throw new NotImplementedException();
        }
    }
}
