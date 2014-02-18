using System;

namespace TriangleTyperApp
{


    public class TriangleTypeCalculator
    {

        public static void Main()
        {
            Convert("sideA");
            Convert("sideB");
            Convert("sideC");
        }

        public string GetTriangleType(string sideA, string sideB, string sideC)
        {
            try
            {
                int prA = TriangleTypeCalclator.Parse(sideA);
                int prB = TriangleTypeCalclator.Parse(sideB);
                int prC = TriangleTypeCalclator.Parse(sideC);

            }
            catch (FormatException)
            {

                return "Your inputs are not acceptable integers, please try again. ";

            }
            return CheckforTriangle();
        }

        public string CheckforTriangle()
        {

            if (prA <= 0 || prB <= 0 || prC <= 0)
            {
                return "Input must be a positive number";
            }
            if (prC <= (prA + prB) || prA <= (prB + prC) || prB <= (prA + prC))
            {
                return "I'm sorry your triangle is actually a T-Rex and cannot live in the Triassic Period. Please input new integers.";
            }
            if (prA == prB && prB == prC)
            {
                return "Equilateral";
            }
            if (prA == prB || prB == prC || prA == prC)
            {
                return "Isosceles";
            }
            return "Scalene";
        }

        public object prC { get; set; }
    }

    public class TriangleTypeCalclator
    {
    }
}
