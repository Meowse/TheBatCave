﻿using System.Runtime.Remoting.Messaging;

namespace TriangleTyperApp
{
    public class TriangleTypeCalculator
    {
        public string GetTriangleType(string sideA, string sideB, string sideC)
        {
            if (sideA == sideB && sideB == sideC)
            {
                return "Equilateral";
            }

            if (sideA == sideB || sideB == sideC || sideC == sideA)
            {
                return "Isosceles";
            }

        // if (sideA + sideB > sideC || sideB + sideC > sideA || sideA + sideC > sideB)
       //  {
       //      return "Scalene"
      //   } 
            return "Nope.";
        }
    }
}

