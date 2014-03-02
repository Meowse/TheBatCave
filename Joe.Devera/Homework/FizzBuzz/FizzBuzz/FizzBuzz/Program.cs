using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class Program
    {
        private static void Main(string[] args)
        {

            string fizz = "fizz";
            string buzz = "buzz";

            for (int i = 100; i > 0; i--)
            {
                if (i%3 == 0)
                {
                    Console.WriteLine(fizz);
                }
                else if (i%5 == 0)
                {
                    Console.WriteLine(buzz);
                }
                else if ((i%3 == 0) && (i%5 == 0))
                {
                    Console.WriteLine(fizz+buzz);
                }
                else
                {
                    Console.WriteLine(i); 
                }          
            }
        }
    }
}
