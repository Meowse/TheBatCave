using System;
using System.Text;
using System.Windows.Forms;
namespace FizzBuzz
{
    class FizzBuzz
    {
        private int _fizzDivisor;
        private int _buzzDivisor;

        public FizzBuzz() : this(3, 5)
        {
        }

        public FizzBuzz(int fizzDivisor, int buzzDivisor)
        {
            _fizzDivisor = fizzDivisor;
            _buzzDivisor = buzzDivisor;
        }

        public string[] Count(int max)
        {
            int min = 1;
            int length = (max / min) + 1;
            string[] result = new string[length];
            for (int i = 0; i < length; i++)
            {
                result[i] = Convert.ToString((i + 1) - 1);

                if (i % _fizzDivisor == 0)
                {
                    result[i] = "Fizz";
                }
                if (i % _buzzDivisor == 0)
                {
                    result[i] = "Buzz";
                }
                if (i % _fizzDivisor == 0 && i % _buzzDivisor == 0)
                {
                    result[i] = "FizzBuzz";
                }
                if (i == 0)
                {
                    result[i] = "0";
                }
            }
            return result;
        }
    }
}
