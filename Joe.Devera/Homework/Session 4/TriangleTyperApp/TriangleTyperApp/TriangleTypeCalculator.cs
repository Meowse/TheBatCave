using System;
using System.IO;
using System.Linq;
using System.Net.Security;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;
using System.Windows.Forms;

namespace TriangleTyperApp
{
    public class TriangleTypeCalculator
    { 
        public string GetTriangleType(string sideA, string sideB, string sideC)
        {

                //decimal numSideA = Convert.ToDecimal(sideA);
                //decimal numSideB = Convert.ToDecimal(sideB);
                //decimal numSideC = Convert.ToDecimal(sideC);


            if (Convert.ToInt16(sideA) <= 0 || Convert.ToInt16(sideB) <=0  || Convert.ToInt16(sideC) <=0)
            {
                return "Please Enter a Positive Number";
            }

           if (Convert.ToInt16(sideA) == Convert.ToInt16(sideB) && Convert.ToInt16(sideA) == Convert.ToInt16(sideC))
            {
                return "Equilateral";
            }

            if (Convert.ToInt16(sideA) == Convert.ToInt16(sideB) || Convert.ToInt16(sideA) == Convert.ToInt16(sideC))
            {
                return "Isosceles";
            }

            if (Convert.ToInt16(sideA) != Convert.ToInt16(sideB) || Convert.ToInt16(sideA) != Convert.ToInt16(sideC) || Convert.ToInt16(sideB) != Convert.ToInt16(sideC))
            {
                return "Scalene";
            }

            return "some error";
        }

    }
}
