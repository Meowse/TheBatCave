using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    public class FizzBuzzBimCalculator
    {
        private readonly int _fizzDivisor;
        private readonly int _buzzDivisor;
        private readonly int _bimDivisor;

        public FizzBuzzBimCalculator(): this(2, 3, 5)
        {
        }

        public FizzBuzzBimCalculator(int fizzDivisor, int buzzDivisor, int bimDivisor)
        {
            _fizzDivisor = fizzDivisor;
            _buzzDivisor = buzzDivisor;
            _bimDivisor = bimDivisor;
        }

        public string Calculate(int i)
        {
            var result = "";
            //if (i % _fizzDivisor == 0 && i % _buzzDivisor == 0)
           // {
             //   result += "FizzBuzz";
            //}
            if (i % _fizzDivisor == 0)
            {
                result += "Fizz";
            }
            if (i % _buzzDivisor == 0)
            {
                result += "Buzz";
            }
            if (i % _bimDivisor == 0)
            {
                result +="Bim";
            }
            if(result == "")
            {
                result = i.ToString();
            }
            return result;
        }
    }
}