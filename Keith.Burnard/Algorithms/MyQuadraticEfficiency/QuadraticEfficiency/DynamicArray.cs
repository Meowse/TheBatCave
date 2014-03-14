using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuadraticEfficiency
{
    class DynamicArray
    {
        private int[] array;
        int indexPointer;

        public DynamicArray()
        {
            array = new int[4];
            indexPointer = -1; // -1 means the array is empty
        }
        public DynamicArray(int capacity)
        {
            array = new int[capacity];
            indexPointer = -1;
        }
        public int this[int index] // Indexer
        {
            get 
            {
                if (index >= 0 && index <= indexPointer)
                    return array[index];
                else
                {
                    throw new IndexOutOfRangeException();
                }
            }            
        }
        public int Count
        {
            get
            {
                return indexPointer + 1;
            }
        }

        public void Add(int n)
        {
            if (indexPointer < array.Length - 1)
            {
                indexPointer++;
                array[indexPointer] = n;
            }
            else
            {
                int[] tempArray = new int[array.Length * 2];
                for (int i = 0; i < array.Length; i++)
                {
                    tempArray[i] = array[i];
                }
                array = tempArray;
                indexPointer++;
                array[indexPointer] = n;
            }
        }

    }
}
