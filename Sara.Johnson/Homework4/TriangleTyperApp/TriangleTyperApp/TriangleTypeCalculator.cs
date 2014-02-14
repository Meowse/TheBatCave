using System;
using System.Windows.Forms;

namespace TriangleTyperApp
{
    public class TriangleTypeCalculator
    {

        public decimal A;
        public decimal B;
        public decimal C;

        public string GetTriangleType(string sideA, string sideB, string sideC)
        {
            try
            {
                A = decimal.Parse(sideA);
                B = decimal.Parse(sideB);
                C = decimal.Parse(sideC);
            }

            catch (FormatException)
            {
                return "Enter a numeric value for each side";
            }

            catch (ArgumentOutOfRangeException)
            {
                return "Input out of range";
            }

            catch (OverflowException)
            {
                return "Input out of range";
            }

            //if the result of adding any two sides is less than or equal to the third side, return "not a triangle".

            if ((A <= Math.Abs(B - C)) || (B <= Math.Abs(C - A)) || (C <= Math.Abs(B-A)))
            {
                return "Not a triangle";
            }



            if ((A == B && B == C && A==C))
            {
                return "Equilateral";
            }

            if (B == C || A == B || C == A)
            {
                return "Isosceles";
            }

            if ((A != B || B != C || A != C))
            {
                return "Scalene";
            }

                return "Not a valid entry";
         }

        




    }
            
}


