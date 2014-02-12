using System;

namespace TriangleTyperApp
{
    public class TriangleTypeCalculator
    {
        int _nbrA;
        int _nbrB;
        int _nbrC;

        public string GetTriangleType(string sideA, string sideB, string sideC)
        {
            // The Try, Catch and decimal.Parse are shown in an example here: http://msdn.microsoft.com/en-us/library/cafs243z(v=vs.110).aspx
            try  
            {
                _nbrA = int.Parse(sideA);
                _nbrB = int.Parse(sideB);
                _nbrC = int.Parse(sideC);
            }
            catch (FormatException)
            {
                return CheckForEasterEggs(sideA, sideB, sideC); 
            }
            return ValidateTriangle(); 

        }

       
       public string CheckForEasterEggs(string easterA, string easterB, string easterC)
       {
           if (easterA == "open" && easterB == "podbay" && easterC == "doors")
            {
                return "I'm sorry Dave, I'm afraid I can't do that";
            }
           return "Input must be numeric";
       }


        public string ValidateTriangle()
        {
            if (_nbrA > 0 && _nbrB > 0 && _nbrC > 0)
            {
                return TestTriangleDimensions();
            }
            return "Positive numbers greater than 0 are required";
        }

        public string TestTriangleDimensions()
        {
          //if (_nbrA + _nbrB > _nbrC && _nbrB + _nbrC > _nbrA && _nbrC + _nbrA > _nbrB)
            if (Math.Abs(_nbrA-_nbrB) < _nbrC && Math.Abs(_nbrB - _nbrC) < _nbrA && Math.Abs(_nbrC-_nbrA) < _nbrB)
                {
               return DetermineTriangleType();
                }
            return "These dimensions are not correct; please reenter";
        }

        public string DetermineTriangleType()
       {
           if (_nbrA == _nbrB && _nbrA == _nbrC)
           {
               return "Equilateral";
           }
            if (_nbrA == _nbrB || _nbrB == _nbrC || _nbrA == _nbrC)
            {
                return "Isosceles";
            }
            return "Scalene";
       }
    }
}