using System;
using System.Runtime.Remoting;
using Microsoft.SqlServer.Server;

namespace TriangleTyperApp
{
    public class TriangleTypeCalculator
    {
        private decimal _nbrA;
        private decimal _nbrB;
        private decimal _nbrC;


        public string GetTriangleType(string sideA, string sideB, string sideC)
        {
            // if a = b = c then return equilateral
            // otherwise return isosceles

            if ((sideA == sideB) && (sideB == sideC))
            {
                return "Equilateral";
            }


            // if a != b && b != c && c != a return scalene
            // otherwise return isosceles
            if ((sideA != sideB) && (sideB != sideC) && (sideC != sideA))
            {
                return "Scalene";
            }
            return "Isosceles";
            ;
        }
    }
}
//  Assert.That(_calculator.GetTriangleType("-1", "3", "4"), Is.EqualTo("Input must be a positive whole number"));
// Assert.That(_calculator.GetTriangleType("one", "10", "15"),Is.EqualTo("Input must be a positive whole number"));
//Assert.That(_calculator.GetTriangleType(" ", "10", "12"),  Is.EqualTo("Input must be a positive whole number"));
//Assert.That(_calculator.GetTriangleType(" ", "10", "12"),  Is.EqualTo("Input must be a positive whole number"));
//Assert.That(_calculator.GetTriangleType("#", "10", "12"),  Is.EqualTo("Input must be a positive whole number"));
//Assert.That(_calculator.GetTriangleType(".5", "10", "12"), Is.EqualTo("Input must be a positive whole number"));

//     int a;
   //     if (!int.TryParse(sideA, out a))
   //     {
    //        return "Input must be a positive whole number";
   //     }

    //         int b;
    //    if (!int.TryParse(sideB, out b))
    //    {
   //         return "Input must be a positive whole number";
   //     }
   //     int c;
     //      if (!int.TryParse(sideC, out c))
     //      {
     //           return "Input must be a positive whole number";
   //          }

  //  }
 //   }


           
        
    
