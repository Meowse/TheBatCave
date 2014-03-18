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
            if (i % _buzzDivisor == 0 && i % _bimDivisor == 0)
            {
                return "BuzzBim";
            }
            if (i%_fizzDivisor == 0 && i%_buzzDivisor == 0)
            {
                return "FizzBuzz";
            }
            if (i % _fizzDivisor == 0 && i % _bimDivisor == 0)
            {
                return "FizzBim";
            }
            if (i % _fizzDivisor == 0)
            {
                return "Fizz";
            }
            if (i % _buzzDivisor == 0)
            {
                return "Buzz";
            }
            if (i % _bimDivisor == 0)
            {
                return "Bim";
            }
            return i.ToString();
        }
    }
}