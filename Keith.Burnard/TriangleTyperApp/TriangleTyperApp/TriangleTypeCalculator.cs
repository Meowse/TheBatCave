﻿namespace TriangleTyperApp
{
    public class TriangleTypeCalculator
    {
        public string GetTriangleType(string sideA, string sideB, string sideC)
        {
            int sideAInt = int.Parse(sideA);
            int sideBInt = int.Parse(sideB);
            int sideCInt = int.Parse(sideC);

            // if ((a <= math.abs(c-b)) || (b <= math.abs(c-a)) || (c <= math.abs(a-b))
            if (sideAInt == sideBInt && sideAInt == sideCInt)
            {
                return "Equilateral";
            }

            if (sideAInt == sideBInt || sideAInt == sideCInt || sideBInt == sideCInt)
            {
                return "Isosceles";
            }

            return "Scalene";
        }
    }
}
