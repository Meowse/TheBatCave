namespace TriangleTyperApp
{
    public class TriangleTypeCalculator
    {
        public string GetTriangleType(string sideA, string sideB, string sideC)
        {
            
            if (sideA == sideB && sideB == sideC)
            {
                    return "Equilateral";
            }
            if (sideA == sideB || sideB == sideC || sideA == sideC) 
            {
            return "Isosceles";
            }
            return "Scalene";
        }
    }
}
