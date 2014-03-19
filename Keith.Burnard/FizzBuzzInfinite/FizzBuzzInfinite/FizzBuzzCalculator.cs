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
                returnString = BuildTheReturnString(fizzBuzzObjects, i, returnString) + "\r\n";
            }
            return returnString;
        }

        private static string BuildTheReturnString(List<FizzBuzzObject> fizzBuzzObjects, int i, string returnString)
        {
            bool numberIsEvenlyDivisibleByDenominator = false;
            foreach (FizzBuzzObject t in fizzBuzzObjects)
            {
                if (i == 0) numberIsEvenlyDivisibleByDenominator = true;
                else
                {
                    if (i%t.Denominator != 0) continue;
                    returnString += t.Message;
                    numberIsEvenlyDivisibleByDenominator = true;
                }
            }
            if (!numberIsEvenlyDivisibleByDenominator) returnString += i;
            return returnString;
        }
    }
}
