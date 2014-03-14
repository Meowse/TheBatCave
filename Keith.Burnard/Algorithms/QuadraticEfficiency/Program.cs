using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace QuadraticEfficiency
{
    class Program
    {
        static Random rand = new Random();

        static void Main(string[] args)
        {
            int[,] numbers = new int[1000, 1000];
            //create a stopwatch
            Stopwatch sw = new Stopwatch();
            //start the stopwatch
            sw.Start();
            //initialize the array
            Initialize(numbers);
            //stop the stopwatch
            sw.Stop();
            //display time it took for the initialize to run
            Console.WriteLine("\nTime elapsed: {0}", sw.Elapsed);

            //get the min and max values
            int minvalue = Min(numbers);
            int maxvalue = Max(numbers);
            Console.WriteLine("\nMax = {0}  Min = {1}", minvalue, maxvalue);
            
            //===================================================
            DynamicArray da = new DynamicArray(4);
            da.Add(1);
            da.Add(2);
            da.Add(3);
            da.Add(4);
            da.Add(5);
            da.Add(1);
            da.Add(2);
            da.Add(3);
            da.Add(4);
            da.Add(5);
            Console.WriteLine("\n\nDisplaying content of Dynamic Array\n");
            for (int i = 0; i < da.Count; i++)
            {
                Console.WriteLine(da[i]);
            }
            //pause
            Console.ReadLine();

        }
        //method that populates a two-dim array
        static void Initialize(int[,] array)
        {
            //get number of rows
            int n = array.GetLength(0);
            //get number of columns
            int m = array.GetLength(1);

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    array[i, j] = rand.Next();
                }
            }
        }
        //method to return the max value of an array
        static int Max(int[,] array)
        {
            //get number of rows
            int n = array.GetLength(0);
            //get number of columns
            int m = array.GetLength(1);
            //initialize the maxvalue to the first element (or any element)
            int maxvalue = array[0, 0];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (array[i, j] > maxvalue)
                        maxvalue = array[i, j];
                    
                }
            }
            //return it
            return maxvalue;
        }

        //method to return the min value of an array
        static int Min(int[,] array)
        {
            //get number of rows
            int n = array.GetLength(0);
            //get number of columns
            int m = array.GetLength(1);
            //initialize the maxvalue to the first element (or any element)
            int minvalue = array[0, 0];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (array[i, j] < minvalue)
                        minvalue = array[i, j];

                }
            }
            //return it
            return minvalue;
        }
        //method to compute the sum of the diagonal
        static long SumDiag1(int[,] array)
        {
            long sum = 0;
            //get number of rows
            int n = array.GetLength(0);
            for (int i = 0; i < n; i++)
            {
                sum += array[i, i];
            }
            return sum;
        }

        //method to compute the sum of the second diagonal
        static long SumDiag2(int[,] array)
        {
            long sum = 0;
            //get number of rows
            int n = array.GetLength(0);
            for (int i = 0; i < n; i++)
            {
                sum += array[i, n-1-i];
            }
            return sum;
        }
        static float Average(int[,] array)
        {
            //get number of rows
            int n = array.GetLength(0);
            //get number of columns
            int m = array.GetLength(1);
            //initialize the maxvalue to the first element (or any element)
            int maxvalue = array[0, 0];

            float sum = 0;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    sum += array[i, j];
                }
            }
            //return it
            return sum / array.Length;
        }
        static int GetClosestValueToAvg(int[,] array,out int r,out int c)
        {
            //get number of rows
            int n = array.GetLength(0);
            //get number of columns
            int m = array.GetLength(1);
            float avg = Average(array);
            int closestvalue = array[0, 0];
            r = c = 0;
            float d = Math.Abs(avg - array[0, 0]);

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (Math.Abs(avg - array[i, j]) < d)
                    {
                        d = Math.Abs(avg - array[i, j]);
                        closestvalue = array[i, j];
                        r = i;
                        c = j;
                    }
                }
            }
            //return it
            return closestvalue;
        }
    }
}
