﻿using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace IteratorExamples
{
    public class SimpleIterators
    {
        public int[] CountToTen()
        {
            return new[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
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
                result[i] = min + i;
            }
            //return new[] { 3, 4, 5, 6, 7 };
            return result;
        }

        public int[] CountFromToByWithForLoop(int p0, int p1, int p2)
        {
            //throw new NotImplementedException();
            int countValue = p0;
            int length = GetLengthForArray(p0, p1, p2);

            int[] result = new int[length];
            for (int i = 0; i < length; i++)
            {
                result[i] = countValue;
                countValue += p2;
            }
            return result;
        }

        private static int GetLengthForArray(int p0, int p1, int p2)
        {
            int length;
            if (p0 == 0)
            {
                length = (p1/p2) + 1;
            }
            else if (p1%p2 == 0)
            {
                length = (p1/p2) - 1;
            }
            else
            {
                length = (p1/p2);
            }
            return length;
        }

        public int[] CountFromToByWithWhileLoop(int p0, int p1, int p2)
        {
            int countvalue = p0;
            int length = GetLengthForArray(p0, p1, p2);

            int[] result = new int[length];
            int i = 0;
            while (i < length)
            {
                result[i] = countvalue;
                countvalue += p2;
                i++;
            }
            return result;
        }

        public int[] BackFromBy(int p, int p1)
        {
            int countvalue = p;

            int length = (p/p1) + 1;

            int[] result = new int[length];
            for (int i = 0; i < length; i++)
            {
                result[i] = countvalue;
                countvalue -= p1;
            }
            return result;
        }
    }
}
