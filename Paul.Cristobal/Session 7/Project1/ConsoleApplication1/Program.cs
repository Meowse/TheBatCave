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
           string result = FizzyBuzzy(100);
            Console.WriteLine(result);
            Console.ReadLine();
        }
        public static string FizzyBuzzy(int number)
        {
            string returnString = string.Empty;

            if (number % 3 == 0)
            {
                returnString = "Fizz";
            }
            if (number % 5 == 0)
            {
                returnString = "Buzz";
            }
            if (number % 3 == 0 && number % 5 == 0)
            {
                returnString = "FizzBuzz";
            }
            if (number % 3 != 0 && number % 5 != 0)
            {
                returnString = number.ToString();
            }
            return returnString;
        }
    }
}
