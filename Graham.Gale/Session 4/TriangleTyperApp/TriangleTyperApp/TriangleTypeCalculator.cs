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
                return "Inputs must be integers";

            }
            return ValidateTriangle(); 
        }

        public string ValidateTriangle()
        {
     
            if (NbrA <= 0 || NbrB <= 0 || NbrC <= 0)
            {
                return "Input must be a positive number";
            }
            if (NbrA + NbrB <= NbrC || NbrB + NbrC <= NbrA || NbrA + NbrC < NbrB)
            {
                return "Not a triangle";
            }
            if (NbrA == NbrB && NbrB == NbrC)
            {
                return "Equilateral";
            }
            if (NbrA == NbrB || NbrB == NbrC || NbrA == NbrC)
            {
                return "Isosceles";
            }
            return "Scalene";
        }
    }


}
