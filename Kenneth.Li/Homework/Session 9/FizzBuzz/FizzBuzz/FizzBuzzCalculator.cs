using System.Windows.Forms.VisualStyles;

namespace FizzBuzz
{
    public class FizzBuzzCalculator
    {
        private readonly int _fizzDivisor;
        private readonly int _buzzDivisor;
        private readonly int _bimDivisor;

        public FizzBuzzCalculator() : this(2, 3, 5)
        {
        }

        public FizzBuzzCalculator(int fizzDivisor, int buzzDivisor)
        {
            _fizzDivisor = fizzDivisor;
            _buzzDivisor = buzzDivisor;
        }

        public FizzBuzzCalculator(int fizzDivisor, int buzzDivisor, int bimDivisor)
        {
            _fizzDivisor = fizzDivisor;
            _buzzDivisor = buzzDivisor;
            _bimDivisor = bimDivisor;
        }

        public string Calculate(int i)
        {
            if (i % _fizzDivisor == 0 && i % _buzzDivisor == 0 && i % _bimDivisor == 0)
            {
                return "FizzBuzzBim";
            }
            string calculate;
            if (CheckIfTwoValuesAreMultiples(i, out calculate)) return calculate;
            string fizz;
            if (CheckIfOneValueIsMultiple(i, out fizz)) return fizz;
            return i.ToString();
        }

        private bool CheckIfOneValueIsMultiple(int i, out string fizz)
        {
            if (i%_fizzDivisor == 0)
            {
                {
                    fizz = "Fizz";
                    return true;
                }
            }
            if (i%_buzzDivisor == 0)
            {
                {
                    fizz = "Buzz";
                    return true;
                }
            }
            if (i%_bimDivisor == 0)
            {
                {
                    fizz = "Bim";
                    return true;
                }
            }
            fizz = null;
            return false;
        }

        private bool CheckIfTwoValuesAreMultiples(int i, out string calculate)
        {
            if (i%_fizzDivisor == 0 && i%_buzzDivisor == 0)
            {
                {
                    calculate = "FizzBuzz";
                    return true;
                }
            }
            if (i%_buzzDivisor == 0 && _bimDivisor == 0)
            {
                {
                    calculate = "BuzzBim";
                    return true;
                }
            }
            if (i%_fizzDivisor == 0 && i%_bimDivisor == 0)
            {
                {
                    calculate = "FizzBim";
                    return true;
                }
            }
            calculate = null;
            return false;
        }
    }
}