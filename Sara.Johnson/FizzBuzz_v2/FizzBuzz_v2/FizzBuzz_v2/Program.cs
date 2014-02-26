using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz_v2
{
    internal class FizzBuzz
    {
        private static void Main(string[] args)
        {

            
            string Fizz = "Fizz";
            string Buzz = "Buzz";
            string FizzBuzz = "FizzBuzz";

            for (int i = 1; i < 101; i++)
            {
                if ((i%5 == 0) && (i%3 == 0))
                {
                    Console.WriteLine(FizzBuzz);
                }
                else if (i%3 == 0)
                {
                    Console.WriteLine(Fizz);
                }
                else if (i%5 == 0)
                {
                    Console.WriteLine(Buzz);
                }
                else
                {
                    Console.WriteLine(i.ToString());
                }
                
            }

            

            Console.ReadLine();
        }

    }
}
