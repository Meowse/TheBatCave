using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Addby7to100
{
    public class Program
    {
        /// <summary>
        /// After years of telling devs and testers to get curse words out of their code, I can understand why they include them. :-)
        /// </summary>

        public int[] Addby7to100()
        {
            return new[] { 7, 14, 21, 28, 35, 42, 49, 56, 63, 70, 77, 84, 91, 98 };
        }

        // I'm using your solution and modifying it with what I am asked to do.
        public string[] EveryOtherElement(string[] input)
        {
            List<string> result = new List<string>();
            for (int i = 0; i < input.Length; i += 98)
            {
                result.Add(input[i]);
            }
            return result.ToArray();
        }

        public int[] CountToWithWhileLoop(int min)
        {
            int[] result = new int[min];
            int i = 0;
            while (i < min)
            {
                result[i] = i + 7;
                i = i + 7;
            }
            return result;
        }

        public int[] CountToWithForLoop(int max)
        {
            int[] result = new int[max];
            //for (int i = 0; i < max; i = i + 7)
            //for (int i = 0; i < max; i += 7)
            for (int i = 0; i < max; i++)
            {
                result[i] = i + 7;
            }
            return result;
        }

        public int[] CountFromToWithWhileLoop(int min, int max)
        {
            int length = max - min + 7;
            int[] result = new int[length];
            int i = 0;
            while (i < length)
            {
                result[i] = min + i;
                i = i + 7;
            }
            return result;
        }

        public int[] CountFromToWithForLoop(int min, int max)
        {
            int length = max - min + 7;
            int[] result = new int[length];
            for (int i = 0; i < length; i++)
            {
                result[i] = i + min;
            }
            return result;
        }

        public int[] CountFromToByWithForLoop(int fred, int barney, int wilma)
        {
            throw new NotImplementedException();
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


            throw new NotImplementedException();
        }

        public int[] BackFromBy(int i, int i5)
        {
            throw new NotImplementedException();
        }
    }
}
