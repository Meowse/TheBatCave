using System;
using System.Collections.Generic;
using System.ComponentModel;
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

        public int[] CountFromToWithForLoop(int countFrom, int countTo)
        {
            int length = countTo - countFrom + 1;
            int[] result = new int[length];
            for (int i = 0; i < length; i++)
            {
                result[i] = countFrom + i;
            }
            return result;
            //return new[] { 3, 4, 5, 6, 7 };
        }


        public int[] CountFromToByWithForLoop(int countFrom, int countTo, int countBy)
        {
            int countValue = countFrom;

            int length = GetLengthForArray(countFrom, countTo, countBy);

            int[] result = new int[length];
            for (int i = 0; i < length; i++)
            {
                result[i] = countValue;
                countValue += countBy;
            }
            return result;
        }

        private static int GetLengthForArray(int countFrom, int countTo, int countBy)
        {
            int length;
            if (countFrom == 0)
            {
                length = (countTo/countBy) + 1;
            }
            else if (countTo%countBy == 0)
            {
                length = (countTo/countBy) - 1;
            }
            else
            {
                length = (countTo/countBy);
            }
            return length;
        }


        public int[] CountFromToByWithWhileLoop(int countFrom, int countTo, int countBy)
        {
            int countValue = countFrom;

            int length = GetLengthForArray(countFrom, countTo, countBy);

            int[] result = new int[length];
            int i = 0;
            while (i < length)
            {
                result[i] = countValue;
                countValue += countBy;
                i++;
            }
            return result;
        }

        public int[] BackFromBy(int countFrom, int countBy)
        {
            int countValue = countFrom;

            int length = (countFrom/countBy) + 1;

            int[] result = new int[length];
            for (int i = 0; i < length; i++)
            {
                result[i] = countValue;
                countValue -= countBy;
            }
            return result;
        }
    }
}
