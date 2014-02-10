using System;
using Microsoft.SqlServer.Server;

namespace TriangleTyperApp
{
    public class TriangleTypeCalculator
    {
        private decimal _nbrA;
        private decimal _nbrB;
        private decimal _nbrC;
        
        
        public string GetTriangleType(string sideA, string sideB, string sideC)
        {
            // if a = b = c then return equilateral
            // otherwise return isosceles

            if ((sideA == sideB) && (sideB == sideC))
            {
                return "Equilateral";
            }

            //return "Isosceles";

            // if a != b && b != c && c != a return scalene
            // otherwise return isosceles
            if ((sideA != sideB) && (sideB != sideC) && (sideC != sideA))
            {
                return "Scalene";
            }

            return "Isosceles";
        }
    }
}
