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
                return "Please enter an Integer for Side A";
            }
            int B;
            if (!int.TryParse(sideA, out B))
            {
                return "Please enter an Integer for Side B";
            }
            int C;
            if (!int.TryParse(sideA, out C))
            {
                return "Please enter an Integer for Side C";
            }
            // check to see if 0 < int < MaxInt            
            // check to see if sideA + sideB <= sideC
            // check to see if sideB + sideC <= sideA
            // check to see if sideA + sideC <= sideB
            // check to see if A = B && B = C
            if (A == B && B == C)
            {
                return "Equilateral";
            }
            // check to see if A = B || B = C || A = C
            if (A == B || B == C || A == C)
            {
                return "Isoscoles";
            }
            return "Scalene";
        }
    }
}
