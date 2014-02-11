using System;

namespace TriangleTyperApp
{
    public class TriangleTypeCalculator
    {
        public string GetTriangleType(string sideA, string sideB, string sideC)
        {
            // try to convert string to int
            int A;
            if (!int.TryParse(sideA, out A))
            {
                return "Make sure all sides are Integers";
            }
            int B;
            if (!int.TryParse(sideA, out B))
            {
                return "Make sure all sides are Integers";
            }
            int C;
            if (!int.TryParse(sideA, out C))
            {
                return "Make sure all sides are Integers";
            }
            // check to see if 0 < int < MaxInt
            // changing design to limit range from 0 to 2000000000
            if (A < 1)
            {
                return "Sides must be greater than 0 and less than 2,000,000,001";
            }
            if (A > 2000000000)
            {
                return "Sides must be greater than 0 and less than 2,000,000,001";
            }
            if (B < 1)
            {
                return "Sides must be greater than 0 and less than 2,000,000,001";
            }
            if (B > 2000000000)
            {
                return "Sides must be greater than 0 and less than 2,000,000,001";
            }
            if (C < 1)
            {
                return "Sides must be greater than 0 and less than 2,000,000,001";
            }
            if (C > 2000000000)
            {
                return "Sides must be greater than 0 and less than 2,000,000,001";
            }
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
