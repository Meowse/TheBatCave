using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountFrom100by7
{
    internal class Program
    {
        private static void Main()
        {
//Expected: 100, 93, 86 … 0
//
//Actual: 93, 86, 79 … 0, -5
//
//Error type: “off-by-one error”, aka “fencepost error”
//
//numbers between 15 and 13
//
//x - y + 1

            for (int i = 100; i > 0; i = i-7)
            {

                Console.WriteLine(i);

            }
            Console.WriteLine(0);
            Console.ReadLine();

        }
    }
}