using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fizz_Buzz
{
    internal class Program
    {
        private static void Main(string[] args)
        {
//i. FizzBuzz: print out the numbers from 1 to N, one per line. BUT:
//ii. If a number is divisible by 3, print out “Fizz” instead of the number. AND:
//iii. If a number is divisible by 5, print out “Buzz” instead of the number. 
//EXCEPT:
//iv. If a number is divisible by both 3 and 5, print out “FizzBuzz” instead of the number.
//
//v. And -- create a brand new Visual Studio solution, including a separate project to hold your tests.

            FizzBuzzCalc fizzBuzzCalc = new FizzBuzzCalc();


            Console.WriteLine("Enter an integer:");
            int myNumber = Convert.ToInt16(Console.ReadLine());

            for (int i = 1; i <= myNumber; i++)
            {
                Console.WriteLine(fizzBuzzCalc.Calc(i));
            }
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey(true);



        }


        






    }
}


   

