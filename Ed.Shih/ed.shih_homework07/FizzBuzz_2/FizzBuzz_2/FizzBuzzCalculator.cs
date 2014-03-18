using System;

namespace FizzBuzz_2
{
    public class FizzBuzzCalculator
    {
        private int _fizzDiv;
        private int _buzzDiv;

        public FizzBuzzCalculator() : this(3, 5)
        {
        }
        
        public FizzBuzzCalculator(int fizzDiv, int buzzDiv)
        {
            _fizzDiv = fizzDiv;
            _buzzDiv = buzzDiv;
        }

        public string Calculate(int i)
        {
            if (i % _fizzDiv == 0 && i % _buzzDiv == 0)
            {
                return "FizzBuzz";
            }
            if (i % _fizzDiv == 0)
            {
                return "Fizz";
            }
            if (i % _buzzDiv == 0)
            {
                return "Buzz";
            }
            return i.ToString();
        }
    }
}