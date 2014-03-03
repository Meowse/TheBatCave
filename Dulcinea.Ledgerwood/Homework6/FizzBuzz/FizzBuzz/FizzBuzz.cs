namespace FizzBuzz
{
    public class FizzBuzz
    {
        public string[] FizzBuzzCount(int max)
        {
            string[] result = new string[max];
            string fizzBuzz;

            for (int i = 1; i <= max; i++)
            {
                fizzBuzz = string.Empty;

                if ((i%3 != 0) && (i%5 != 0))
                {
                    result[i-1] = i.ToString();
                }
                else
                {
                    if (i%3 == 0)
                    {
                        fizzBuzz = "Fizz";
                    }
                    if (i%5 == 0)
                    {
                        fizzBuzz += "Buzz";
                    }
                    result[i-1] = fizzBuzz;
                }
            }
            return result;
        }
    }
}
