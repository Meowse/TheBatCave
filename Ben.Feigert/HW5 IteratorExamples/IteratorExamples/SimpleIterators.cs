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
           
        }

        public int[] CountFromToByWithForLoop(int min, int max, int countby)
        {
            int[] result = new int[max];
            for (int i = min; i < max; i+=countby)
            {
                result[i] = i + countby;
            }
            return result;
        }

        public int[] CountFromToByWithWhileLoop(int p0, int p1, int p2)
        {
            throw new NotImplementedException();
        }

        public int[] BackFromBy(int max, int increment)
        {
            int length = (max/increment) + 1;
            int [] result = new int[length];
            for (int i=0; i<length; i++ )
            {
                result[i] = (max - increment);
                max = (max - increment);
                
                // dunno
                //and here's where I'm stuck: I don't know how to 
                //return the result of the decremented 'max'. Obviously
                //I need to decrease max by 7 each time, but can't get it to work.
            }
            return result;
        }
    }
}
