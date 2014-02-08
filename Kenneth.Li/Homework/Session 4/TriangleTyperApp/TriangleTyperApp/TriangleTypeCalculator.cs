using System;
using System.Diagnostics.Eventing.Reader;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Linq;

namespace TriangleTyperApp
{
    public class TriangleTypeCalculator
    {
        private decimal _a;
        private decimal _b;
        private decimal _c;

        public string ConvertTriangleValuesToDecimal(string sideA, string sideB, string sideC)
        {
            CheckForEasterEggsOrInvalidString(sideA, sideB, sideC);
            try
            {
                _a = decimal.Parse(sideA);
                _b = decimal.Parse(sideB);
                _c = decimal.Parse(sideC);
            }
            catch (FormatException)
            {
                return CheckForEasterEggsOrInvalidString(sideA, sideB, sideC);
            }
            return CheckIfTriangleIsValid();
        }

        public string CheckForEasterEggsOrInvalidString(string easterA, string easterB, string easterC)
        {
            if (easterA == "open" && easterB == "podbay" && easterC == "door")
            {
                return "I'm sorry, Dave, I can't allow you to do that.";
            }
            return "Inputs must be numeric";
        }

        public string CheckIfTriangleIsValid()
        {
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
