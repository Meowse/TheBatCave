using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FizzBuzz
{
    internal class Program
    {
        
        static void Main(string[]args)
        {
            string fizz = "fizz";
            string buzz = "buzz";
            string fizzbuzz = "fizzbuzz";


             for (int i = 1; i <= 100; i++)
            {
                if (i%3 == 0 && i%5 == 0)
                    Console.WriteLine("FizzBuzz");
            }
            if (int % 3 ==0)
            {
                Console.WriteLine("Fizz");
            }
            else if (int % 5== 0)
            {
                Console.WriteLine("Buzz");
            }
        else
            {
                Console.WriteLine(int.tostring());
            }
        }
    }
}
