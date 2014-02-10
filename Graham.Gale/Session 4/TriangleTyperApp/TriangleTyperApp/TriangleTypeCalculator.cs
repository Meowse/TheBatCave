using System;

namespace TriangleTyperApp
{


    public class TriangleTypeCalculator
    {
        public int NbrA = 0;
        public int NbrB = 0;
        public int NbrC = 0;

        public string GetTriangleType(string sideA, string sideB, string sideC)
        {
            try
            {
                NbrA = int.Parse(sideA);
                NbrB = int.Parse(sideB);
                NbrC = int.Parse(sideC);
            }
            catch (FormatException)
            {
           //     return CheckForEasterEggs(sideA, sideB, sideC);
                           return "Error";

            }
            return ValidateTriangle(); 
        }

        public string ValidateTriangle()
        {
            //Placing items in an array for processing 

            // keeping this as the first check in case someone passes invalid parameters that could also be a triangle type. 
            //Example: -2,-2,-2 could return Equilateral instead of Error without this check.  
            //We also have a catch all at the end that returns Error if no other condition was met.
            if (NbrA <= 0 || NbrB <= 0 || NbrC <= 0)
            {
                return "Error";
            }
            if (NbrA + NbrB <= NbrC || NbrB + NbrC <= NbrA || NbrA + NbrC < NbrB)
            {
                return "Error";
            }
            if (NbrA == NbrB && NbrB == NbrC)
                //There is only one distinct value in the set, therefore all sides are of equal length
            {
                return "Equilateral";
            }
            if (NbrA == NbrB || NbrB == NbrC || NbrA == NbrC)
                //There are only two distinct values in the set, therefore two sides are equal and one is not
            {
                return "Isosceles";
            }
            return "Scalene";
        }
    }


}
