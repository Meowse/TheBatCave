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
            int [,] numbers = new int[1000,1000];

            Stopwatch stopwatch = new Stopwatch();

            stopwatch.Start();
            Initialize(numbers);
            stopwatch.Stop();
            Console.WriteLine("\r\nTime Elapsed: {0}", stopwatch.Elapsed);

            int maxNumber = GetMaxValue(numbers);
            Console.WriteLine("\r\nMax value: {0}", maxNumber);
            int minNumber = GetMinValue(numbers);
            Console.WriteLine("\r\nMax value: {0}", minNumber);

            float averageNumber = GetAverage(numbers);
            Console.WriteLine("\r\nAverage value: {0}", averageNumber.ToString());
            int closestValueToAverageNumber = GetValueClosestToAverage(numbers, averageNumber);
            Console.WriteLine("\r\nClosest value to the average: {0}", closestValueToAverageNumber.ToString());

            DynamicArray dynamicArray = new DynamicArray(4);
            dynamicArray.Add(1);
            dynamicArray.Add(2);
            dynamicArray.Add(3);
            dynamicArray.Add(4);
            dynamicArray.Add(5);
            int arrayValue = dynamicArray[2];
            int arrayCount = dynamicArray.Count;
            for (int i = 0; i < arrayCount; i++)
            {
                Console.WriteLine("\r\nElements in the array {0}", dynamicArray[i].ToString());
            }

            Console.WriteLine("Hit any key to continue");
            Console.ReadLine();

            
        }

        static void Initialize(int[,] array)
        {
            int rows = array.GetLength(0);
            int cols = array.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    array[i, j] = rand.Next();
                }
            }
        }

        static int GetMaxValue(int[,] array)
        {
            int biggestNumber = array[0,0];

            int rows = array.GetLength(0);
            int cols = array.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (array[i, j] > biggestNumber)
                    {
                        biggestNumber = array[i, j];
                    }
                }
            }
            return biggestNumber;
        }
        static int GetMinValue(int[,] array)
        {
            int smallestNumber = array[0, 0];

            int rows = array.GetLength(0);
            int cols = array.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (array[i, j] < smallestNumber)
                    {
                        smallestNumber = array[i, j];
                    }
                }
            }
            return smallestNumber;
        }

        static long GetSumOfTheFirstDiagonal(int[,] array)
        {
            long sum = 0;
            int rows = array.GetLength(0);
            for (int i = 0; i < rows; i++)
            {
                sum += array[i, i];
            }
            return sum;
        }
        static long GetSumOfTheSecondDiagonal(int[,] array)
        {
            long sum = 0;
            int rows = array.GetLength(0);
            for (int i = 0; i < rows; i++)
            {
                sum += array[i, (rows-1)-i];
            }
            return sum;
        }

        static float GetAverage(int[,] array)
        {
            long sum = 0;

            int rows = array.GetLength(0);
            int cols = array.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    sum += array[i, j];
                }
            }
            return sum / array.Length;
        }
        static int GetValueClosestToAverage(int[,] array, float average)
        {
            int closestToAverage = array[0, 0];
            float smallestDifference = Math.Abs(array[0, 0] - average);
            float difference = 0;

            int rows = array.GetLength(0);
            int cols = array.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    difference = Math.Abs(array[i, j] - average);                    
                    if ( difference < smallestDifference)
                    {
                        closestToAverage = array[i, j];
                        smallestDifference = difference;
                    }
                }
            }
            return closestToAverage;
        }
    }
}
