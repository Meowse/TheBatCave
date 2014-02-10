using System;
using System.Collections.Generic;

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
            if (!int.TryParse(sideA, out b))
            {
                return "Inputs must be integers";
            }

            int c;
            if (!int.TryParse(sideA, out c))
            {
                return "Inputs must be integers";
            }

            return GetTriangleType(a, b, c);
        }

        private string GetTriangleType(int a, int b, int c)
        {
            if ((a < 0) || (b < 0) || (c < 0))
            {
                return "A triangle cannot have sides of negative length";
            }

            return "Equilateral";
        }
    }
}
