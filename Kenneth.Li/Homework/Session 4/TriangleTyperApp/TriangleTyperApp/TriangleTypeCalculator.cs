using System;
using System.Linq;

namespace TriangleTyperApp
{
    public class TriangleTypeCalculator
    {
        public string GetTriangleType(string sideA, string sideB, string sideC)
        {
            try
            {
                if (decimal.Parse(sideA) == decimal.Parse(sideB) && decimal.Parse(sideB) == decimal.Parse(sideC) && decimal.Parse(sideA) == decimal.Parse(sideC))
                {
                    return "Equilateral";
                }
                if (decimal.Parse(sideA) == decimal.Parse(sideB) || decimal.Parse(sideA) == decimal.Parse(sideB) || decimal.Parse(sideA) == decimal.Parse(sideC))
                {
                    return "Isosceles";
                }
                if (decimal.Parse(sideA) < 1 || decimal.Parse(sideB) < 1 || decimal.Parse(sideC) < 1)
                {
                    return "Input must be a positive number";
                }
                return "Scalene";
            }
            catch
            {
                return "Inputs must be numeric";
            }
        }
    }
}
