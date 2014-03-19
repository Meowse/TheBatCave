using System;

namespace FizzBuzz_2
{
    public class FizzBuzzCalculator
    {
        private int _fizzDiv;
        private int _buzzDiv;
        private int _bimDiv;

        public FizzBuzzCalculator() : this(2, 3, 5)
        {
        }
        
        public FizzBuzzCalculator(int fizzDiv, int buzzDiv, int bimDiv)
        {
            _fizzDiv = fizzDiv;
            _buzzDiv = buzzDiv;
            _bimDiv = bimDiv;
        }

        public string Calculate(int i)
        {
            if (i % _fizzDiv == 0 && i % _buzzDiv == 0 && i % _bimDiv == 0)
            {
                return "FizzBuzzBim";
            }
            if (i % _fizzDiv == 0 && i % _buzzDiv == 0)
            {
                return "FizzBuzz";
            }
            if (i % _fizzDiv == 0 && i % _bimDiv == 0)
            {
                return "FizzBim";
            }
            if (i % _buzzDiv == 0 && i % _bimDiv == 0)
            {
                return "BuzzBim";
            }
            if (i % _fizzDiv == 0)
            {
                return "Fizz";
            }
            if (i % _buzzDiv == 0)
            {
                return "Buzz";
            }
            if (i % _bimDiv == 0)
            {
                return "Bim";
            }
            return i.ToString();
        }
    }
}