using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzInfinite
{
    class FizzBuzzCounter
    {
        public string[] Counter(int countTo, int devisorOne, string stringOne, int devisorTwo, string stringTwo)
        {
            string[] result = new string[countTo + 1];

            for (int i = 0; i <= countTo; i++)
            {
                if (i == 0)
                {
                    result[i] = "";
                }
                else if (i % devisorOne == 0 && i % devisorTwo == 0)
                {
                    Console.WriteLine(stringOne + stringTwo);
                    result[i] = stringOne + stringTwo;
                }

                else if (i % devisorOne == 0)
                {
                    Console.WriteLine(stringOne);
                    result[i] = stringOne;
                }

                else if (i % devisorTwo == 0)
                {
                    Console.WriteLine(stringTwo);
                    result[i] = stringTwo;
                }

                else
                {
                    Console.WriteLine(i.ToString());
                    result[i] = i.ToString();
                }
            }

            return result;
        }
    }

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
                    if (i % fizzBuzzObjects[j].Denominator == 0)
                    {
                        returnString += fizzBuzzObjects[j].Message;
                        foundModalEqualToZero = true;
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
