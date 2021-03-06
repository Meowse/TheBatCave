﻿using System;
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
            int length = max - min + 1;
            int[] result = new int[length];
            int i = 0;
            
            for (int i2 = min; i2 <= max;i2++)
            {
                result[i] = min + i;
                i++;
            }
            return result;
        }

        public int[] CountFromToByWithForLoop(int p0, int p1, int p2)
        {
            int[] result = new int[((p1 - p0)/p2) + 1];
            int iTemp = 0;
            for(int i=p0;p0<=p1;p0 = p0+p2)
            {
                result[iTemp] = p0;
                iTemp++;
            }
            return result;
        }

        public int[] CountFromToByWithWhileLoop(int p0, int p1, int p2)
        {
            int[] result = new int[((p1 - p0) / p2) + 1];
            int iTemp = 0;
            while(p0<=p1)
            {
                result[iTemp] = p0;
                p0 += p2;

                iTemp++;
            }
            return result;
        }

        public int[] BackFromBy(int i, int i1)
        {
            int[] result = new int[15];
            int it = 0;
            for(int iTemp=i;i>0;i = i-i1)
            {
                result[it] = i;
                it++;
            }
            return result;
        }
    }
}
