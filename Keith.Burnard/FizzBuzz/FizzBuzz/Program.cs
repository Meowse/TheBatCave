using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            FizzBuzzCounter _fizzBuzzCounter = new FizzBuzzCounter();

            string[] lastValue = _fizzBuzzCounter.Counter(2);

            Console.WriteLine("\nHit any key to continue");
            Console.ReadLine();
        }
    }
}
