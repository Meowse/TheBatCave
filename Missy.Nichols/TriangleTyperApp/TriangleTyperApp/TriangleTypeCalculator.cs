namespace TriangleTyperApp
{
    public class TriangleTypeCalculator
    {
        int _sideAInt;
        int _sideBInt;
        int _sideCInt;

        public string GetTriangleType(string sideA, string sideB, string sideC)
        {
            string iMSorryDaveICanTAllowYouToDoThat;
            if (StringValidation(sideA, sideB, sideC, out iMSorryDaveICanTAllowYouToDoThat)) return iMSorryDaveICanTAllowYouToDoThat;

            string inputMustBeAPositiveNumber;
            if (IntegerValidation(sideA, sideB, sideC, out inputMustBeAPositiveNumber)) return inputMustBeAPositiveNumber;

            string notATrianglePleaseReenterInputs;
            if (NotATriangle(out notATrianglePleaseReenterInputs)) return notATrianglePleaseReenterInputs;

            if (_sideAInt == _sideBInt && _sideBInt == _sideCInt)
            {
                return "Equilateral";
            }
            if (_sideAInt == _sideBInt || _sideBInt == _sideCInt || _sideAInt == _sideCInt)
            {
                return "Isosceles";
            }
            return "Scalene";
        }

        private bool NotATriangle(out string notATrianglePleaseReenterInputs)
        {
            if ((_sideAInt + _sideBInt < _sideCInt) || (_sideAInt + _sideCInt < _sideBInt) ||
                (_sideBInt + _sideCInt < _sideAInt))
            {
                {
                    notATrianglePleaseReenterInputs = "Not a triangle. Please reenter inputs.";
                    return true;
                }
            }
            notATrianglePleaseReenterInputs = null;
            return false;
        }

        private bool IntegerValidation(string sideA, string sideB, string sideC, out string inputMustBeAPositiveNumber)
        {
            if (!int.TryParse(sideA, out _sideAInt))
            {
                inputMustBeAPositiveNumber = "Input value must be an integer";
                return true;
            }

            if (!int.TryParse(sideB, out _sideBInt))
            {
                inputMustBeAPositiveNumber = "Input value must be an integer";
                return true;
            }

            if (!int.TryParse(sideC, out _sideCInt))
            {
                inputMustBeAPositiveNumber = "Input value must be an integer";
                return true;
            }

            if (_sideAInt <= 0 && _sideBInt <= 0 && _sideCInt <= 0)
            {
                inputMustBeAPositiveNumber = "Input must be a positive number";
                return true;
            }

            if (_sideAInt > int.MaxValue && _sideBInt > int.MaxValue && _sideCInt > int.MaxValue)
            {
                inputMustBeAPositiveNumber = "Input values(s) out of range.";
                return true;
            }
            inputMustBeAPositiveNumber = null;
            return false;
        }

        private static bool StringValidation(string sideA, string sideB, string sideC,
            out string iMSorryDaveICanTAllowYouToDoThat)
        {
            if (sideA.ToLower() == "open" && sideB.ToLower() == "podbay" && sideC.ToLower() == "door")
            {
                {
                    iMSorryDaveICanTAllowYouToDoThat = "I'm sorry, Dave, I can't allow you to do that.";
                    return true;
                }
            }

            if (string.IsNullOrEmpty(sideA) || string.IsNullOrEmpty(sideB) || string.IsNullOrEmpty(sideC))
            {
                {
                    iMSorryDaveICanTAllowYouToDoThat = "Please enter a length for each side";
                    return true;
                }
            }
            iMSorryDaveICanTAllowYouToDoThat = null;
            return false;
        }
    }
}
