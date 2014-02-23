using System;

namespace TriangleTyperApp
{
    public class TriangleTypeCalculator
    {
        public int SideA = 0;
        public int SideB = 0;
        public int SideC = 0;

        private const string PositiveIntOnly = "Inputs must be a positive integer";
        private const string NotTriangle = "Not a triangle";


        public string GetTriangleType(string sideA, string sideB, string sideC)
        {
            if (!Int32.TryParse(sideA, out SideA))
            {
                return PositiveIntOnly;
            }
            if (!Int32.TryParse(sideB, out SideB))
            {
                return PositiveIntOnly;
            }
            if (!Int32.TryParse(sideC, out SideC))
            {
                return PositiveIntOnly;
            }
            return FindTriangleType();
        }

        public string FindTriangleType()
        {
     
            if (SideA <= 0 || SideB <= 0 || SideC <= 0)
            {
                return PositiveIntOnly;
            }
            if (SideC <= Math.Abs(SideA - SideB)  ||  SideA <= Math.Abs(SideB - SideC)  || SideB  <= Math.Abs(SideA - SideC))
            {
                return NotTriangle;
            }
            if (SideA == SideB && SideB == SideC)
            {
                return "Equilateral";
            }
            if (SideA == SideB || SideB == SideC || SideA == SideC)
            {
                return "Isosceles";
            }
            return "Scalene";
        }
    }
}
