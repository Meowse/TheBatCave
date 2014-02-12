namespace TriangleTyperApp
{
    public class TriangleTypeCalculator
    {

        public string GetTriangleType(string sideA, string sideB, string sideC)
        {
            int a;
            if (!int.TryParse(sideA, out a))
            {
                return "Inputs must be integers";
            }
            int b;
            if (!int.TryParse(sideB, out b))
            {
                return "Inputs must be integers";
            }
            int c;
            if (!int.TryParse(sideC, out c))
            {
                return "Inputs must be integers";
            }
            
                if ((a == b) && (b == c))
                {
                    return "Equilateral";
                }

                if ((a != b) && (b != c) && (c != a))
                {
                    return "Scalene";
                }

                if ((a + b <= c) || (b + c <= a) || (c + a <= b))
                {
                    return "Not a Triangle";
                }
            }
        }
    }
