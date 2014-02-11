namespace TriangleTyperApp
{
    public class TriangleTypeCalculator
    {
        public string GetTriangleType(string sideA, string sideB, string sideC)

        public static int IntSideA = int.Parse(sideA);
        public static int IntSideB = int.Parse(sideB);
        public static int IntSideC = int.Parse(sideC);

        if (IntSideA < 0 || IntSideB < 0 || IntSideC < 0)
                return "error!";
            else
            
                if ((IntSideA == IntSideB) && (IntSideA == IntSideC))

                    return "equilateral!";
                else if ((IntSideA == IntSideB) || (IntSideB == IntSideC) || IntSideC == IntSideB)

                    return "isoceles!";
                else
                    return "scalene!";
            }
        }
    }
    }
}
