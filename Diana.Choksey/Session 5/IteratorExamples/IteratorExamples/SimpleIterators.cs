using System;
using System.Collections.Generic;
using System.IO;
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


        //expected 1, 2, 3, 4, 5, 6, 7
        // int max = 7
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

        //expected2 = { 2, 3, 4 }
        // min 2, max 4
        public int[] CountFromToWithForLoop(int min, int max)
        {
            int length = max - min + 1;
            int[] result = new int[length];
            int i = 0;
            for (int currentValue = min; currentValue <= max; currentValue++)
            {
                result[i++] = currentValue;
            }

            return result;

        }


        //                                       (min = 4, max= 12, incrementBy= 2)
        // EXPECTED:  = { 4, 6, 8, 10, 12 }
        public int[] CountFromToByWithForLoop(int min, int max, int incrementBy)
        {
            int length = ((max - min)/incrementBy) + 1;
            int[] result = new int[length];
            int i = 0;

            for (int currentValue = min; currentValue <= max; currentValue += incrementBy)
            {
                result[i++]=currentValue;
            }

            return result;
        }
        // expected 3, 5,7,9
        //arguments From 3, Max 10, increment 2
        public int[] CountFromToByWithWhileLoop(int min, int max, int incrementBy)
        {
            int length = ((max - min)/incrementBy) + 1; 
            int currentValue = min;

            int[] result = new int[length];
            int i = 0;
            while (currentValue <= max)
            {
                result[i] = currentValue;
                i = i + 1;                
                currentValue = currentValue + incrementBy;
            }
            return result; 

        }

        //expected = { 100, 93, 86, 79, 72, 65, 58, 51, 44, 37, 30, 23, 16, 9, 2 }
        // 100, 7



        public int[] BackFromBy(int max, int decrementBy)
        {
            int lenght = (max/decrementBy) + 1;
            int[] result = new int[lenght];
            int i = 0;

            for (int currentValue = max; currentValue > 0; currentValue -= decrementBy)
            {
                result[i++] = currentValue;
            }

            return result;

        }
    }
}
