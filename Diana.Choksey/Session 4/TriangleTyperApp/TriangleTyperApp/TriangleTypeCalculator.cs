using System;
using System.Collections.Generic;
using System.IO;

namespace TriangleTyperApp
{
    public class TriangleTypeCalculator
    {
        
        public string GetTriangleType(string sideA, string sideB, string sideC)
        {
            int a;
            if (!int.TryParse(sideA, out a))
            {
                return "Make sure all sides are Integers";
            }
            int b;
            if (!int.TryParse(sideB, out b))
            {
                return "Make sure all sides are Integers";
            }
            
            int c;
            if (!int.TryParse(sideC, out c))
            {
                return "Make sure all sides are Integers";
            }

            return GetTriangleType(a, b, c);
        }

        public string GetTriangleType(int a, int b, int c)
        {
            if ((a + b <= c) || (a + c <= b) || (b + c <= a))
            {
                return "Sorry Dave these sides do not a triangle make";
            }


            if ((a == b) && (b == c))
            {
                return "Equilateral";      
            }

            if ((a == b) || (a == c) || (b == c))
            {
                return "Isosceles";
            }

            if ((a != b) && (a != c) && (b != c))
            {
                return "Scalene";
            }
            return "Stop messing around";
        }
    }
}

