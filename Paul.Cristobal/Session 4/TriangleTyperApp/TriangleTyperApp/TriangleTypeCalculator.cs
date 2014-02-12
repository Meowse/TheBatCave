namespace TriangleTyperApp
{
    public class TriangleTypeCalculator
    {
        private decimal _A;
        private decimal _B;
        private decimal _C;

        public void GetTriangleType(string sideA, string sideB, string sideC)
        {
            if ((sideA == sideB) && (sideB == sideC))
            {
                return "Equilateral";
            }

            if ((sideA != sideB) && (sideB != sideC) && (sideC != sideA))
            {
                return "Scalene";
            }
        }
    }
}

