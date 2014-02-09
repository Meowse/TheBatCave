namespace TriangleTyperApp
{
    public class TriangleTypeCalculator
    {
        private decimal _a;
        private decimal _b;
        private decimal _c;

        public string GetTriangleType(string sideA, string sideB, string sideC)
        {
            try
            {
                _a = decimal.Parse(sideA);
                _b = decimal.Parse(sideB);
                _c = decimal.Parse(sideC);
            }
            catch
            {
                if (sideA.ToLower() == "open" && sideB.ToLower() == "podbay" && sideC.ToLower() == "door")
                {
                    return "I'm sorry, Dave, I can't allow you to do that.";
                }
                if (string.IsNullOrEmpty(sideA) || string.IsNullOrEmpty(sideB) || string.IsNullOrEmpty(sideC))
                {
                    return "Please enter a length for each side";
                }
                return "Inputs must be numeric";
            }
            return FindTriangleType(_a,_b,_c);
        }

        public string FindTriangleType(decimal sideA, decimal sideB, decimal sideC)
        {
            if (_a <= 0 || _b <= 0 || _c <= 0)
            {
                return "Input must be a positive number";
            }
            if (_a % 1 > 0 || _b % 1 > 0 || _c % 1 > 0)
            {
                return "Inputs must be integers";
            }
            //"Three numbers cannot form a triangle if the sum of any two is less than the third
            if (_a + _b <= _c || _a + _c <= _b || _b + _c <= _a)
            {
                return "Not a triangle. Please reenter inputs.";
            }
            if (_a > 2147483647|| _b > 2147483647 || _c > 2147483647)
            {
                return "Input(s) out of range.";
            }
            if (_a == _b && _b == _c && _a == _c)
            {
                return "Equilateral";
            }
            if (_a == _b || _b == _c|| _a == _c)
            {
                return "Isosceles";
            }
            return "Scalene";
        }
    }
}


      