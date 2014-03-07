namespace FizzBuzz
{
    public class FizzBuzzCalculator
    {
        private readonly int _fizzDivisor;
        private readonly int _buzzDivisor;

        public FizzBuzzCalculator() : this(3, 5)
        {
        }

        public FizzBuzzCalculator(int fizzDivisor, int buzzDivisor)
        {
            _fizzDivisor = fizzDivisor;
            _buzzDivisor = buzzDivisor;
        }

        public string Calculate(int i)
        {
            if (i % _fizzDivisor == 0 && i % _buzzDivisor == 0)
            {
                return "FizzBuzz";
            }
            if (i % _fizzDivisor == 0)
            {
                return "Fizz";
            }
            if (i % _buzzDivisor == 0)
            {
                return "Buzz";
            }
            return i.ToString();
        }
    }
}