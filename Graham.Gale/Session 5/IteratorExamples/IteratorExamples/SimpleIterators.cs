using System;
using System.Collections.Generic;
using System.Diagnostics;
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
            // return new[] { 3, 4, 5, 6, 7 };           
            int [] result = new int[max-min+1];
            int counter = min;
            for (int i = 0; counter <= max; i++)
            {
                result[i] = counter;
                counter = counter + 1;
            }
            return result;


        }

        public int[] CountFromToByWithForLoop(int p0, int p1, int p2)
        {
            //throw new NotImplementedException();
            // return new[] { 3, 4, 5, 6, 7 };     
            int arraySize = ((p1 - p0)/p2) + 1;
            int[] result = new int[arraySize];
            int counter = p0;
            int max = p1;
            int with = p2;
            //for (int i = 0; i < max; i = i + 1)
            //for (int i = 0; i < max; i += 1)
            for (int i = 0; counter <= max; i++)
            {
                result[i] = counter;
                counter = counter + with;
            }
            return result;

        }

        public int[] CountFromToByWithWhileLoop(int p0, int p1, int p2)
        {
            //throw new NotImplementedException();
             int arraySize = ((p1 - p0)/p2) + 1;
            int[] result = new int[arraySize];
            int counter = p0;
            int max = p1;
            int with = p2;
            int i = 0;
            while (counter <= max)
            {
                result[i] = counter;
                i = i + 1;
                counter = counter + with;
            }
            return result;
        }

        public int[] BackFromBy(int i, int i1)
        {
          //  throw new NotImplementedException();
            int arraySize = (i/i1) + 1;
            int[] result = new int[arraySize];
            int counter = i;
            int by = i1;
            for (int index = 0; index < arraySize; index++)
            {
                result[index] = counter;
                counter = counter - by;
            }
            return result;
        }
    }
}
