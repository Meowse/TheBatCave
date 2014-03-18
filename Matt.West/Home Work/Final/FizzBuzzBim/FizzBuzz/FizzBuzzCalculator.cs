namespace FizzBuzz
{
    public class FizzBuzzCalculator
    {
        private readonly int _fizzDivisor;
        private readonly int _buzzDivisor;
        private readonly int _bimDivisor;

        public FizzBuzzCalculator() : this(3, 5)
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
            if (i % _fizzDivisor == 0 && i % _buzzDivisor == 0)
            {
                return "FizzBuzz";
            }
            if (i % _fizzDivisor == 0 && i % _bimDivisor == 0)
            {
                return "FizzBim";
            }
            if (i % _bimDivisor == 0 && i % _buzzDivisor == 0)
            {
                return "BuzzBim";
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


//Write FizzBuzzBim.
//
//
//Instructions:
//
//We’re going to start with the FizzBuzz implementation from a couple of office hours ago, and add another divisor and another divisibility indicator to it.  Specifically, we’re going to print “Fizz” when a number is divisible by 2, “Buzz” when a number is divisible by 3, and “Bim” when a number is divisible by 5.  And we’re going to print out the combinations of those words when a number is divisible by more than one of the divisors.
//
//Just as FizzBuzz prints out custom messages for numbers divisible by 3, by 5, and by both 3 and 5, so FizzBuzzBim prints out custom messages for numbers divisible by 2, by 3, by 5, by both 2 and 3, by both 3 and 5, by both 2 and 5, and by all of 2, 3, and 5.  Wow, that’s a lot of different possibilities!
//
//So, when you’re writing FizzBuzzBim, try to think of ways to write it that make it a little bit shorter and more manageable.  If you think FizzBuzzBim has a lot of different, possible outputs, imagine what FizzBuzzBimFrodo would look like...and try to write your code in such a way that it wouldn’t get hugely longer each time you add another divisor and another divisibility indicator.
//
//Oh..and, just as with the FizzBuzz implementation from the office hours...make sure you can change the three numbers corresponding to Fizz, Buzz, and Bim.  :-)
//
//Expected output:
//
//1.1
//
//
//2.Fizz
//
//
//3.Buzz
//
//
//4.Fizz
//
//
//5.Bim
//
//
//6.FizzBuzz
//
//
//7.7
//
//
//8.Fizz
//
//
//9.Buzz
//
//
//10.FizzBim
//
//
//11.11
//
//
//12.FizzBuzz
//
//
//13.13
//
//
//14.Fizz
//
//
//15.BuzzBim
//
//
//16.Fizz
//
//
//17.17
//
//18.FizzBuzz

