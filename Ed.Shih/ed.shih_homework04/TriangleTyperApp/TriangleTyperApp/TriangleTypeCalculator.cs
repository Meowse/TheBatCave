namespace TriangleTyperApp
{
    public class TriangleTypeCalculator
    {
        public string GetTriangleType(string sideA, string sideB, string sideC)
        {
            // try to convert string to int
            // check to see if 0 < int < MaxInt
            // check to see if sideA + sideB <= sideC
            // check to see if sideB + sideC <= sideA
            // check to see if sideA + sideC <= sideB
            // check to see if A = B && B = C
            if (sideA == sideB && sideB == sideC)
            {
                return "Equilateral";
            }
            // check to see if A = B || B = C || A = C
            if (sideA == sideB || sideB == sideC || sideA == sideC)
            {
                return "Isoscoles";
            }
            return "Scalene";
        }
    }
}
