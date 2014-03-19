namespace FizzBuzzBim
{
    public static class FizzBuzzBimCalculator
    {

        public static string[] FizzBuzzBim(int max, int fizz, int buzz, int bim)
        {
            var length = max;
            var result = new string[length];
            var i = 0;

            for (var currentValue = 1; currentValue <= max; currentValue++)
            {
                if (currentValue % fizz == 0 && currentValue % buzz == 0 && currentValue % bim == 0)
                {
                    result[i++] = "fizzbuzzbim";
                }
                else if (currentValue % fizz == 0 && currentValue % buzz == 0)
                {
                    result[i++] = "fizzbuzz";
                }

                else if (currentValue % buzz == 0 && currentValue % bim == 0)
                {
                    result[i++] = "buzzbim";
                }


                else if (currentValue % fizz == 0 && currentValue % bim == 0)
                {
                    result[i++] = "fizzbim";
                }

                else if (currentValue % fizz == 0)
                {
                    result[i++] = "fizz";
                }

                else if (currentValue % buzz == 0)
                {
                    result[i++] = "buzz";
                }

                else if (currentValue % bim == 0)
                {
                    result[i++] = "bim";
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