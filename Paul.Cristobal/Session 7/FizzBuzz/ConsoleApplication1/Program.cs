using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz

{
    internal class Program
    {
        private static void Main()
        {
            for (int i = 0; i < 100; i++)
            {

                if (i %3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                if (i %5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                if (i %3 == 0 && i %5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                if (i %3 != 0 && i %5 != 0)
                {
                     Console.WriteLine(i);
                }
              
            }
        }
    }
}