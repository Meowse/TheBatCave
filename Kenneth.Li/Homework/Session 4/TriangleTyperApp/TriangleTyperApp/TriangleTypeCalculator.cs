using System;
using System.Windows.Forms;
using System.Linq;

namespace TriangleTyperApp
{
    public class TriangleTypeCalculator
    {
        private decimal _a;
        private decimal _b;
        private decimal _c;
        public string CheckIfTriangleIsValid(string sideA, string sideB, string sideC)
        {
            try
            {
                _a = decimal.Parse(sideA);
                _b = decimal.Parse(sideB);
                _c = decimal.Parse(sideC);
            }
            catch(FormatException)
            {
                return "Inputs must be numeric";
            }
            if (_a + _b > _c && _b + _c > _a && _a + _c > _b)
            {
                return GetTriangleType();
            }
            if (_a < 1 || _b < 1 || _c < 1)
            {
                return "Input must be a positive number";
            }
            return "Not a triangle";
        }

        public string GetTriangleType()
        {
            if (_a == _b && _b == _c && _a == _c)
            {
                return "Equilateral";
            }
            if (_a == _b || _b == _c || _a == _c)
            {
                return "Isosceles";
            }
            return "Scalene";
        }
    }
}
