namespace ExploringCSharp
{
    public class BooleanLogic
    {
        public bool NegatesItsInput(bool input)
        {
            if (input)
            {
                return false;
            }
            return true;
        }

        public bool NegatesItsInputSingleLine(bool input)
        {
            // Use resharper on the above to reduce it to a single line. -Reduced PC
            return !input;
        }

        public bool TrueIfBothInputsAreTrue(bool input1, bool input2)
        {
            switch (input1)
            {
                case true:
                    if (input2 == true)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                case false:
                    return false;
                default:
                    return false;
            }
        }

        public bool TrueIfBothInputsAreTrueSingleLine(bool input1, bool input2)
        {
            // Use resharper on the above to reduce it to a single line.
            return input1 == true & input2 == true;
        }

        public bool TrueIfEitherInputIsTrue(bool input1, bool input2)
        {
            // Use resharper on this to reduce it to a single line.
            if (input1 == true)
            {
                if (input2 == true)
                {
                    return true;
                }
                else
                {
                    return true;
                }
            }
            else
            {
                if (input2 == true)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public bool TrueIfEitherInputIsTrueSingleLine(bool input1, bool input2)
        {
            return input1 == true ? input2 == true || true : input2 == true;

            // Use resharper on the above to reduce it to a single line.
            return false;
        }

        public bool MustPayExtraSurchargeToRentACar(string gender, int age)
        {
            // Implement this one from scratch so that all tests pass.  
            // Age is a whole number.  The intended values and meanings of the string "gender"
            // can be inferred from the tests.
            if (gender == "M" & age > 25)
            {
                return true;
            }
            else
                switch (gender)
                {case "O": return true;
                    case "P": return true;

                }


            return false;
        }
    }
}
