using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuadraticEfficiency
{
     public class DynamicArray
    {
         private int[] array;
         int indexpointer; //points to the last element in the array

         //constructors
         //default contructor
         public DynamicArray()
         {
             array = new int[4];
             indexpointer = -1;// -1 indicates array is empty
         }
         public DynamicArray(int capacity)
         {
             array = new int[capacity];
             indexpointer = -1;// -1 indicates array is empty
         }

         //property to return the number of elements in the array
         public int Count
         {
             get
             {
                 return indexpointer + 1;
             }
         }

         //define an index
         public int this[int index]
         {
             get
             {
                 if (index >= 0 && index <= indexpointer)
                 {
                     return array[index];
                 }
                 else
                     throw new IndexOutOfRangeException("Index out of range");
             }

         }

         //method to add an item to the end of the array
         public void Add(int n)
         {
             if (indexpointer < array.Length - 1)
             {
                 //add n to the array
                 indexpointer++;
                 array[indexpointer] = n;
             }
             else
             {
                 //double array//create a new twice as big//
                 //copy array to the new one
                 //reset the reference
                 //add n to it
                 int[] temp = new int[array.Length * 2];
                 for (int i = 0; i < array.Length; i++)
                 {
                     temp[i] = array[i];
                 }
                 array = temp;
                 indexpointer++;
                 array[indexpointer] = n;

                 //
             }
         }
    }
}
