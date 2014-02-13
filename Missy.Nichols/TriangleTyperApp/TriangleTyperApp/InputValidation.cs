using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleTyperApp
{
    public class InputValidation
    {
        int _sideAInt;
        int _sideBInt;
        int _sideCInt;

        public string TestInputValues(string sideA, string sideB, string sideC)
        {
            if (EasterEgg(sideA, sideB, sideC))
            {
                return "I'm sorry, Dave. I'm afraid I can't do that.";
            }
            if (!EachSideIsAPositiveInteger(sideA, sideB, sideC))
            {
                return "Each side must be a positive integer";
            }
            if (!TheSidesMakeATriangle())
            {
                return "The sides do not make a triangle";
            }
            if (!TheSidesAreSmallEnough(sideA, sideB, sideC))
            {
                return "Input out of range (cannot be more than 2,147,483,647)";
            }

            return "Good";
        }

        public bool EachSideIsAPositiveInteger(string sideA, string sideB, string sideC)
        {
            if (!int.TryParse(sideA, out _sideAInt))
            {
                return false;
            }
            if (!int.TryParse(sideB, out _sideBInt))
            {
                return false;
            }
            if (!int.TryParse(sideC, out _sideCInt))
            {
                return false;
            }
            if (_sideAInt <= 0 || _sideBInt <= 0 || _sideCInt <= 0)
            {
                return false;
            }

            return true;
        }

        public bool TheSidesMakeATriangle()
        {
            if (_sideAInt + _sideBInt <= _sideCInt)
            {
                return false;
            }
            if (_sideAInt + _sideCInt <= _sideBInt)
            {
                return false;
            }
            if (_sideBInt + _sideCInt <= _sideAInt)
            {
                return false;
            }
            return true;
        }

        public bool TheSidesAreSmallEnough(string sideA, string sideB, string sideC)
        {
            if (_sideAInt <= int.MaxValue && _sideBInt <= int.MaxValue && _sideCInt <= int.MaxValue)
            {
                return true;
            }
            return false;
        }

        public bool EasterEgg(string sideA, string sideB, string sideC)
        {
            if (sideA == "open the" && sideB == "pod bay" && sideC == "doors, HAL")
            {
                return true;
            }
            return false;
        }

    }
}
