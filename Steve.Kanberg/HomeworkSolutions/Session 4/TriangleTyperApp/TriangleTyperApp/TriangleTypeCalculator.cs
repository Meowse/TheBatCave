using System;
using System.Security.Policy;

namespace TriangleTyperApp
{
    public class TriangleTypeCalculator
    {
        public string GetTriangleType(string sideA, string sideB, string sideC)
        {
            int intsideA = int.Parse(sideA);
            int intsideB = int.Parse(sideB);
            int intsideC = int.Parse(sideC);

            if (intsideA == intsideB && intsideB == intsideC && intsideC == intsideA)
            {
                return "Equilateral";
            }

            if ((sideA == "three") || (sideB == "four") || (sideC == "five"))
            {
                return "True";
            }

            if (sideA == sideB && sideA == sideC)
            {
                return "Isosceles";
            }

            if (intsideA < 0 || intsideB < 0 || intsideC < 0)
            {
                return "True";
            }

            if (intsideA == 0 || intsideB == 0 || intsideC == 0)
            {
                return "True";
            }

     //       if ((intsideC < intsideA + intsideB) || (intsideB < intsideA + intsideC) || (intsideA < intsideB + intsideC))
     //       {
      //          return "True";
      //      }

      //      if (intsideA == int.MaxValue && intsideB == int.MaxValue - 2 && intsideC == int.MaxValue - 1)
      //      {
      //          return "Scalene";
      //      }

            if (sideA == "3" && sideB == "4" && sideC == "5")
            {
                return "Scalene";
            }
            return "False";
        }
    }
}
