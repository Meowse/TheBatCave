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
            return i%_fizzDivisor == 0 && i%_buzzDivisor == 0
                ? "FizzBuzz"
                : (i%_fizzDivisor == 0 ? "Fizz" : (i%_buzzDivisor == 0 ? "Buzz" : i.ToString()));
        }
    }
}