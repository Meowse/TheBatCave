namespace FizzBuzz
{
    public class Fuzzy
    {

        public static string[] FizzBuzz(int max, int fizz, int buzz)
        {
            var length = max - 1 + 1;
            var result = new string[length];
            var i = 0;

            for (var currentValue = 1; currentValue <= max; currentValue++)
            {
                if (currentValue % fizz == 0 && currentValue % buzz == 0)
                {
                    result[i++] = "fizzbuzz";
                }
                else if (currentValue % fizz == 0)
                {
                    result[i++] = "fizz";
                }

                else if (currentValue % buzz == 0)
                {
                    result[i++] = "buzz";
                }

                else
                {
                    result[i++] = currentValue.ToString();
                }


            }

            return result;

        }
    }
}
