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

            if (sideA == "")
            {
                return "Please Enter a Positive Number";
            }

            if (sideB == "")
            {
                return "Please Enter a Positive Number";
            }

            if (sideC == "")
            {
                return "Please Enter a Positive Number";
            }


            if (Convert.ToInt32(sideA) <= 0 || Convert.ToInt32(sideB) <=0  || Convert.ToInt32(sideC) <=0)
            {
                return "Please Enter a Positive Number";
            }

            if (Convert.ToInt32(sideA) <= (Math.Abs(Convert.ToInt32(sideB)) - Math.Abs(Convert.ToInt32(sideC))))
            {
                return "Not a triangle";
            }

            if (Convert.ToInt32(sideB) <= (Math.Abs(Convert.ToInt32(sideC)) - Math.Abs(Convert.ToInt32(sideA))))
            {
                return "Not a triangle";
            }

            if (Convert.ToInt32(sideA) <= (Math.Abs(Convert.ToInt32(sideC)) - Math.Abs(Convert.ToInt32(sideB))))
            {
                return "Not a triangle";
            }

           if (Convert.ToInt32(sideA) == Convert.ToInt32(sideB) && Convert.ToInt32(sideA) == Convert.ToInt32(sideC))
            {
                return "Equilateral";
            }

            if (Convert.ToInt32(sideA) == Convert.ToInt32(sideB) || Convert.ToInt32(sideA) == Convert.ToInt32(sideC) || (Convert.ToInt32(sideB) == (Convert.ToInt32(sideC))))
            {
                return "Isosceles";
            }

            //if (Convert.ToInt32(sideA) == Convert.ToInt32(sideB) || Convert.ToInt32(sideA) == Convert.ToInt32(sideC) || Convert.ToInt32(sideB) == Convert.ToInt32(sideC))
            //{
            //    return "Scalene";
            //}

            return "Scalene";
        }

    }
}
