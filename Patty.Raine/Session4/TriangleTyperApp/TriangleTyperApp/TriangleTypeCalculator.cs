using System;
using System.Drawing;
using System.Runtime.CompilerServices;

namespace TriangleTyperApp
{
    public class TriangleTypeCalculator
    {
        decimal _nbrA;
        decimal _nbrB;
        decimal _nbrC;

        public string GetTriangleType(string sideA, string sideB, string sideC)
        {
            try
            {
                _nbrA = decimal.Parse(sideA);
                _nbrB = decimal.Parse(sideB);
                _nbrC = decimal.Parse(sideC);
            }
            catch (FormatException)
            {
                return CheckForEasterEggs(sideA, sideB, sideC); //call routine to look for easter eggs
            }
            return ValidateTriangle(); //call routine see if triangle is true

        }

       
       public string CheckForEasterEggs(string easterA, string easterB, string easterC)
        {
           if (easterA == "open" && easterB == "podbay" && easterC == "doors")
            {
                return "I'm sorry Dave, I'm afraid I can't do that";
            }           
        else
            {
                return "Input must be numeric";
            }
        }


       public string ValidateTriangle()
        {
           if (_nbrA > 0 && _nbrB > 0 && _nbrC > 0)
            {
                return TestTriangleDimensions();
            }
            else
                {
                    return "Positive numbers greater than 0 are required";
                }
        }

       public string TestTriangleDimensions()
       {

           if (_nbrA+_nbrB >_nbrC &&_nbrB+_nbrC >_nbrA &&_nbrC+_nbrA >_nbrB)
           {
               return DetermineTriangleType();
           }
           else
           {
               return "These dimensions are not correct; please reenter";
           }
       }
       public string DetermineTriangleType()
       {
           if (_nbrA == _nbrB && _nbrA == _nbrC)
           {
               return "Equilateral";
           }
           else
           {
               if (_nbrA == _nbrB || _nbrB == _nbrC || _nbrA == _nbrC)
               {
                   return "Isosceles";
               }
               else
               {
                   return "Scalene";
               }
           }
       }
    }
}