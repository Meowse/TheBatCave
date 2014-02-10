namespace Triangle
{
    /****
     *  This test is divided into two halves.
     *  1. Implement the GetTriangleType method so that it returns the appropriate
     *     enum value for different inputs.
     *  2. Write a complete series of passing unit tests for the GetTriangleType method
     *     under various input conditions. In this example we're using NUnit, but
     *     you can use whatever testing framework you prefer.
     *     
     *  When finished, send back your solution (your version of TriangleTester.cs
     *  will suffice) including any explanatory comments you feel are needed.  
     */

    public enum TriangleType
    {
        Scalene = 1, // no two sides are the same length
        Isosceles = 2, // two sides are the same length and one differs
        Equilateral = 3, // all sides are the same length
        Error = 4 // inputs can't produce a triangle
    }

    public class TriangleTester
    {
        /// <summary>
        /// Given the side lengths a, b, and c, determine and return
        /// what type of triangle the lengths describe, or whether
        /// the input is invalid
        /// </summary>
        /// <param name="a">length of side a</param>
        /// <param name="b">length of side b</param>
        /// <param name="c">length of side c</param>
        /// <returns>The triangle type based on the number of matching sides passed in.</returns>
        public static TriangleType GetTriangleType(int a, int b, int c)
        {
            //Placing items in an array for processing 
            int[] values = new int[3] {a, b, c};

            // keeping this as the first check in case someone passes invalid parameters that could also be a triangle type. 
            //Example: -2,-2,-2 could return Equilateral instead of Error without this check.  
            //We also have a catch all at the end that returns Error if no other condition was met.
            if (a <= 0 || b <= 0 || c <= 0) 
            {
                return TriangleType.Error;
            }
            else if (values.Distinct().Count() == 1) //There is only one distinct value in the set, therefore all sides are of equal length
            {
                return TriangleType.Equilateral;
            }
            else if (values.Distinct().Count() == 2) //There are only two distinct values in the set, therefore two sides are equal and one is not
            {
                return TriangleType.Isosceles;
            }
            else if (values.Distinct().Count() == 3) // There are three distinct values in the set, therefore no sides are equal
            {
                return TriangleType.Scalene;
            }
            else
            {
                return TriangleType.Error;
            }
        }
    }

    [TestFixture]
    public class TriangleTesterTests
    {
        [Test]
        public void Test_GetTriangleType()
        {
            Assert.AreEqual(TriangleType.Equilateral, 
                            TriangleTester.GetTriangleType(4, 4, 4), 
                            "GetTriangleType(4, 4, 4) did not return Equilateral");

            Assert.AreEqual(TriangleType.Isosceles, 
                            TriangleTester.GetTriangleType(4, 4, 3),
                            "GetTriangleType(4, 4, 3) did not return Isosceles");

            Assert.AreEqual(TriangleType.Scalene, 
                            TriangleTester.GetTriangleType(4, 3, 2),
                            "GetTriangleType(4, 3, 2) did not return Scalene");

            Assert.AreEqual(TriangleType.Error, 
                            TriangleTester.GetTriangleType(-4, 4, 4),
                            "GetTriangleType(-4, 4, 4) did not return Error");

            Assert.AreEqual(TriangleType.Error,
                            TriangleTester.GetTriangleType(4, -4, 4),
                            "GetTriangleType(4, -4, 4) did not return Error");

            Assert.AreEqual(TriangleType.Error,
                            TriangleTester.GetTriangleType(4, 4, -4),
                            "GetTriangleType(4, 4, -4) did not return Error");
        }
    }

}