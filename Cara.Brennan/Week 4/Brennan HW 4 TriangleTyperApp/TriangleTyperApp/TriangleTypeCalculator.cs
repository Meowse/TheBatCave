using System.Collections.Concurrent;
using System.Windows.Forms;

namespace TriangleTyperApp
{
    public class TriangleTypeCalculator
    {
        public string GetTriangleType(string sideA, string sideB, string sideC)
        {
            if sideA||sideB and sideB || sideC
            return "Equilateral";

            else if sideA ||sideB or sideB||sideC or sideA||sideC
            return "Isosceles"
            
            else
            return "Scalene"

            if sideA or sideb or sidec is Not and integer
            return "Please input integers."
            
            if ((sideA + sideB)< sideC) or ((sideB+sideC)<sideA ) or ((sideC+sideA)<sideB)
             return "Sorry, your triangle is actually a T-Rex. It cannot live in the Triassic Period, please try again."
        }
    }
}
