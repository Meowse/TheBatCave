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
            return !input;

            // ### Used resharper on the above to reduce it to a single line.
        }

        public bool TrueIfBothInputsAreTrue(bool input1, bool input2)
        {
            if (input1)
            {
                if (input2)
                {
                    return true;
                }
                return false;
            }
            if (input1)
            {
                return false;
            }
            return false;
        }

        public bool TrueIfBothInputsAreTrueSingleLine(bool input1, bool input2)
        {
            return input1 && input2;

            // ### Used resharper on the above to reduce it to a single line.
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
                return true;
            }
            if (input2 == true)
            {
                return true;
            }
            return false;
        }

        public bool TrueIfEitherInputIsTrueSingleLine(bool input1, bool input2)
        {
            return input1 == true ? input2 == true || true : input2 == true;

            //### Used resharper on the above to reduce it to a single line.
        }

        public bool MustPayExtraSurchargeToRentACar(string gender, int age)
        {
            // Implement this one from scratch so that all tests pass.  
            // Age is a whole number.  The intended values and meanings of the string "gender"
            // can be inferred from the tests.
            return false;
        }
    }
}
