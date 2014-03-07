using System;

namespace FizzBuzz
{
    public class FizzBuzzCalculator
    {
        public string Calculate(int i)
        {
            if (i == 3)
            {
                return "Fizz";
            }
            return i.ToString();
        }
    }
}