using System;
using System.Collections.Generic;


namespace FizzBuzzInfinite
{
    public class FizzBuzzObject
    {
        public int Denominator { get; set; }
        public string Message { get; set; }
    }

    class FizzBuzzCalculator
    {
        public string Calculate(List<FizzBuzzObject> fizzBuzzObjects, int countTo)
        {
            string returnString = "";

            for (int i = 0; i <= countTo; i++)
            {
                bool foundModalEqualToZero = false;
                for (int j = 0; j < fizzBuzzObjects.Count; j++)
                {
                    if (i == 0)
                    {
                        returnString += "";
                        foundModalEqualToZero = true;
                    }
                    else
                    {
                        if (i % fizzBuzzObjects[j].Denominator == 0)
                        {
                            returnString += fizzBuzzObjects[j].Message;
                            foundModalEqualToZero = true;
                        }
                    }
                }
                if (!foundModalEqualToZero)
                {
                    returnString += i;
                }
                returnString += "\r\n";
            }
            return returnString;
        }
    }
}
