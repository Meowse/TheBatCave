using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;
using System.Xml.Schema;

namespace TriangleTyperApp
{
    public class TriangleTypeCalculator
    {
        public string GetTriangleType(string sideA, string sideB, string sideC)
        {
            if ((sideA == sideB) && (sideB == sideC))

                return "Equilateral";

            if ((sideA != sideB) && (sideB != sideC) && (sideC != sideA))

                return "Scalene";

            return "Isoceles";

        }

    }

}
