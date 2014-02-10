using System;

namespace TriangleTyperApp
{
    public class InputValidations
    {
        public string GetInputValidations(string sideA, string sideB, string sideC)
        {

            Int64 number1 = 0;
            Int64 number2 = 0;
            Int64 number3 = 0;
            bool canConvertA = Int64.TryParse(sideA, out number1);
            bool canConvertB = Int64.TryParse(sideB, out number2);
            bool canConvertC = Int64.TryParse(sideC, out number3);
            if (canConvertA && canConvertB && canConvertC)
            {
                if (number1 <= 0 || number2 <= 0 || number3 <= 0)
                {
                    return "All inputs must be integers greater than 0.";
                }

                if (number1 + number2 <= number3 || number2 + number3 <= number1 || number1 + number3 <= number2)
                {
                    return "The sum of any two sides must be larger than the third side.";
                }
                else
                    return "ValidInput";
            
            }
            else
                return "Input is not a positive 64 bit integer";
        }

        }


    }
