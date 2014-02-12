using System;
using System.Collections.Generic;
using System.IO;

namespace TriangleTyperApp
{
    public class TriangleTypeCalculator
    {
        //private decimal _nbrA;
        //private decimal _nbrB;
        //private decimal _nbrC;

        public string GetTriangleType(string sideA, string sideB, string sideC)
        {
            int a;
            if (!int.TryParse(sideA, out a))
            {
                return "Make sure all sides are Integers";
            }
            int b;
            if (!int.TryParse(sideA, out b))
            {
                return "Make sure all sides are Integers";
            }
            
            int c;
            if (!int.TryParse(sideA, out c))
            {
                return "Make sure all sides are Integers";
            }

            return GetTriangleType(a, b, c);
        }

        public string GetTriangleType(int a, int b, int c)

        //make sure all inputs make a triangle
        {
            if ((a + b < c) || (a + c < b) || (b + c < a))

            {
                return "Sorry Dave these sides do not a triangle make";
            }


            if ((a == b) && (b == c))
            {
                return "Equilateral";      
            }

            if ((a == b) || (a == c) || (b == c))
            {
                return "Isoceles";
            }

            if ((a != b) && (a != c) && (b != c))
            {
                return "Scalene";
            }
            return "Stop messing around";
        }
    }
}

