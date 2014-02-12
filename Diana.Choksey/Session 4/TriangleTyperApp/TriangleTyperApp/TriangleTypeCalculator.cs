using System;
using System.Collections.Generic;
namespace TriangleTyperApp
{
    public class TriangleTypeCalculator
    {
        //private decimal _nbrA;
        //private decimal _nbrB;
        //private decimal _nbrC;
    
        public string GetTriangleType(string sideA, string sideB, string sideC)
        {
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

            //make sure all inputs make a triangle
            if ((A + B < C) || (A + C < B) || (B + C < A))

                return "Sorry Dave these sides do not a triangle make";


            if ((sideA == sideB) && (sideB == sideC))
            {
                return "Equilateral";      
            }

            if ((sideA == sideB) || (sideA == sideC) || (sideB == sideC))
            {
                return "Isoceles";
            }

            if ((sideA != sideB) && (sideA != sideC) && (sideB != sideC))
            {
                return "Scalene";
            }
            return "Stop messing around";
        }
    }
}

