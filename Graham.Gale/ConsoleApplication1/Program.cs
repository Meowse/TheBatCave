using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
             int max = 0;
           Console.WriteLine("Enter the max number");
           max = Convert.ToInt32(Console.ReadLine());
           for (int i = 1; i < max; i++)
            {
        if (i % 5 == 0 && i % 3 == 0)
        {
            Console.WriteLine("FizzBuzz");
        }
        else if (i % 5 == 0)
        {
            Console.WriteLine("Buzz");
        }
        else if (i % 3 == 0)
        {
            Console.WriteLine("Fizz");
        } else {
            Console.WriteLine(i);
    }
            }
            Console.ReadLine();

        }
    }
}
