﻿using System;
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
                bool numberIsEvenlyDivisibleByDenominator = false;
                for (int j = 0; j < fizzBuzzObjects.Count; j++)
                {
                    if (i == 0)
                    {
                        returnString += "";
                        numberIsEvenlyDivisibleByDenominator = true;
                    }
                    else
                    {
                        if (i % fizzBuzzObjects[j].Denominator == 0)
                        {
                            returnString += fizzBuzzObjects[j].Message;
                            numberIsEvenlyDivisibleByDenominator = true;
                        }
                    }
                }
                if (!numberIsEvenlyDivisibleByDenominator)
                {
                    returnString += i;
                }
                returnString += "\r\n";
            }
            return returnString;
        }
    }
}
