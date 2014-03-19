using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LightSwitch
{
    public class MickeyEvilLightSwitch
    {
//        private decimal _price;
//
//        public decimal Price
//        {
//            get { return _price; }
//            set
//            {
//                if (value <= 0)
//                {
//                    throw new ArgumentException("Price must be positive");
//                }
//                _price = value;
//            }
//        }

        private bool IsSwitchOn { get; set; }

        private bool IsFullBright { get; set; }
        
        public const int DimmestDimmerValue = 0;
        public const int BrightestDimmerValue = 5;
        public const int LowestIntensityValue = 0;
        public const int HighestIntensityValue = 5;
        public int DimmerValue { get; private set; }
        public int IntensityLedValue { get; private set; }

        public int PhysicalLightBrightness
        {
            get
            {
                if (!IsSwitchOn)
                {
                    return DimmestDimmerValue;
                }
                if (IsFullBright)
                {
                    return IntensityLedValue = HighestIntensityValue;
                }
                return IntensityLedValue;
            }
        }

        public void ClickBigButton()
        {
            if (IsSwitchOn)
            {
                IsSwitchOn = false;
                IsFullBright = false;
            }
            else
            {
                IsSwitchOn = true;
            }
        }

        public void DoubleClickBigButton()
        {
            IsSwitchOn = true;
            IsFullBright = true;
        }

        public void ClickUpButton()
        {
            if (IsSwitchOn == false)
            {
                SwitchOffForUpButton();
            }
            if (IsSwitchOn)
            {
                SwitchOnForUpButton();
            }
        }

        public void ClickDownButton()
        {
            if (IsSwitchOn == false)
            {
                SwitchOffForDownButton();
            }
            if (IsSwitchOn)
            {
                SwitchOnForDownButton();
            }
        }

        public void SwitchOffForUpButton()
        {
            DimmerValue++;
            if (DimmerValue > BrightestDimmerValue)
            {
                DimmerValue = BrightestDimmerValue;
            }
        }

        public void SwitchOnForUpButton()
        {
            IntensityLedValue++;
            if (IntensityLedValue > HighestIntensityValue)
            {
                IntensityLedValue = HighestIntensityValue;
            }
        }

        public void SwitchOffForDownButton()
        {
            if (IsFullBright)
            {
                DimmerValue = BrightestDimmerValue - 1;
                IsFullBright = false;
            }
            else
            {
                DimmerValue--;
                if (DimmerValue < DimmestDimmerValue)
                {
                    DimmerValue = DimmestDimmerValue;
                }
            }
        }

        public void SwitchOnForDownButton()
        {
            if (IsFullBright)
            {
                IntensityLedValue = HighestIntensityValue - 1;
                IsFullBright = false;
            }
            else
            {
                IntensityLedValue--;
                if (IntensityLedValue < LowestIntensityValue)
                {
                    IntensityLedValue = LowestIntensityValue;
                }
            }
        }
    }
}
