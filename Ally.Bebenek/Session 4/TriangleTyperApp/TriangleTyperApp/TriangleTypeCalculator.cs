namespace TriangleTyperApp
{
    public class TriangleTypeCalculator
    {
        public string GetTriangleType(string sideA, string sideB, string sideC)
        {
            return "Equilateral";
        }

        public int Add(int a, int b)
        {
            return a + b;
        }

        public bool AreEqual(int a, int b)
        {
            if (a == b)
                return true;
            return false;
        }
    }
}
