using System;

namespace Project1
{
    class FizzBuzz
    {

        //print out numners from 1 to N, one per line. BUT:
        // if a number is divisible by 3, print "Fizz" instead of a number. AND:
        // if a number is divisible by 5, print "Buzz" instead of a number.
        // EXCEPT:
        // If a number is divisible by both 3 and 5, print out ""FizzBuzz" instead of the number.
        //And create a brand new Visual Studio solution , including a separate 
        // project to hold your tests
        static void Main(string[]args)

        public string FizzyBuzzy(int number)
        {
            string returnString = string.Empty;

            if (number % 3 == 0 )
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
