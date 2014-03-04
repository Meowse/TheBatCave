using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    public class FizzBuzzApp
    {
        public static void Main(string[] args)
        {

            const string fizz = "fizz";
            const string buzz = "buzz";

            for (int i = 100; i > 0; i--)
            {
                if ((i%3 == 0) && (i%5 == 0))
                {
                    Console.WriteLine(fizz+buzz);
                }
                else if (i%5 == 0)
                {
                    Console.WriteLine(buzz);
                }
                else if (i%3 == 0)
                {
                    Console.WriteLine(fizz);
                }
                else
                {
                    Console.WriteLine(i); 
                }          
            }
        }
    }
}
